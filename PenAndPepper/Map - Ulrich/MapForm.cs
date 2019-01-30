using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using CsvHelper;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using PenAndPepper.CitiesTown;

namespace PenAndPepper
{
	/*
	 * Author: Ulrich Steffen
	 */
	public partial class MapForm : Form
	{
		Debug debug = new Debug();

		List<List<Panel>> panellistlist = new List<List<Panel>>();
		public Map map;
		public Spieler player;
		int width = 1600;
		int height = 900;
		public MapForm(int _width, int _height)
		{
			InitializeComponent();

			map = new Map(32, 32);

			if (_width != 0 && _height != 0)
			{
				width = _width;
				height = _height;
			}

			player = new Spieler(map.Widht / 2, map.Height / 2);
			this.Size = new System.Drawing.Size(width, height);
			//this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Map";

			this.Focus();

			createPanel(map.Height, map.Widht);
			map.FieldTrueVisible(player.XPos, player.YPos);
			RefreshPannel(map.Height, map.Widht, 0, 0);
			setPlayer();
			showMap(map.Height, map.Widht);
		}

		public MapForm(int _width, int _height, int mapSeed)
		{
			InitializeComponent();

			map = new Map(32, 32,mapSeed);

			if (_width != 0 && _height != 0)
			{
				width = _width;
				height = _height;
			}

			player = new Spieler(map.Widht / 2, map.Height / 2);
			this.Size = new System.Drawing.Size(width, height);
			//this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Map";

			this.Focus();

			createPanel(map.Height, map.Widht);
			map.FieldTrueVisible(player.XPos, player.YPos);
			RefreshPannel(map.Height, map.Widht, 0, 0);
			setPlayer();
			showMap(map.Height, map.Widht);
		}

		private void createPanel(int h, int w)
		{
			for (int i = 0; i < h; i++)
			{
				List<Panel> panellist = new List<Panel>();
				for (int j = 0; j < w; j++)
				{
					Panel panel = new Panel();
					panel.Location = new Point((j * width) / map.Widht, (i * height) / map.Height);
					panel.Size = new System.Drawing.Size(Convert.ToInt32(Math.Ceiling(1.0 * width / map.Widht)),
														 Convert.ToInt32(Math.Ceiling(1.0 * height / map.Height)));
					panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
					panellist.Add(panel);
				}
				panellistlist.Add(panellist);
			}
		}

		private void RefreshPannel()
		{
			panellistlist[player.YPos][player.XPos] = setColor(panellistlist[player.YPos][player.XPos], map.Map2DArray[player.YPos][player.XPos]);
			if (player.YPos > 0)
			{
				panellistlist[player.YPos - 1][player.XPos] = setColor(panellistlist[player.YPos - 1][player.XPos], map.Map2DArray[player.YPos - 1][player.XPos]);
			}
			if (player.YPos < map.Height - 1)
			{
				panellistlist[player.YPos + 1][player.XPos] = setColor(panellistlist[player.YPos + 1][player.XPos], map.Map2DArray[player.YPos + 1][player.XPos]);
			}
			if (player.XPos > 0)
			{
				panellistlist[player.YPos][player.XPos - 1] = setColor(panellistlist[player.YPos][player.XPos - 1], map.Map2DArray[player.YPos][player.XPos - 1]);
			}
			if (player.XPos < map.Widht - 1)
			{
				panellistlist[player.YPos][player.XPos + 1] = setColor(panellistlist[player.YPos][player.XPos + 1], map.Map2DArray[player.YPos][player.XPos + 1]);
			}
			DiscoverField();
		}

		private void RefreshPannel(int h, int w, int startx, int starty)
		{
			for (int y = starty; y < h + starty; y++)
			{
				for (int x = startx; x < w + startx; x++)
				{
					if (x >= 0 && x < map.Widht &&
						y >= 0 && y < map.Height)
					{
						panellistlist[y][x] = setColor(panellistlist[y][x], map.Map2DArray[y][x]);
					}
				}
			}

			DiscoverField();
		}

		private void showMap(int h, int w)
		{
			for (int i = 0; i < h; i++)
			{
				List<Panel> panellist = panellistlist[i];
				for (int j = 0; j < w; j++)
				{
					Controls.Add(panellist[j]);
				}
			}
		}

		private void setPlayer()
		{
			List<Panel> panellist = panellistlist[player.YPos];
			panellist[player.XPos].BackColor = Color.DarkRed;
		}

		private Panel setColor(Panel panel, Field field)
		{
			panel.BackColor = Color.Black;
			if (field.IsVisible == true)
			{
				switch (field.Incident)
				{
					case Field.FieldTyp.forrest:
						panel.BackColor = Color.DarkGreen;
						break;
					case Field.FieldTyp.plains:
						panel.BackColor = Color.LightGreen;
						break;
					case Field.FieldTyp.mountain:
						panel.BackColor = Color.Gray;
						break;
					case Field.FieldTyp.town:
						panel.BackColor = Color.White;
						break;
					case Field.FieldTyp.lake:
						panel.BackColor = Color.Blue;
						break;
					default:
						break;
				}
			}

			return panel;
		}

        public bool CheckForEnemys()
        {
            if (map.Map2DArray[player.XPos][player.YPos].Incident == Field.FieldTyp.town)
            {
                return false;
            }
            Random rnd = new Random();
            if(rnd.Next(0, 9) == 0)
            {
                return true;
            }
            return false;
        }
	
        void DiscoverField()
		{
			if (player.YPos > 0)
			{
				map.Map2DArray[player.YPos - 1][player.XPos].IsVisible = true;
			}
			if (player.YPos < map.Height - 1)
			{
				map.Map2DArray[player.YPos + 1][player.XPos].IsVisible = true;
			}
			if (player.XPos > 0)
			{
				map.Map2DArray[player.YPos][player.XPos - 1].IsVisible = true;
			}
			if (player.XPos < map.Widht - 1)
			{
				map.Map2DArray[player.YPos][player.XPos + 1].IsVisible = true;
			}
		}

		/*
         * Author: Christopher Wendholt
         * 
         * gets activated if Player hits a Town Field
         */
		void player_hit_town()
		{
			City city = new City();
			List<City> cities = new List<City>();

			cities = city.get_saved_data("city.csv");

			foreach (City cs in cities)
			{
				if (player.XPos == cs.Y_Pos && player.YPos == cs.X_Pos)
				{
#if DEBUG
					debug.write(this, MethodBase.GetCurrentMethod(), "Auf Stadt getroffen!");
#endif
					DialogResult dialogResult = MessageBox.Show("Wollen sie die Stadt betreten?",
																"Wollen sie die Stadt betreten?",
																MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
#if DEBUG
						debug.write(this, MethodBase.GetCurrentMethod(), "Spieler hat Stadt, bei (" + cs.X_Pos +"/"+ cs.Y_Pos + ") betreten!");
#endif

						UserControl_City userControl_City = new UserControl_City(player,cs.Y_Pos, cs.X_Pos);

						panel_city.Visible = true;

						panel_city.Controls.Add(userControl_City);
					}
					else
					{
						break;
					}
				}
			}
		}

		public void MapForm_KeyPressMove(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar)
			{
				case 'w':
					if (player.YPos > 0)
					{
						player.YPos--;
					}
					break;
				case 's':
					if (player.YPos < map.Height - 1)
					{
						player.YPos++;
					}
					break;
				case 'a':
					if (player.XPos > 0)
					{
						player.XPos--;
					}
					break;
				case 'd':
					if (player.XPos < map.Widht - 1)
					{
						player.XPos++;
					}
					break;
				default:
					break;
			}
			map.FieldTrueVisible(player.XPos, player.YPos);
#if DEBUG
			debug.write(this, MethodBase.GetCurrentMethod(), e.KeyChar + " X-Pos:" + player.XPos + " Y-Pos:" + player.YPos);
#endif

			///''''''''''''''''''''''''''''''''''''''''''
			player_hit_town();

			RefreshPannel();
			setPlayer();
		}

		/*
		 * Author: Christopher Wendholt
		 * 
		 * remove the Citypanel from the Screen and give Focus to the Mapform
		 */
		private void panel_city_ControlRemoved(object sender, ControlEventArgs e)
		{
			panel_city.Visible = false;
			this.Focus();
			RefreshPannel();
			setPlayer();
		}
	}
}

