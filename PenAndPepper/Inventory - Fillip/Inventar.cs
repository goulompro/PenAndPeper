using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenAndPepper
{
    public partial class Inventar : Form
    {
        public Inventar(Spieler player, List<Character> figuren)
        {
            InitializeComponent();
            string[,] ItemList = new string[4,5];
            treeView1.BeginUpdate();
            for (int x = 0; x == 4; x++)
            {
                for (int y = 1; y == 5; y++)
                {
                    treeView1.Nodes[x].Nodes.Add(ItemList[x, y]);
                }
            }
            treeView1.EndUpdate();
            //player.get_saved_data("player.csv");
            //figuren[1].get_saved_data("figure1.csv");
            //figuren[2].get_saved_data("figure2.csv");
            //figuren[3].get_saved_data("figure3.csv");
            textBoxPlayerName.Text = player.Name;
            textBoxPlayerStrength.Text = player.Strength.ToString();
            textBoxPlayerDexterity.Text = player.Dexterity.ToString();
            textBoxPlayerEndurance.Text = player.Endurance.ToString();
            textBoxPlayerCharisma.Text = player.Charisma.ToString();
            textBoxPlayerIntellignet.Text = player.Intelligent.ToString();
            textBoxPlayerItem.Text = player.Item.ToString();
            textBoxFigure1Name.Text = figuren[0].Name.ToString();
            textBoxFigure1Strength.Text = figuren[0].Strength.ToString();
            textBoxFigure1Dexterity.Text = figuren[0].Dexterity.ToString();
            textBoxFigure1Endurance.Text = figuren[0].Endurance.ToString();
            textBoxFigure1Charisma.Text = figuren[0].Charisma.ToString();
            textBoxFigure1Intelligent.Text = figuren[0].Intelligent.ToString();
            textBoxFigure1Item.Text = figuren[0].Item.ToString();
            textBoxFigure2Name.Text = figuren[1].Name.ToString();
            textBoxFigure2Strength.Text = figuren[1].Strength.ToString();
            textBoxFigure2Dexterity.Text = figuren[1].Dexterity.ToString();
            textBoxFigure2Endurance.Text = figuren[1].Endurance.ToString();
            textBoxFigure2Charisma.Text = figuren[1].Charisma.ToString();
            textBoxFigure2Intelligent.Text = figuren[1].Intelligent.ToString();
            textBoxFigure2Item.Text = figuren[1].Item.ToString();
            textBoxFigure3Name.Text = figuren[2].Name.ToString();
            textBoxFigure3Strength.Text = figuren[2].Strength.ToString();
            textBoxFigure3Dexterity.Text = figuren[2].Dexterity.ToString();
            textBoxFigure3Endurance.Text = figuren[2].Endurance.ToString();
            textBoxFigure3Charisma.Text = figuren[2].Charisma.ToString();
            textBoxFigure3Intelligent.Text = figuren[2].Intelligent.ToString();
            textBoxFigure3Item.Text = figuren[2].Item.ToString();
        }
    }
}
