using System;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Linq;
using System.Drawing;

namespace ConsoleApplication2udp
{
    public partial class Form1 : Form
    {
        formHome FormHome;
        formUDPConnection FormUDPConnection;
        formSettingsESP8266 FormSettingsESP8266;
        formSettingsProgram FormSettingsProgram;

		public Form1()
        {
            InitializeComponent();
            mdiProp();

			FormHome = new formHome();
			FormHome.FormClosed += FormHome_FormClosed;
			FormHome.MdiParent = this;
			FormHome.Dock = DockStyle.Fill;
			FormHome.Show();
		}

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }

		//--------------GUI-------------
		bool menuExpand = false;

		private void timerMenuTransition_Tick(object sender, EventArgs e)
		{
            if(menuExpand == false)
            {
                panelSubSettings.Height += 10;
                if(panelSubSettings.Height >= 148)
                {
                    timerMenuTransition.Stop();
                    menuExpand = true;
                }
			}
            else
            {
                panelSubSettings.Height -= 10;
                if(panelSubSettings.Height <= 51)
                {
                    timerMenuTransition.Stop();
                    menuExpand = false;
                }
            }
		}

		private void buttonSettings_Click(object sender, EventArgs e)
		{
            timerMenuTransition.Start();
			if (sidebarExpand == false)
			{
				timerSidebarTransition.Start();
			}
		}

        bool sidebarExpand = true;
		private void timerSidebarTransition_Tick(object sender, EventArgs e)
		{
            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if(sidebar.Width <= 56)
                {
                    sidebarExpand = false;
                    timerSidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 263)
                {
                    sidebarExpand = true;
                    timerSidebarTransition.Stop();

                    panelHome.Width = sidebar.Width;
					panelUDPConnetion.Width = sidebar.Width;
					panelSettings.Width = sidebar.Width;
					panelESP8266.Width = sidebar.Width;
					panelProgram.Width = sidebar.Width;
                    panelSubSettings.Width = sidebar.Width;
				}
            }
		}

		private void btnMenu_Click(object sender, EventArgs e)
		{
            timerSidebarTransition.Start();
			if(menuExpand == true)
			{
				timerMenuTransition.Start();
			}
		}

		private void buttonHome_Click(object sender, EventArgs e)
		{
            if(FormHome == null)
            {
                FormHome = new formHome();
                FormHome.FormClosed += FormHome_FormClosed;
                FormHome.MdiParent = this;
				FormHome.Dock = DockStyle.Fill;
				FormHome.Show();
            }
            else
            {
                FormHome.Activate();
            }
		}

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHome = null;
        }

		private void buttonUDPConnection_Click(object sender, EventArgs e)
		{
			if (FormUDPConnection == null)
			{
				FormUDPConnection = new formUDPConnection();
				FormUDPConnection.FormClosed += FormUDPConnection_FormClosed;
				FormUDPConnection.MdiParent = this;
				FormUDPConnection.Dock = DockStyle.Fill;
				FormUDPConnection.Show();
			}
			else
			{
				FormUDPConnection.Activate();
			}
		}

		private void FormUDPConnection_FormClosed(object sender, FormClosedEventArgs e)
		{
            FormUDPConnection = null;
		}

		private void buttonSettingsESP8266_Click(object sender, EventArgs e)
		{
			if (FormSettingsESP8266 == null)
			{
				FormSettingsESP8266 = new formSettingsESP8266();
				FormSettingsESP8266.FormClosed += FormSettingsESP8266_FormClosed;
				FormSettingsESP8266.MdiParent = this;
				FormSettingsESP8266.Dock = DockStyle.Fill;
				FormSettingsESP8266.Show();
			}
			else
			{
				FormSettingsESP8266.Activate();
			}
		}

		private void FormSettingsESP8266_FormClosed(object sender, FormClosedEventArgs e)
		{
            FormSettingsESP8266 = null;
		}

		private void buttonSettingsProgram_Click(object sender, EventArgs e)
		{
			if (FormSettingsProgram == null)
			{
				FormSettingsProgram = new formSettingsProgram();
				FormSettingsProgram.FormClosed += FormSettingsProgram_FormClosed;
				FormSettingsProgram.MdiParent = this;
				FormSettingsProgram.Dock = DockStyle.Fill;
				FormSettingsProgram.Show();
			}
			else
			{
				FormSettingsProgram.Activate();
			}
		}

		private void FormSettingsProgram_FormClosed(object sender, FormClosedEventArgs e)
		{
			FormSettingsProgram = null;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			//udpConnection.SendCloseMessage();

			Environment.Exit(Environment.ExitCode);
		}
	}
}
