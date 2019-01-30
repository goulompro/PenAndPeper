using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using PenAndPepper.CitiesTown;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using CsvHelper;
using PenAndPepper;

namespace PenAndPepper
{
	public partial class UserControl_City : UserControl
	{
		CityControl cityControl = new CityControl();
		private Spieler player;
		private City city = new City();

		List<PictureBox> picBox_encounters = new List<PictureBox>();
		public UserControl_City(Spieler _player,int x, int y)
		{
			InitializeComponent();

			player = _player;

			setup_Encounter();

			setup_City(x, y);
		}

		/*
		 * Author: Christopher Wendholt
		 * 
		 */
		public void setup_City(int x, int y)
		{		
			city = cityControl.get_City_by_Posititon(x, y);

			lbl_CityName.Text = city.Name;
		}

		private void btn_exitCity_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Wollen sie die Stadt verlassen?",
														"Wollen sie die Stadt verlassen?",
														MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				this.Parent.Controls.Clear();
			}
		}

		void setup_Encounter()
		{
			DirectoryInfo d = new DirectoryInfo(@"Encounter\\");
			FileInfo[] Files = d.GetFiles("*.png");
			List<String> str = new List<string>();
			foreach (FileInfo file in Files)
			{
				str.Add(file.Name);
			}


			Random random = new  Random();
			random.Next();

			string filePath = d + str[random.Next(str.Count)];

			MessageBox.Show(filePath);

			picBox_Encounter.SizeMode = PictureBoxSizeMode.Zoom;
			Bitmap MyImage = new Bitmap(filePath);
			picBox_Encounter.Image = MyImage;

		}

		private void UserControl_City_Load(object sender, EventArgs e)
		{
			this.Focus();
		}

		private void picBox_Encounter_Click(object sender, EventArgs e)
		{
			Encounter encounter = new Encounter(city, "merchant");

			dialogUI dialogUI = new dialogUI(player, encounter);
			dialogUI.ShowDialog();
		}
	}
}
