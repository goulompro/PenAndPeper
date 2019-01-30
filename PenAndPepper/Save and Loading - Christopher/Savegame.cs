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
	public class Savegame
	{
		public const string filepath = "Savegames\\";

		private int iD;
		private string player_File;
		private string city_File;
		private int mapSeed;

		public int ID { get => iD; set => iD = value; }
		public string Player_File { get => player_File; set => player_File = value; }
		public string City_file { get => city_File; set => city_File = value; }
		public int MapSeed { get => mapSeed; set => mapSeed = value; }
		public static string Filepath => filepath;

		public Savegame()
		{
		}

		public Savegame(int iD, string player_File, string city_file,string follower_file, int mapSeed)
		{
			this.iD = iD;
			this.player_File = player_File;
			this.city_File = city_file;
			this.mapSeed = mapSeed;
		}

		#region CSVHelper
		/*
		 * CSV-Writer
		 * 
		 * Soll ein einzelnes Objekt der Klasse Savegame in einer CSV-Datei speichern
		 * 
		 * Übergabeparameter:
		 * string file_path -> Pfad zu Datei
		 * List<Savegame> savegame -> Liste aller erzeugten Objekte
		 */
		public void save_data_in_csv(string file_path,List<Savegame> savegame)
		{ 
			TextWriter writer2 = new StreamWriter(filepath + file_path);

			var csv = new CsvWriter(writer2);

			csv.Configuration.Delimiter = ";";

			csv.WriteHeader<Savegame>();
			csv.NextRecord();
			csv.WriteRecords(savegame);

			writer2.Close();
		}

		/*
		 * CSV-Reader
		 * 
		 * Soll die Savegames aus der CSV-datei auslesen
		 * 
		 * Übergabeparameter:
		 * string file_path -> Pfad zu Datei
		 * 
		 * Rückgabeparameter:
		 * List<Savegame> Savegame -> Liste von Savegame in der CSV-Datei
		 */
		public List<Savegame> get_saved_data(string file_path)
		{
			if (File.Exists(filepath + file_path))
			{
				TextReader reader = new StreamReader(filepath + file_path, Encoding.Default);
				var csv = new CsvReader(reader);

				//CsvHelper Konfiguration
				csv.Configuration.Delimiter = ";";
				csv.Configuration.Encoding = Encoding.Default;

				var records = csv.GetRecords<Savegame>();
				return records.ToList();
			}
			else
			{
				return null; 
			}
		}
		#endregion
	}
}
