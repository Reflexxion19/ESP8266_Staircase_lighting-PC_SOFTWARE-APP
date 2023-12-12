using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApplication2udp
{
	public partial class formSettingsProgram : Form
	{
		public formSettingsProgram()
		{
			InitializeComponent();
		}

		private void formSettingsProgram_Load(object sender, EventArgs e)
		{
			this.ControlBox = false;
		}
	}
}
