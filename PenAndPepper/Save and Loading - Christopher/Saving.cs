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
	public partial class Saving : Form
	{
		Debug debug = new Debug();
		Savegame savegame = new Savegame();
		Savegame save = new Savegame();
		List<Savegame> savegames = new List<Savegame>();
		Savegame empty_savegame = new Savegame(0,null,null,null,0);

		public Saving(Savegame _savegame)
		{
			InitializeComponent();

			savegame = _savegame;

			savegames.AddRange(save.get_saved_data("savegames.csv"));

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
				saveGame.Click += new EventHandler(save_Game_CLick);
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

		private void save_Game_CLick(Object sender, EventArgs e)
		{
			for (int i = 0; i < saveGameCount; i++)
			{
				if (saveGameList[i] == sender as Panel)
				{
					DialogResult dialogResult = MessageBox.Show("Möchten sie wirklich speichern?", 
																"Möchten sie wirklich speichern?",
																MessageBoxButtons.YesNo);
					if (dialogResult == DialogResult.Yes)
					{
						Savegame new_savegame = new Savegame();

						new_savegame.ID = i;

						//Player fürs speichern übernehmen
						string player_file = "savegame" + i + ".player_file";
						copy_Files("player.csv", Savegame.filepath + player_file);
						new_savegame.Player_File = player_file;

						//Cities zum Speichern übernehmen
						string city_File = "savegame" + i + ".city_file";
						copy_Files(savegame.City_file, Savegame.filepath + city_File);
						new_savegame.City_file = city_File;

						new_savegame.MapSeed = savegame.MapSeed;

						savegames[i] = new_savegame;

						savegame.save_data_in_csv("savegames.csv", savegames);
					}
				}
			}
			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		void copy_Files(string source,string destination)
		{
			File.Copy(source, destination,true);
		}
	}
}
