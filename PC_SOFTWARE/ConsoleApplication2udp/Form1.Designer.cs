namespace ConsoleApplication2udp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.panelTopBar = new System.Windows.Forms.Panel();
			this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
			this.label_menu = new System.Windows.Forms.Label();
			this.btnMenu = new System.Windows.Forms.PictureBox();
			this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
			this.panelHome = new System.Windows.Forms.Panel();
			this.buttonHome = new System.Windows.Forms.Button();
			this.panelUDPConnetion = new System.Windows.Forms.Panel();
			this.buttonUDPConnection = new System.Windows.Forms.Button();
			this.panelSubSettings = new System.Windows.Forms.Panel();
			this.panelProgram = new System.Windows.Forms.Panel();
			this.buttonSettingsProgram = new System.Windows.Forms.Button();
			this.panelSettings = new System.Windows.Forms.Panel();
			this.buttonSettings = new System.Windows.Forms.Button();
			this.panelESP8266 = new System.Windows.Forms.Panel();
			this.buttonSettingsESP8266 = new System.Windows.Forms.Button();
			this.timerMenuTransition = new System.Windows.Forms.Timer(this.components);
			this.timerSidebarTransition = new System.Windows.Forms.Timer(this.components);
			this.panelTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
			this.sidebar.SuspendLayout();
			this.panelHome.SuspendLayout();
			this.panelUDPConnetion.SuspendLayout();
			this.panelSubSettings.SuspendLayout();
			this.panelProgram.SuspendLayout();
			this.panelSettings.SuspendLayout();
			this.panelESP8266.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTopBar
			// 
			this.panelTopBar.Controls.Add(this.nightControlBox1);
			this.panelTopBar.Controls.Add(this.label_menu);
			this.panelTopBar.Controls.Add(this.btnMenu);
			this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTopBar.Location = new System.Drawing.Point(0, 0);
			this.panelTopBar.Name = "panelTopBar";
			this.panelTopBar.Size = new System.Drawing.Size(1181, 44);
			this.panelTopBar.TabIndex = 29;
			// 
			// nightControlBox1
			// 
			this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
			this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.nightControlBox1.DefaultLocation = true;
			this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
			this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.EnableMaximizeButton = true;
			this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.EnableMinimizeButton = true;
			this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
			this.nightControlBox1.Location = new System.Drawing.Point(1042, 0);
			this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
			this.nightControlBox1.Name = "nightControlBox1";
			this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
			this.nightControlBox1.TabIndex = 0;
			// 
			// label_menu
			// 
			this.label_menu.AutoSize = true;
			this.label_menu.Font = new System.Drawing.Font("Montez", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_menu.ForeColor = System.Drawing.Color.White;
			this.label_menu.Location = new System.Drawing.Point(43, 9);
			this.label_menu.Name = "label_menu";
			this.label_menu.Size = new System.Drawing.Size(69, 28);
			this.label_menu.TabIndex = 5;
			this.label_menu.Text = "MENU";
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.Transparent;
			this.btnMenu.Image = global::ConsoleApplication2udp.Properties.Resources.menu;
			this.btnMenu.Location = new System.Drawing.Point(12, 10);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(25, 24);
			this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnMenu.TabIndex = 4;
			this.btnMenu.TabStop = false;
			this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
			// 
			// sidebar
			// 
			this.sidebar.BackColor = System.Drawing.Color.Black;
			this.sidebar.Controls.Add(this.panelHome);
			this.sidebar.Controls.Add(this.panelUDPConnetion);
			this.sidebar.Controls.Add(this.panelSubSettings);
			this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
			this.sidebar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.sidebar.Location = new System.Drawing.Point(0, 44);
			this.sidebar.Name = "sidebar";
			this.sidebar.Size = new System.Drawing.Size(263, 784);
			this.sidebar.TabIndex = 30;
			// 
			// panelHome
			// 
			this.panelHome.Controls.Add(this.buttonHome);
			this.panelHome.Location = new System.Drawing.Point(3, 3);
			this.panelHome.Name = "panelHome";
			this.panelHome.Size = new System.Drawing.Size(260, 51);
			this.panelHome.TabIndex = 32;
			// 
			// buttonHome
			// 
			this.buttonHome.BackColor = System.Drawing.Color.Black;
			this.buttonHome.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonHome.ForeColor = System.Drawing.Color.White;
			this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
			this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonHome.Location = new System.Drawing.Point(-11, -15);
			this.buttonHome.Name = "buttonHome";
			this.buttonHome.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
			this.buttonHome.Size = new System.Drawing.Size(284, 81);
			this.buttonHome.TabIndex = 31;
			this.buttonHome.Text = "  Home";
			this.buttonHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonHome.UseVisualStyleBackColor = false;
			this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
			// 
			// panelUDPConnetion
			// 
			this.panelUDPConnetion.Controls.Add(this.buttonUDPConnection);
			this.panelUDPConnetion.Location = new System.Drawing.Point(3, 60);
			this.panelUDPConnetion.Name = "panelUDPConnetion";
			this.panelUDPConnetion.Size = new System.Drawing.Size(260, 51);
			this.panelUDPConnetion.TabIndex = 33;
			// 
			// buttonUDPConnection
			// 
			this.buttonUDPConnection.BackColor = System.Drawing.Color.Black;
			this.buttonUDPConnection.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonUDPConnection.ForeColor = System.Drawing.Color.White;
			this.buttonUDPConnection.Image = global::ConsoleApplication2udp.Properties.Resources.connection;
			this.buttonUDPConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonUDPConnection.Location = new System.Drawing.Point(-11, -15);
			this.buttonUDPConnection.Name = "buttonUDPConnection";
			this.buttonUDPConnection.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
			this.buttonUDPConnection.Size = new System.Drawing.Size(284, 81);
			this.buttonUDPConnection.TabIndex = 31;
			this.buttonUDPConnection.Text = "  UDP Connetion";
			this.buttonUDPConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonUDPConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonUDPConnection.UseVisualStyleBackColor = false;
			this.buttonUDPConnection.Click += new System.EventHandler(this.buttonUDPConnection_Click);
			// 
			// panelSubSettings
			// 
			this.panelSubSettings.BackColor = System.Drawing.Color.Black;
			this.panelSubSettings.Controls.Add(this.panelProgram);
			this.panelSubSettings.Controls.Add(this.panelSettings);
			this.panelSubSettings.Controls.Add(this.panelESP8266);
			this.panelSubSettings.Location = new System.Drawing.Point(3, 117);
			this.panelSubSettings.Name = "panelSubSettings";
			this.panelSubSettings.Size = new System.Drawing.Size(260, 51);
			this.panelSubSettings.TabIndex = 34;
			// 
			// panelProgram
			// 
			this.panelProgram.Controls.Add(this.buttonSettingsProgram);
			this.panelProgram.Location = new System.Drawing.Point(0, 103);
			this.panelProgram.Name = "panelProgram";
			this.panelProgram.Size = new System.Drawing.Size(260, 51);
			this.panelProgram.TabIndex = 35;
			// 
			// buttonSettingsProgram
			// 
			this.buttonSettingsProgram.BackColor = System.Drawing.Color.Black;
			this.buttonSettingsProgram.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSettingsProgram.ForeColor = System.Drawing.Color.White;
			this.buttonSettingsProgram.Image = global::ConsoleApplication2udp.Properties.Resources.pc;
			this.buttonSettingsProgram.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettingsProgram.Location = new System.Drawing.Point(-11, -15);
			this.buttonSettingsProgram.Name = "buttonSettingsProgram";
			this.buttonSettingsProgram.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.buttonSettingsProgram.Size = new System.Drawing.Size(284, 81);
			this.buttonSettingsProgram.TabIndex = 31;
			this.buttonSettingsProgram.Text = "  Program";
			this.buttonSettingsProgram.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettingsProgram.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSettingsProgram.UseVisualStyleBackColor = false;
			this.buttonSettingsProgram.Click += new System.EventHandler(this.buttonSettingsProgram_Click);
			// 
			// panelSettings
			// 
			this.panelSettings.Controls.Add(this.buttonSettings);
			this.panelSettings.Location = new System.Drawing.Point(0, 0);
			this.panelSettings.Name = "panelSettings";
			this.panelSettings.Size = new System.Drawing.Size(260, 51);
			this.panelSettings.TabIndex = 33;
			// 
			// buttonSettings
			// 
			this.buttonSettings.BackColor = System.Drawing.Color.Black;
			this.buttonSettings.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSettings.ForeColor = System.Drawing.Color.White;
			this.buttonSettings.Image = global::ConsoleApplication2udp.Properties.Resources.settings;
			this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettings.Location = new System.Drawing.Point(-11, -15);
			this.buttonSettings.Name = "buttonSettings";
			this.buttonSettings.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
			this.buttonSettings.Size = new System.Drawing.Size(284, 81);
			this.buttonSettings.TabIndex = 31;
			this.buttonSettings.Text = "  Settings";
			this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSettings.UseVisualStyleBackColor = false;
			this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
			// 
			// panelESP8266
			// 
			this.panelESP8266.Controls.Add(this.buttonSettingsESP8266);
			this.panelESP8266.Location = new System.Drawing.Point(0, 52);
			this.panelESP8266.Name = "panelESP8266";
			this.panelESP8266.Size = new System.Drawing.Size(260, 51);
			this.panelESP8266.TabIndex = 33;
			// 
			// buttonSettingsESP8266
			// 
			this.buttonSettingsESP8266.BackColor = System.Drawing.Color.Black;
			this.buttonSettingsESP8266.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSettingsESP8266.ForeColor = System.Drawing.Color.White;
			this.buttonSettingsESP8266.Image = global::ConsoleApplication2udp.Properties.Resources.microcontroller;
			this.buttonSettingsESP8266.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettingsESP8266.Location = new System.Drawing.Point(-11, -15);
			this.buttonSettingsESP8266.Name = "buttonSettingsESP8266";
			this.buttonSettingsESP8266.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
			this.buttonSettingsESP8266.Size = new System.Drawing.Size(284, 81);
			this.buttonSettingsESP8266.TabIndex = 31;
			this.buttonSettingsESP8266.Text = "  ESP8266";
			this.buttonSettingsESP8266.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.buttonSettingsESP8266.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSettingsESP8266.UseVisualStyleBackColor = false;
			this.buttonSettingsESP8266.Click += new System.EventHandler(this.buttonSettingsESP8266_Click);
			// 
			// timerMenuTransition
			// 
			this.timerMenuTransition.Interval = 5;
			this.timerMenuTransition.Tick += new System.EventHandler(this.timerMenuTransition_Tick);
			// 
			// timerSidebarTransition
			// 
			this.timerSidebarTransition.Interval = 5;
			this.timerSidebarTransition.Tick += new System.EventHandler(this.timerSidebarTransition_Tick);
			// 
			// Form1
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1181, 828);
			this.Controls.Add(this.sidebar);
			this.Controls.Add(this.panelTopBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panelTopBar.ResumeLayout(false);
			this.panelTopBar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
			this.sidebar.ResumeLayout(false);
			this.panelHome.ResumeLayout(false);
			this.panelUDPConnetion.ResumeLayout(false);
			this.panelSubSettings.ResumeLayout(false);
			this.panelProgram.ResumeLayout(false);
			this.panelSettings.ResumeLayout(false);
			this.panelESP8266.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.PictureBox btnMenu;
		private System.Windows.Forms.Panel panelTopBar;
		private System.Windows.Forms.Label label_menu;
		private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
		private System.Windows.Forms.FlowLayoutPanel sidebar;
		private System.Windows.Forms.Button buttonHome;
		private System.Windows.Forms.Panel panelHome;
		private System.Windows.Forms.Panel panelUDPConnetion;
		private System.Windows.Forms.Button buttonUDPConnection;
		private System.Windows.Forms.Panel panelSettings;
		private System.Windows.Forms.Button buttonSettings;
		private System.Windows.Forms.Panel panelSubSettings;
		private System.Windows.Forms.Panel panelProgram;
		private System.Windows.Forms.Button buttonSettingsProgram;
		private System.Windows.Forms.Panel panelESP8266;
		private System.Windows.Forms.Button buttonSettingsESP8266;
		private System.Windows.Forms.Timer timerMenuTransition;
		private System.Windows.Forms.Timer timerSidebarTransition;
	}
}

