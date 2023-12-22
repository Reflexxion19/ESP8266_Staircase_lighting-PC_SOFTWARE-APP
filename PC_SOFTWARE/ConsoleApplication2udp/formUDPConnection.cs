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
using ConsoleApplication2udp.Properties;

namespace ConsoleApplication2udp
{
	public partial class formUDPConnection : Form
	{
		UDPSend udpConnection;

		bool connectionEstablished = false;
		string data = "";
		string date = "";

		public formUDPConnection()
		{
			InitializeComponent();

			udpConnection = new UDPSend();

			Thread thdUDPServer = new Thread(new ThreadStart(serverThread));
			thdUDPServer.IsBackground = true;
			thdUDPServer.Start();
		}

		private void formUDPConnection_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
		}

		public void serverThread()
		{
			if (!Properties.Settings.Default.ConnectionEstablished)
			{
				udpConnection.EstablishConnection();
				bool udpStarted = true;

				if (Properties.Settings.Default.ConnectionEstablished)
				{
					connectionEstablished = true;
					textBoxMyIP.Text = Properties.Settings.Default.MyIP + " | " + Properties.Settings.Default.MyHostname;
				}
			}

			while (connectionEstablished)
			{
				if (checkBox_record.Checked)
				{
					this.Invoke(new MethodInvoker(delegate ()
					{
						date = DateTime.Now.ToString("hh:mm:ss:fff;");
						data = date + Properties.Settings.Default.ReturnData;

						textBoxSender.Text = Properties.Settings.Default.ESP8266_IP;
						textBox_ip.Text = textBoxSender.Text;

						richTextBox_dataSaved.AppendText(data + "\n");
						richTextBox_dataSaved.ScrollToCaret();
					}
					));
				}
			}
		}

		private void button_send_Click(object sender, EventArgs e)
		{
			udpConnection.SendMessage(textBox_message.Text);
		}

		private void button_clear_Click(object sender, EventArgs e)
		{
			richTextBox_dataSaved.Text = "";
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			udpConnection.GetDeviceIP();
			textBoxMyIP.Text = Properties.Settings.Default.MyIP + " | " + Properties.Settings.Default.MyHostname;
		}

		private void formUDPConnection_Leave(object sender, EventArgs e)
		{

		}

		private void formUDPConnection_Enter(object sender, EventArgs e)
		{
			
		}
	}
}
