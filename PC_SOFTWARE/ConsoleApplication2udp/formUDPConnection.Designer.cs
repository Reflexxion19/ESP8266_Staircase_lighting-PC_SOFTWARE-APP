namespace ConsoleApplication2udp
{
	partial class formUDPConnection
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox_port = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox_ip = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button_send = new System.Windows.Forms.Button();
			this.textBox_message = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.richTextBoxDataReceived = new System.Windows.Forms.RichTextBox();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxMyIP = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxSender = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button_clear = new System.Windows.Forms.Button();
			this.checkBox_record = new System.Windows.Forms.CheckBox();
			this.richTextBox_dataSaved = new System.Windows.Forms.RichTextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox_port);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox_ip);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.button_send);
			this.groupBox1.Controls.Add(this.textBox_message);
			this.groupBox1.ForeColor = System.Drawing.Color.Lime;
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(657, 161);
			this.groupBox1.TabIndex = 29;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Send Message";
			// 
			// textBox_port
			// 
			this.textBox_port.Location = new System.Drawing.Point(84, 48);
			this.textBox_port.Name = "textBox_port";
			this.textBox_port.Size = new System.Drawing.Size(119, 20);
			this.textBox_port.TabIndex = 8;
			this.textBox_port.Text = "8080";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.Lime;
			this.label4.Location = new System.Drawing.Point(5, 48);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Port";
			// 
			// textBox_ip
			// 
			this.textBox_ip.Location = new System.Drawing.Point(84, 19);
			this.textBox_ip.Name = "textBox_ip";
			this.textBox_ip.Size = new System.Drawing.Size(119, 20);
			this.textBox_ip.TabIndex = 6;
			this.textBox_ip.Text = "192.168.3.251";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.Lime;
			this.label3.Location = new System.Drawing.Point(5, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "IP Destination";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Lime;
			this.label1.Location = new System.Drawing.Point(5, 79);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(45, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Mesage";
			// 
			// button_send
			// 
			this.button_send.ForeColor = System.Drawing.Color.Black;
			this.button_send.Location = new System.Drawing.Point(84, 126);
			this.button_send.Name = "button_send";
			this.button_send.Size = new System.Drawing.Size(82, 20);
			this.button_send.TabIndex = 1;
			this.button_send.Text = "Send";
			this.button_send.UseVisualStyleBackColor = true;
			this.button_send.Click += new System.EventHandler(this.button_send_Click);
			// 
			// textBox_message
			// 
			this.textBox_message.Location = new System.Drawing.Point(84, 76);
			this.textBox_message.Multiline = true;
			this.textBox_message.Name = "textBox_message";
			this.textBox_message.Size = new System.Drawing.Size(373, 35);
			this.textBox_message.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.ForeColor = System.Drawing.Color.Black;
			this.buttonStart.Location = new System.Drawing.Point(673, 25);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(86, 22);
			this.buttonStart.TabIndex = 28;
			this.buttonStart.Text = "Start UDP";
			this.buttonStart.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.richTextBoxDataReceived);
			this.groupBox2.Controls.Add(this.buttonRefresh);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.textBoxMyIP);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.textBoxSender);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.ForeColor = System.Drawing.Color.Lime;
			this.groupBox2.Location = new System.Drawing.Point(12, 181);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(748, 125);
			this.groupBox2.TabIndex = 30;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Received Message";
			// 
			// richTextBoxDataReceived
			// 
			this.richTextBoxDataReceived.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.richTextBoxDataReceived.ForeColor = System.Drawing.Color.Lime;
			this.richTextBoxDataReceived.Location = new System.Drawing.Point(82, 55);
			this.richTextBoxDataReceived.MaxLength = 2;
			this.richTextBoxDataReceived.Name = "richTextBoxDataReceived";
			this.richTextBoxDataReceived.ReadOnly = true;
			this.richTextBoxDataReceived.Size = new System.Drawing.Size(653, 59);
			this.richTextBoxDataReceived.TabIndex = 22;
			this.richTextBoxDataReceived.Text = "";
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
			this.buttonRefresh.Location = new System.Drawing.Point(586, 17);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(23, 22);
			this.buttonRefresh.TabIndex = 28;
			this.buttonRefresh.Text = "R";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.Lime;
			this.label5.Location = new System.Drawing.Point(323, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 25;
			this.label5.Text = "My Ip";
			// 
			// textBoxMyIP
			// 
			this.textBoxMyIP.Location = new System.Drawing.Point(362, 19);
			this.textBoxMyIP.Name = "textBoxMyIP";
			this.textBoxMyIP.ReadOnly = true;
			this.textBoxMyIP.Size = new System.Drawing.Size(218, 20);
			this.textBoxMyIP.TabIndex = 24;
			this.textBoxMyIP.Text = "192.168.3.109";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.Lime;
			this.label2.Location = new System.Drawing.Point(6, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Mesage";
			// 
			// textBoxSender
			// 
			this.textBoxSender.Location = new System.Drawing.Point(82, 19);
			this.textBoxSender.Name = "textBoxSender";
			this.textBoxSender.ReadOnly = true;
			this.textBoxSender.Size = new System.Drawing.Size(119, 20);
			this.textBoxSender.TabIndex = 23;
			this.textBoxSender.Text = "192.168.3.251";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.ForeColor = System.Drawing.Color.Lime;
			this.label6.Location = new System.Drawing.Point(6, 22);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 22;
			this.label6.Text = "IP Sender";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button_clear);
			this.groupBox3.Controls.Add(this.checkBox_record);
			this.groupBox3.Controls.Add(this.richTextBox_dataSaved);
			this.groupBox3.ForeColor = System.Drawing.Color.Lime;
			this.groupBox3.Location = new System.Drawing.Point(12, 312);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(748, 335);
			this.groupBox3.TabIndex = 31;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Record Message";
			// 
			// button_clear
			// 
			this.button_clear.ForeColor = System.Drawing.Color.Black;
			this.button_clear.Location = new System.Drawing.Point(6, 52);
			this.button_clear.Name = "button_clear";
			this.button_clear.Size = new System.Drawing.Size(61, 23);
			this.button_clear.TabIndex = 21;
			this.button_clear.Text = "Clear";
			this.button_clear.UseVisualStyleBackColor = true;
			this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
			// 
			// checkBox_record
			// 
			this.checkBox_record.AutoSize = true;
			this.checkBox_record.ForeColor = System.Drawing.Color.Lime;
			this.checkBox_record.Location = new System.Drawing.Point(6, 29);
			this.checkBox_record.Name = "checkBox_record";
			this.checkBox_record.Size = new System.Drawing.Size(61, 17);
			this.checkBox_record.TabIndex = 20;
			this.checkBox_record.Text = "Record";
			this.checkBox_record.UseVisualStyleBackColor = true;
			// 
			// richTextBox_dataSaved
			// 
			this.richTextBox_dataSaved.Location = new System.Drawing.Point(82, 19);
			this.richTextBox_dataSaved.Name = "richTextBox_dataSaved";
			this.richTextBox_dataSaved.Size = new System.Drawing.Size(653, 310);
			this.richTextBox_dataSaved.TabIndex = 10;
			this.richTextBox_dataSaved.Text = "";
			// 
			// formUDPConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(772, 658);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formUDPConnection";
			this.Text = "formUDPConnection";
			this.Load += new System.EventHandler(this.formUDPConnection_Load);
			this.Enter += new System.EventHandler(this.formUDPConnection_Enter);
			this.Leave += new System.EventHandler(this.formUDPConnection_Leave);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox_port;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox_ip;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_send;
		private System.Windows.Forms.TextBox textBox_message;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RichTextBox richTextBoxDataReceived;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxMyIP;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxSender;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button button_clear;
		private System.Windows.Forms.CheckBox checkBox_record;
		private System.Windows.Forms.RichTextBox richTextBox_dataSaved;
		}
}