using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PenAndPepper
{
    public partial class Menue : Form
    {
        public Menue()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 600);  

        }

        private void Menue_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void endBT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newBT_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            Start start = new Start();

            start.ShowDialog();

        }

		private void saveBT_Click(object sender, EventArgs e)
		{
			Loading loading = new Loading();

			loading.ShowDialog();
		}
	}

}
