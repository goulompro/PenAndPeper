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
    public partial class Classselectioncs : Form
    {
        Spieler player = new Spieler();
        
        public Classselectioncs(Spieler pl)
        {
            InitializeComponent();
            player = pl;
            player.Role = 1;
            this.Size = new System.Drawing.Size(1000, 600);
        }
        private void Classselection_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        private void BTwarroir_Click(object sender, EventArgs e)
        {
            player.Role = 1;
        }

        private void BTfinisch_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            PlaygroundForm game = new PlaygroundForm(player);
            game.ShowDialog();

            this.Close();
        }

        private void BTmagician_Click(object sender, EventArgs e)
        {
            player.Role = 2;
        }

        private void BTthief_Click(object sender, EventArgs e)
        {
            player.Role = 3;
        }
    }
}
