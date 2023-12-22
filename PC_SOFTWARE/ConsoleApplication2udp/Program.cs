using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConsoleApplication2udp
{
    static class Program
    {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
			UdpClient udpClient = new UdpClient(8080);
			GetUdpClient = udpClient;

			Thread thd_get_msg1 = new Thread(new ThreadStart(GetMessages));
			thd_get_msg1.IsBackground = true;
			thd_get_msg1.Start();

			Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

		public static UdpClient GetUdpClient { get; set; }

		public static void GetMessages()
		{
			UdpClient udpClient = GetUdpClient;

			while (true)
			{
				IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 8080);
				Byte[] receiveBytes = udpClient.Receive(ref RemoteIpEndPoint);
				Properties.Settings.Default.ReturnData = Encoding.ASCII.GetString(receiveBytes);
			}
		}
	}
}
