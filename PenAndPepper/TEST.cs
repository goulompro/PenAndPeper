using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenAndPepper
{
	public partial class TEST : UserControl
	{
		public TEST()
		{
			InitializeComponent();
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Wollen sie die Stadt verlassen?",
											"Wollen sie die Stadt verlassen?",
											MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.Parent.Controls.Clear();
				this.Visible = false;
			}
		}
	}
}
