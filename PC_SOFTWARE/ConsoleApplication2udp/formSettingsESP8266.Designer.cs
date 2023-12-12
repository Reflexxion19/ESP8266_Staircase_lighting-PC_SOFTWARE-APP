namespace ConsoleApplication2udp
{
	partial class formSettingsESP8266
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
			this.label_timeout = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label_timeout
			// 
			this.label_timeout.AutoSize = true;
			this.label_timeout.Font = new System.Drawing.Font("Montez", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_timeout.ForeColor = System.Drawing.Color.White;
			this.label_timeout.Location = new System.Drawing.Point(12, 9);
			this.label_timeout.Name = "label_timeout";
			this.label_timeout.Size = new System.Drawing.Size(96, 35);
			this.label_timeout.TabIndex = 5;
			this.label_timeout.Text = "Timeout:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Montez", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(114, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 39);
			this.textBox1.TabIndex = 4;
			// 
			// formSettingsESP8266
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label_timeout);
			this.Controls.Add(this.textBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formSettingsESP8266";
			this.Text = "formSettingsESP8266";
			this.Load += new System.EventHandler(this.formSettingsESP8266_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label_timeout;
		private System.Windows.Forms.TextBox textBox1;
	}
}