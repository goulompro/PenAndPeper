using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Author: Christopher Wendholt
 */
namespace PenAndPepper
{
	public partial class Loading : Form
	{
		Debug debug = new Debug();

		public Loading()
		{
			InitializeComponent();

			setup_Savegame_Panels();
		}

		private const int saveGameCount = 3;
		List<Panel> saveGameList = new List<Panel>();
		List<Label> saveGameNames = new List<Label>();
		List<Label> saveGameDetails = new List<Label>();

		private void setup_Savegame_Panels()
		{
			for (int i = 0; i < saveGameCount; i++)
			{
				//Setup the Name-Labels for the Savegame
				Panel saveGame = new Panel
				{
					BorderStyle = BorderStyle.FixedSingle,
					Size = new Size(336, 92),
					Location = new Point(12, 102 + i * 100)
				};
				saveGame.Click += new EventHandler(load_Game_CLick);
				saveGameList.Add(saveGame);

				Label name = new Label
				{
					Font = new Font("Old English Text MT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
					Location = new Point(22, 16),
					Size = new Size(290, 38),
					Text = Convert.ToString("Savegame " + i),
					Enabled = false
				};
				saveGameNames.Add(name);

				Label detail = new Label
				{
					Location = new Point(26, 66),
					Text = Convert.ToString("Name, Datum, Zeit"),
					Enabled = false
				};
				saveGameDetails.Add(detail);

				refresh_Savegame_Panel(i);
			}
		}

		private void refresh_Savegame_Panel(int i)
		{
			saveGameList[i].Controls.Add(saveGameNames[i]);
			saveGameList[i].Controls.Add(saveGameDetails[i]);
			this.Controls.Add(saveGameList[i]);
		}

		private void load_Game_CLick(Object sender, EventArgs e)
		{
			for (int i = 0; i < saveGameCount; i++)
			{
				if (saveGameList[i] == sender as Panel)
				{
					Savegame save = new Savegame();
					Spieler spieler = new Spieler();
					List<Savegame> savegame = new List<Savegame>();
					Spieler player = new Spieler();
					int mapSeed = new int();

					savegame = save.get_saved_data("savegames.csv");

					copy_Files(Savegame.filepath + savegame[i].City_file, "city.csv");

					player = spieler.get_saved_Spieler(Savegame.filepath + savegame[i].Player_File)[0];

					mapSeed = savegame[i].MapSeed;

					//MessageBox.Show(mapSeed + savegame[i].Player_File);
					//MessageBox.Show(player.Name);

					PlaygroundForm game = new PlaygroundForm(player, mapSeed);
					game.Show();
				}
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void copy_Files(string source, string destination)
		{
			File.Copy(source, destination,true);
		}
	}
}
