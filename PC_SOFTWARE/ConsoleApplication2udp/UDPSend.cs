using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.Xml.Serialization;
using System.Diagnostics;

namespace ConsoleApplication2udp
{
	public class UDPSend
	{
		bool firstTierConnectionEstablished = false;

		public UDPSend()
		{
			Properties.Settings.Default.MyIP = GetDeviceIP();
		}

		public void EstablishConnection()
		{
			SendConnectionMessage1();

			string[] parsedData = Properties.Settings.Default.ReturnData.Split(' ');
			string connectionEstablishmentMessage = "";

			if (parsedData.Length == 2)
			{
				connectionEstablishmentMessage = parsedData[0];
				Properties.Settings.Default.ESP8266_IP = parsedData[1];
			}

			if (connectionEstablishmentMessage == "FirstTierESP8266ConnectionPacket")
			{
				firstTierConnectionEstablished = true;

				SendConnectionMessage2();
			}

			if (firstTierConnectionEstablished == true && Properties.Settings.Default.ReturnData == "FinalESP8266ConnectionPacket")
			{
				Properties.Settings.Default.ConnectionEstablished = true;
			}
		}

		public void CloseConnection()
		{
			Program.GetUdpClient.Close();
		}

		public string GetDeviceIP()
		{
			string hostName = Dns.GetHostName();
			string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();

			Properties.Settings.Default.MyHostname = hostName;

			return myIP;
		}

		public void SendConnectionMessage1()
		{
			Program.GetUdpClient.Connect("192.168.3.251", Convert.ToInt16(8080));
			Byte[] senddata = Encoding.ASCII.GetBytes("FirstTierWindowsConnectionPacket " +
			Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString());
			Program.GetUdpClient.Send(senddata, senddata.Length);
		}

		public void SendConnectionMessage2()
		{
			Program.GetUdpClient.Connect(Properties.Settings.Default.ESP8266_IP, Convert.ToInt16(8080));
			Byte[] senddata = Encoding.ASCII.GetBytes("FinalWindowsConnectionPacket");
			Program.GetUdpClient.Send(senddata, senddata.Length);
		}

		public void SendMessage(string message)
		{
			if (Properties.Settings.Default.ConnectionEstablished)
			{
				Program.GetUdpClient.Connect(Properties.Settings.Default.ESP8266_IP, Convert.ToInt16(8080));
				Byte[] senddata = Encoding.ASCII.GetBytes(message);
				Program.GetUdpClient.Send(senddata, senddata.Length);
			}
		}

		public void SendCloseMessage()
		{
			if (Properties.Settings.Default.ConnectionEstablished)
			{
				Program.GetUdpClient.Connect(Properties.Settings.Default.ESP8266_IP, Convert.ToInt16(8080));
				Byte[] senddata = Encoding.ASCII.GetBytes("ConnectionClosed");
				Program.GetUdpClient.Send(senddata, senddata.Length);
			}
		}

		public string Ping()
		{
			if (Properties.Settings.Default.ConnectionEstablished)
			{
				Program.GetUdpClient.Connect(Properties.Settings.Default.ESP8266_IP, Convert.ToInt16(8080));
				Byte[] senddata = Encoding.ASCII.GetBytes("Ping");
				Program.GetUdpClient.Send(senddata, senddata.Length);

				Stopwatch stopWatch = new Stopwatch();
				stopWatch.Start();
				Thread.Sleep(2500);
				stopWatch.Stop();
				TimeSpan ts = stopWatch.Elapsed;

				while (ts.Seconds < 2 || Properties.Settings.Default.ReturnData != "Pong")
				{
					
				}

				return Properties.Settings.Default.ReturnData;
			}

			return "";
		}
	}
}
