#include <EEPROM.h>
#include <DNSServer.h>
#include <ESP8266WiFi.h>
#include <ESPAsyncTCP.h>
#include "ESPAsyncWebServer.h"

DNSServer dnsServer;
AsyncWebServer server(80);

bool apmode = false;

String wifi_ssid;
String wifi_psswd;
bool ssid_received = false;
bool psswd_received = false;
bool connected_first_time = true;

const char index_html[] PROGMEM = R"rawliteral(
<!DOCTYPE HTML><html>
  <head>
    <title>WiFi Setup</title>
    <meta name="viewport" content="width=device-width, initial-scale=1">
  </head>
  <body style="background-color: black;">
    <center style="color: white; font-size: xx-large; font-weight: bold;">ESP8266 WiFi Setup</center>
    <hr style="width: 100%; border-width: 2px;">
    <div style="display: flex; justify-content: center;">
      <form action="/get">
        <br>
        <table>
            <tr>
                <td style="color: white; font-weight: bold;">WiFi SSID:</td>
                <td><input type="text" name="ssid" style="margin: 10px;"></td>
            </tr>
            <tr>
                <td style="color: white; font-weight: bold;">WiFi PSSWD:</td>
                <td><input type="password" name="psswd" style="margin: 10px;"></td>
            </tr>
            <th colspan="2"><input type="submit" value="Submit" style="width: 150px; height: 30px; border-radius: 100px;"></th>
        </table>
      </form>
    </div>
  </body>
</html>)rawliteral";

//--------------------------Class---------------------------------------------

class CaptiveRequestHandler : public AsyncWebHandler {
public:
  CaptiveRequestHandler() {}
  virtual ~CaptiveRequestHandler() {}

  bool canHandle(AsyncWebServerRequest *request){
    //request->addInterestingHeader("ANY");
    return true;
  }

  void handleRequest(AsyncWebServerRequest *request) {
    request->send_P(200, "text/html", index_html); 
  }
};

void setup(){
  Serial.begin(115200);
  Serial.println();

  readData();                                     //Check EEPROM for stored credentials
  if (wifi_ssid.length() == 0) {                       //If not found set AP mode
    ap_mode();
    setupServerCommands();
  } else {
    if (testWifi()) {                             //If found try to connect to WiFi AP
      Serial.println("WiFi Connected!!!");
      apmode = false;
    } else {                                       //If failed set AP mode
      ap_mode();
      setupServerCommands();
    }
  }
  Serial.println("Setup Finished!");
}

//--------------------------Main----------------------------------------------

void loop(){
  //-----------------Setup later-------------------
  //if (digitalRead(D3) == LOW) {                   //If flash button is pressed
  //  ap_mode();                                    //Set AP mode
  //  setupServerCommands();
  //}
  //-----------------------------------------------

  if (apmode) {
    dnsServer.processNextRequest();                 //If apmode is true listen to incoming connection.

    if(ssid_received && psswd_received){
        ssid_received = false;
        psswd_received = false;
        clearData();
        writeData(wifi_ssid, wifi_psswd); 
        Serial.println("End...");
        Serial.println("Restarting...");
        ESP.restart();
    }
  } else {
      if (WiFi.status() == WL_CONNECTED){            //If WiFi connected
        //Your logic here

      } else{
        Serial.println();
        if (wifi_ssid.length() == 0) {                       //If not found set AP mode
          ap_mode();
          setupServerCommands();
        } else {
            if (testWifi()) {                             //If found try to connect to WiFi AP
              Serial.println("WiFi Connected!!!");
              apmode = false;
            } else {                                       //If failed set AP mode
                ap_mode();
                setupServerCommands();
            }
        }
      }
  }
}

//--------------------------WiFi Manager--------------------------------------

void ap_mode() {
  Serial.println("Setting up AP Mode");                               //Function to set as AP mode
  const char* ssidap = "esp8266";
  const char* passap = "";
  WiFi.mode(WIFI_AP);
  WiFi.softAP(ssidap, passap);
  Serial.print("AP IP address: ");
  Serial.println(WiFi.softAPIP());
  Serial.println("AP Mode. Please connect to http://192.168.4.1 to configure");
  apmode = true;                                 //Create web server
}

void readData() {                                 //Read from EEPROM memory
  EEPROM.begin(512);
  Serial.println("Reading From EEPROM..");
  for (int i = 0; i < 20; i++) {                  //Reading for SSID max for 20 characters long
    if (char(EEPROM.read(i)) > 0) {
      wifi_ssid += char(EEPROM.read(i));
    }
  }
  for (int i = 20; i < 40; i++) {                 //Reading for WiFi password max for 40 characters long
    if (char(EEPROM.read(i)) > 0) {
      wifi_psswd += char(EEPROM.read(i));
    }
  }

  Serial.println("Wifi ssid: " + wifi_ssid);
  Serial.print("Wifi password: ");
  for(int i = 0; i < wifi_psswd.length(); i++){
    if(i == 0 || i == wifi_psswd.length() - 1){
      Serial.print(wifi_psswd[i]);
    } else{
      Serial.print("~");
    }
  }
  Serial.println();
  EEPROM.end();
}

void writeData(String a, String b) {              //Writing WiFi credentials to EEPROM
  clearData();                                    //Clear current EEPROM memory
  EEPROM.begin(512);                              
  Serial.println("Writing to EEPROM...");
  for (int i = 0; i < 20; i++) {                  //Writing for SSID max for 20 characters long
    EEPROM.write(i, a[i]);
  }
  for (int i = 20; i < 40; i++) {                 //Reading for password max for 40 characters long
    EEPROM.write(i, b[i - 20]);
    Serial.println(b[i]);
  }
  EEPROM.commit();
  EEPROM.end();
  Serial.println("Write Successfull");
}

void clearData() {                                //Clear current EEPROM memory function
  EEPROM.begin(512);
  Serial.println("Clearing EEPROM ");
  for (int i = 0; i < 512; i++) {
    Serial.print(".");
    EEPROM.write(i, 0);
  }
  EEPROM.commit();
  EEPROM.end();
}

boolean testWifi() {                            //Test WiFi connection function
  Serial.print("Connecting to WiFi");
  WiFi.softAPdisconnect();
  WiFi.disconnect();
  WiFi.mode(WIFI_STA);
  WiFi.begin(wifi_ssid.c_str(), wifi_psswd.c_str());
  int c = 0;
  while (c < 15) {
    if (WiFi.status() == WL_CONNECTED) {
      WiFi.setAutoReconnect(true);
      WiFi.persistent(true);
      Serial.println();
      Serial.print("WiFi Status: ");
      Serial.println(WiFi.status());
      Serial.println(WiFi.localIP());
      delay(100);
      return true;
    }
    Serial.print(".");
    delay(900);
    c++;
  }
  Serial.println("Connection time out...");
  return false;
}

//--------------------------WebServer-----------------------------------------

void setupServerCommands(){
  Serial.println("Setting up Async WebServer");
  setupServer();
  Serial.println("Starting DNS Server");
  dnsServer.start(53, "*", WiFi.softAPIP());
  server.addHandler(new CaptiveRequestHandler()).setFilter(ON_AP_FILTER);//only when requested from AP
  server.begin();
}

void setupServer(){
  server.on("/", HTTP_GET, [](AsyncWebServerRequest *request){
      request->send_P(200, "text/html", index_html); 
      Serial.println("Client Connected");
  });
    
  server.on("/get", HTTP_GET, [] (AsyncWebServerRequest *request) {
      String inputMessage;
      String inputParam;
  
      if (request->hasParam("ssid")) {
        inputMessage = request->getParam("ssid")->value();
        inputParam = "ssid";
        wifi_ssid = inputMessage;
        Serial.print("SSID: ");
        Serial.println(inputMessage);
        ssid_received = true;
      }

      if (request->hasParam("psswd")) {
        inputMessage = request->getParam("psswd")->value();
        inputParam = "psswd";
        wifi_psswd = inputMessage;
        Serial.print("PSSWD: ");
        Serial.println(inputMessage);
        psswd_received = true;
      }
      request->send(200, "text/html", "The values entered by you have been successfully sent to the device <br><a href=\"/\">Return to Home Page</a>");
  });
}