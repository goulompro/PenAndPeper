using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace PenAndPepper
{
    public partial class PlaygroundForm : Form
    {
        public Spieler player = new Spieler();
        List<Character> figuren = new List<Character>();
        private string Feld;
        FormCombat FrmCombat;
		MapForm mapForm;

		public PlaygroundForm(Spieler pl)
        {
            InitializeComponent();
            this.player = pl;
			this.Size = new System.Drawing.Size(1000, 600);         
        }

		public PlaygroundForm(Spieler p1, int mapSeed)
		{
			InitializeComponent();
			mapForm = new MapForm(32, 32);
			this.player = p1;
			this.Size = new System.Drawing.Size(1000, 600);
		}

		/*
		 * Muss noch überarbeitet werden Fillip,
		 * Man kann statische eigenschaften in dem Designer festlegen.
		 *
		 * M.f.G
		 * Christopher
		 */
		private void Game_Load(object sender, EventArgs e)
        {
            textBoxTitelPlayer.Enabled = true;
            textBoxRolePlayer.Enabled = true;
            textBoxHpPlayer.Enabled = true;
            textBoxLevelPlayer.Enabled = true;
            textBoxNamePlayer.Enabled = true;
            textBoxNamePlayer.Text = player.Name;
			
			//Map laden
			mapForm  = new MapForm(pnl_Map.Width, pnl_Map.Height);
            OpenMap();

            this.Visible = true;
            textBoxTitelPlayer.Text = "Verschiedenes";
            if (player.Gender == true)
            {
                textBoxTitelPlayer.Text = "Herr";
            }
            if (player.Gender == false)
            {
                textBoxTitelPlayer.Text = "Frau";
            }
            textBoxNamePlayer.Text = player.Name;
            if (player.Role == 1)
            {
                textBoxRolePlayer.Text = "Krieger";
            }
            if (player.Role == 2)
            {
                textBoxRolePlayer.Text = "Zauberer";
            }
            if (player.Role == 3)
            {
                textBoxRolePlayer.Text = "Dieb";
            }
            textBoxHpPlayer.Text = "100"; player.Lifepoints = 100;
            textBoxLevelPlayer.Text = "1"; player.Level = 1;
            player.Nededexprience = 1000;

            textBoxNamePlayer.Enabled = false;
            textBoxTitelPlayer.Enabled = false;
            textBoxRolePlayer.Enabled = false;
            textBoxHpPlayer.Enabled = false;
            textBoxLevelPlayer.Enabled = false;

            //Default Werte für Gefährten

            Character figure = new Character
            {
                Gender = true,
                Name = "Siegfried Heilberg",
                Lifepoints = 100,
                Level = 1,
                Role = 2,
                Strength = 6
            };

            figuren.Add(figure);

            figure = new Character
            {
                Gender = false,
                Name = "Mara Teufelsweib",
                Lifepoints = 100,
                Level = 1,
                Role = 3,
                Strength = 8
            };

            figuren.Add(figure);

            figure = new Character
            {
                Gender = true,
                Name = "Lukas Kramper",
                Lifepoints = 100,
                Level = 1,
                Role = 1,
                Strength = 12
            };

            figuren.Add(figure);

            if (figuren[0].Gender)
            {
                textBoxTitelFellow1.Text = "Herr";
            }
            else
            {
                textBoxTitelFellow1.Text = "Frau";
            }

            if (figuren[1].Gender)
            {
                textBoxTitelFellow2.Text = "Herr";
            }
            else
            {
                textBoxTitelFellow2.Text = "Frau";
            }

            if (figuren[2].Gender)
            {
                textBoxTitelFellow3.Text = "Herr";
            }
            else
            {
                textBoxTitelFellow3.Text = "Frau";
            }
            textBoxNameFellow1.Text = figuren[0].Name;
            textBoxNameFellow2.Text = figuren[1].Name;
            textBoxNameFellow3.Text = figuren[2].Name;
            textBoxHpFellow1.Text = figuren[0].Lifepoints.ToString();
            textBoxHpFellow2.Text = figuren[1].Lifepoints.ToString();
            textBoxHpFellow3.Text = figuren[2].Lifepoints.ToString();
            textBoxLevelFellow1.Text = figuren[0].Level.ToString();
            textBoxLevelFellow2.Text = figuren[1].Level.ToString();
            textBoxLevelFellow3.Text = figuren[2].Level.ToString();
            textBoxRoleFellow1.Text = figuren[0].Role.ToString();
            textBoxRoleFellow2.Text = figuren[1].Role.ToString();
            textBoxRoleFellow3.Text = figuren[2].Role.ToString();

            figuren[0].Nededexprience = 1000;
            figuren[1].Nededexprience = 1000;
            figuren[2].Nededexprience = 1000;

            textBoxTitelFellow1.Enabled = false;
            textBoxTitelFellow2.Enabled = false;
            textBoxTitelFellow3.Enabled = false;
            textBoxNameFellow1.Enabled = false;
            textBoxNameFellow2.Enabled = false;
            textBoxNameFellow3.Enabled = false;
            textBoxHpFellow1.Enabled = false;
            textBoxHpFellow2.Enabled = false;
            textBoxHpFellow3.Enabled = false;
            textBoxLevelFellow1.Enabled = false;
            textBoxLevelFellow2.Enabled = false;
            textBoxLevelFellow3.Enabled = false;
            textBoxRoleFellow1.Enabled = false;
            textBoxRoleFellow2.Enabled = false;
            textBoxRoleFellow3.Enabled = false;
        }

        /*
		 * Author: Ulrich Steffen (verbessert)
		 */
        private void Kampftest_Click(object sender, EventArgs e)
        {
            List<Character> enemyList = new List<Character>();
            Character enemy = new Character
            {
                Name = "Baer",
                Lifepoints = 100,
                Strength = 10
            };
            enemyList.Add(enemy);
            enemy = new Character
            {
                Name = "Wolf",
                Lifepoints = 50,
                Strength = 5
            };
            enemyList.Add(enemy);
            
            FrmCombatStart(Field.FieldTyp.plains);
        }

        /*
		 * Author: Ulrich Steffen
		 * 
		 */
        private void FrmCombatStart(Field.FieldTyp fieldTyp)
        {
            List<Character> Combatfigure = new List<Character>();

            Combatfigure.Add(player);
            Combatfigure.AddRange(figuren);

            Feld = "Sie werden angegriffen";
            MessageBox.Show(Feld);
            pnl_Combat.Visible = true;
            FrmCombat = new FormCombat(Combatfigure, fieldTyp);
            FrmCombat.TopLevel = false;

            this.pnl_Combat.Controls.Add(FrmCombat);
            pnl_Map.Visible = false;
            FrmCombat.Show();
            FrmCombat.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCombatEnd);
        }

        /*
		 * Author: Ulrich Steffen
		 * 
		 */
        private void FrmCombatEnd(object sender, EventArgs e)
        {
            UpdatePlayerFromCombat(FrmCombat.PlayerList);
            GivePlayerExp();
            UpdatePlayerSide();
            pnl_Map.Visible = true;
        }

        /*
		 * Author: Ulrich Steffen
		 * 
		 */
        private void UpdatePlayerFromCombat(List<Character> playerfigures)
        {
            player.Lifepoints = playerfigures[0].Lifepoints;
            for(int i = 0; i < playerfigures.Count() - 1; i++)
            {
                figuren[i].Lifepoints = playerfigures[i + 1].Lifepoints;
            }
        }

        /*
		 * Author: Ulrich Steffen
		 * 
		 */
        private void UpdatePlayerSide()
        {
            textBoxHpPlayer.Text = player.Lifepoints.ToString();
            textBoxLevelPlayer.Text = player.Level.ToString();
            textBoxHpFellow1.Text = figuren[0].Lifepoints.ToString();
            textBoxLevelFellow1.Text = figuren[0].Level.ToString();
            textBoxHpFellow2.Text = figuren[1].Lifepoints.ToString();
            textBoxLevelFellow2.Text = figuren[1].Level.ToString();
            textBoxHpFellow3.Text = figuren[2].Lifepoints.ToString();
            textBoxLevelFellow3.Text = figuren[2].Level.ToString();
        }

        public void GivePlayerExp()
        {
            int experiencecount = 6;
            player.Experience = player.Experience + (experiencecount * 200);
            if (player.Experience > player.Nededexprience)
            {
                player.Level = player.Level + 1;
                MessageBox.Show(player.Name + " ist jetzt Level " + player.Level + "!", "Nächstes Level!");
                player.Nededexprience = player.Nededexprience + (player.Nededexprience * player.Level);
                switch (player.Role)
                {
                    case 1:
                        player.Lifepoints = player.Lifepoints + 50;
                        player.Strength = player.Strength + 3;
                        player.Dexterity = player.Dexterity + 1;
                        player.Endurance = player.Endurance + 2;
                        player.Charisma = player.Charisma + 3;
                        player.Intelligent = player.Intelligent + 1;
                        break;
                    case 2:
                        player.Lifepoints = player.Lifepoints + 20;
                        player.Strength = player.Strength + 1;
                        player.Dexterity = player.Dexterity + 2;
                        player.Endurance = player.Endurance + 1;
                        player.Charisma = player.Charisma + 3;
                        player.Intelligent = player.Intelligent + 5;
                        break;
                    case 3:
                        player.Lifepoints = player.Lifepoints + 10;
                        player.Strength = player.Strength + 2;
                        player.Dexterity = player.Dexterity + 3;
                        player.Endurance = player.Endurance + 3;
                        player.Charisma = player.Charisma + 3;
                        player.Intelligent = player.Intelligent + 2;
                        break;
                }
                
                for(int i = 0; i < figuren.Count(); i++)
                {
                    figuren[i].Experience = figuren[i].Experience + (experiencecount * 200);
                    if (figuren[i].Experience > figuren[i].Nededexprience)
                    {
                        figuren[i].Level = figuren[i].Level + 1;
                        MessageBox.Show(figuren[i].Name + " ist jetzt Level " + figuren[i].Level + "!", "Nächstes Level!");
                        figuren[i].Nededexprience = figuren[i].Nededexprience + (figuren[i].Nededexprience * figuren[i].Level);
                        switch (figuren[i].Role)
                        {
                            case 1:
                                figuren[i].Lifepoints = figuren[i].Lifepoints + 50;
                                figuren[i].Strength = figuren[i].Strength + 3;
                                figuren[i].Dexterity = figuren[i].Dexterity + 1;
                                figuren[i].Endurance = figuren[i].Endurance + 2;
                                figuren[i].Charisma = figuren[i].Charisma + 3;
                                figuren[i].Intelligent = figuren[i].Intelligent + 1;
                                break;
                            case 2:
                                figuren[i].Lifepoints = figuren[i].Lifepoints + 20;
                                figuren[i].Strength = figuren[i].Strength + 1;
                                figuren[i].Dexterity = figuren[i].Dexterity + 2;
                                figuren[i].Endurance = figuren[i].Endurance + 1;
                                figuren[i].Charisma = figuren[i].Charisma + 3;
                                figuren[i].Intelligent = figuren[i].Intelligent + 5;
                                break;
                            case 3:
                                figuren[i].Lifepoints = figuren[i].Lifepoints + 10;
                                figuren[i].Strength = figuren[i].Strength + 2;
                                figuren[i].Dexterity = figuren[i].Dexterity + 3;
                                figuren[i].Endurance = figuren[i].Endurance + 3;
                                figuren[i].Charisma = figuren[i].Charisma + 3;
                                figuren[i].Intelligent = figuren[i].Intelligent + 2;
                                break;
                        }
                    }
                }
            }
        }

		/*
		 * Author: Christopher Wendholt
		 * 
		 * Open the Map and hide everything else
		 */
		private void OpenMap()
		{
			mapForm.TopLevel = false;

			pnl_Map.Controls.Add(mapForm);

            pnl_Map.Visible = true;
			mapForm.Show();
   		}

        /*
		 * Author: Ulrich Steffen
		 * 
		 */
        private void PlaygroundForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (pnl_Map.Visible == true)
            {
                mapForm.MapForm_KeyPressMove(sender, e);
                if(mapForm.CheckForEnemys())
                {
                    FrmCombatStart(mapForm.map.Map2DArray[mapForm.player.XPos][mapForm.player.YPos].Incident);
                }
            }
        }

        /*
		 * Author: Ulrich Steffen
		 */
        private void btn_Inventar_Click(object sender, EventArgs e)
        {
            Inventar inventar = new Inventar(player, figuren);

            inventar.Show();
        }

		/*
		 * Author: Christopher Wendholt
		 */
		private void savegameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Spieler spieler = new Spieler();
			Character character = new Character();

			spieler.save_data_in_csv("player.csv",player);

			Savegame savegame = new Savegame(0, player.Name, "city.csv","follower.csv", mapForm.map.MapSeed);

			Saving saving = new Saving(savegame);
			saving.ShowDialog();
		}

	}
}
