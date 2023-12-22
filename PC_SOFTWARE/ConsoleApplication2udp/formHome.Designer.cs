namespace ConsoleApplication2udp
{
	partial class formHome
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
			this.btn_off = new ReaLTaiizor.Controls.Button();
			this.btn_rgb = new ReaLTaiizor.Controls.Button();
			this.label_establishConnection = new ReaLTaiizor.Controls.BigLabel();
			this.SuspendLayout();
			// 
			// btn_off
			// 
			this.btn_off.BackColor = System.Drawing.Color.Transparent;
			this.btn_off.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_off.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_off.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_off.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_off.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btn_off.Image = null;
			this.btn_off.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_off.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_off.Location = new System.Drawing.Point(12, 12);
			this.btn_off.Name = "btn_off";
			this.btn_off.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_off.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_off.Size = new System.Drawing.Size(120, 40);
			this.btn_off.TabIndex = 0;
			this.btn_off.Text = "OFF";
			this.btn_off.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btn_off.Click += new System.EventHandler(this.btn_off_Click);
			// 
			// btn_rgb
			// 
			this.btn_rgb.BackColor = System.Drawing.Color.Transparent;
			this.btn_rgb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_rgb.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_rgb.EnteredBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_rgb.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_rgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.btn_rgb.Image = null;
			this.btn_rgb.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_rgb.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
			this.btn_rgb.Location = new System.Drawing.Point(12, 58);
			this.btn_rgb.Name = "btn_rgb";
			this.btn_rgb.PressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_rgb.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
			this.btn_rgb.Size = new System.Drawing.Size(120, 40);
			this.btn_rgb.TabIndex = 1;
			this.btn_rgb.Text = "RGB";
			this.btn_rgb.TextAlignment = System.Drawing.StringAlignment.Center;
			this.btn_rgb.Click += new System.EventHandler(this.btn_rgb_Click);
			// 
			// label_establishConnection
			// 
			this.label_establishConnection.AutoSize = true;
			this.label_establishConnection.BackColor = System.Drawing.Color.Transparent;
			this.label_establishConnection.Font = new System.Drawing.Font("Segoe UI", 20F);
			this.label_establishConnection.ForeColor = System.Drawing.Color.Red;
			this.label_establishConnection.Location = new System.Drawing.Point(468, 404);
			this.label_establishConnection.Name = "label_establishConnection";
			this.label_establishConnection.Size = new System.Drawing.Size(0, 37);
			this.label_establishConnection.TabIndex = 2;
			// 
			// formHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label_establishConnection);
			this.Controls.Add(this.btn_rgb);
			this.Controls.Add(this.btn_off);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "formHome";
			this.Text = "formHome";
			this.Load += new System.EventHandler(this.formHome_Load);
			this.Enter += new System.EventHandler(this.formHome_Enter);
			this.Leave += new System.EventHandler(this.formHome_Leave);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.Button btn_off;
		private ReaLTaiizor.Controls.Button btn_rgb;
		private ReaLTaiizor.Controls.BigLabel label_establishConnection;
	}
}