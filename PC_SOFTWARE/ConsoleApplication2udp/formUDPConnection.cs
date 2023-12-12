using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace ConsoleApplication2udp
{
	public partial class formUDPConnection : Form
	{
		bool connectionEstablished = false;

		public formUDPConnection()
		{
			InitializeComponent();
			myIP();
		}

		private void formUDPConnection_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
		}

		private void button_send_Click(object sender, EventArgs e) //CLIENT
		{
			UdpClient udpClient = new UdpClient();
			udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));
			Byte[] senddata = Encoding.ASCII.GetBytes(textBox_message.Text);
			udpClient.Send(senddata, senddata.Length);
		}



		public void serverThread() //SERVER
		{
			UdpClient udpClient = new UdpClient(8080);
			while (status)
			{
				IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
				Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
				string returnData = Encoding.ASCII.GetString(receiveBytes);


				this.Invoke(new MethodInvoker(delegate ()
				{
					date = DateTime.Now.ToString("hh:mm:ss:fff;");
					data = date + returnData;

					if(returnData == "rlksc")
					{
						connectionEstablished = true;

						udpClient.Connect(textBox_ip.Text, Convert.ToInt16(textBox_port.Text));
						Byte[] senddata = Encoding.ASCII.GetBytes("yes");
						udpClient.Send(senddata, senddata.Length);
					}

					if (connectionEstablished)
					{
						textBoxSender.Text = RemoteIpEndPoint.Address.ToString();
						textBox_ip.Text = textBoxSender.Text;

						richTextBoxDataReceived.AppendText(data + "\n");
						richTextBoxDataReceived.ScrollToCaret();




						if (checkBox_record.Checked == true)
						{
							richTextBox_dataSaved.AppendText(data + "\n");
							richTextBox_dataSaved.ScrollToCaret();
						}
					}
				}



				));
			}



		}


		string data = "";
		string date = "";

		string[] data_str = new string[25];



		private void textBoxMyIP_Click(object sender, EventArgs e)
		{
			myIP();
		}

		void myIP()
		{
			string hostName = Dns.GetHostName(); // Retrive the Name of HOST

			//string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
			string myIP = "192.168.152.109"; //for testing purposes
			textBoxMyIP.Text = myIP + " " + hostName;

		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			richTextBox_dataSaved.Text = "";
		}

		Boolean status = false;
		private void buttonStart_Click(object sender, EventArgs e)
		{
			Thread thdUDPServer = new Thread(new ThreadStart(serverThread));

			thdUDPServer.IsBackground = true; //<-- Set the thread to work in background
			thdUDPServer.Start();


			status = true;
			buttonStart.Visible = false;

		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			myIP();
		}
	}
}
