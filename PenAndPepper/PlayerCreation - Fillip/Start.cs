using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CsvHelper;

namespace PenAndPepper
{
    public partial class Start : Form
    {
        Spieler player = new Spieler();

        public Start()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 600);

        }

        private void Start_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = false;

            Menue menue = new Menue();

            menue.ShowDialog();

            this.Close();
        }
        private void BTBoy_Click(object sender, EventArgs e)
        {
            player.Gender = true;
        }
        private void BTGirl_Click(object sender, EventArgs e)
        {
            player.Gender = false;
        }
        private void BTready_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            player.Name = this.textBoxName.Text;
            
            Classselectioncs cs = new Classselectioncs(player);
            cs.ShowDialog();

            this.Close();
        }
    }
}