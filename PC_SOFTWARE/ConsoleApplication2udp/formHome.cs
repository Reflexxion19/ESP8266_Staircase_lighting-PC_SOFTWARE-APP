using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConsoleApplication2udp
{
	public partial class formHome : Form
	{
		UDPSend udpConnection;

		public formHome()
		{
			udpConnection = new UDPSend();
			InitializeComponent();

			Thread thd = new Thread(new ThreadStart(serverThread));
			thd.IsBackground = true;
			thd.Start();
		}

		private void formHome_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
		}

		public void serverThread()
		{
			while (!Properties.Settings.Default.ConnectionEstablished)
			{
				label_establishConnection.Text = "Establishing connection...";
				//label_establishConnection.Text = Properties.Settings.Default.ReturnData;

				udpConnection.EstablishConnection();

				if (Properties.Settings.Default.ConnectionEstablished)
				{
					SetVisibility();
				}
			}

			label_establishConnection.Text = "False";
		}

		delegate void SetLabelCallback();

		private void SetVisibility()
		{
			if (this.label_establishConnection.InvokeRequired)
			{
				SetLabelCallback d = new SetLabelCallback(SetVisibility);
				this.Invoke(d, new object[] {});
			}
			else
			{
				this.label_establishConnection.Visible = false;
			}
		}

		private void btn_off_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.ConnectionEstablished)
			{
				udpConnection.SendMessage("OFF");
			}
		}

		private void btn_rgb_Click(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.ConnectionEstablished)
			{
				udpConnection.SendMessage("Mode1");
			}
		}

		private void formHome_Leave(object sender, EventArgs e)
		{
			
		}

		private void formHome_Enter(object sender, EventArgs e)
		{
			
		}
	}
}
