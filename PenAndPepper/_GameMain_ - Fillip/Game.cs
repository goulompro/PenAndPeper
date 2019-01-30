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
    public partial class Game : Form
    {
        Spieler spieler = new Spieler();
        List<Spieler> player = new List<Spieler>();
        
        public Game()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(1000, 600);

        }

        private void Game_Load(object sender, EventArgs e)
        {
            this.Visible = true;
            if (spieler.Gender == true)
            {
                textBoxtitel.Text = "Herr";
            }
            if (spieler.Gender == false)
            {
                textBoxtitel.Text = "Frau";
            }
            textBoxname.Text = spieler.Name;
            if (spieler.Role == 1)
            {
                textBoxrole.Text = "Krieger";
            }
            if (spieler.Role == 2)
            {
                textBoxrole.Text = "Zauberer";
            }
            if (spieler.Role == 3)
            {
                textBoxrole.Text = "Dieb";
            }
            
            
            
        }

        //private void panelmap_Paint(object sender, PaintEventArgs e)
        //{
        //    MapForm map = new MapForm();
        //    map.TopLevel = false;
        //    panelmap.Controls.Add(map);
        //    map.Show();
        //}
    }
}
