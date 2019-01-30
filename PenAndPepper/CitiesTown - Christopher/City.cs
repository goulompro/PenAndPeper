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
using System.Linq;

namespace PenAndPepper
{
    public class City
    {
        Debug debug = new Debug();

        private string name;
        private int x_Pos;
        private int y_Pos;

		/* Konstruktoren
		 * 
		 */
		public City()
        {
            
        }

		public City(string Name, int X_Pos, int Y_Pos)
		{
			this.Name = Name;

			this.X_Pos = X_Pos;
			this.Y_Pos = Y_Pos;
		}

		public City(int _Xpos, int _Ypos)
		{
			this.Y_Pos = _Ypos;
			this.X_Pos = _Xpos;

			this.Name = get_Random_Name();
#if DEBUG
			debug.write(this, MethodBase.GetCurrentMethod(), "Namen für die Stadt bei: " + _Xpos + "/" + _Ypos + "ist: " + this.name);
#endif
		}

		//#####################################################################################

		/*
         * CSV-Reader
         * 
         * Soll die Städtenamen aus der CSV-datei auslesen
         * 
         * Übergabeparameter:
         * string file_path -> Pfad zu Datei
         * 
         * Rückgabeparameter:
         * List<name> Namen -> Liste von Namen in der CSV-Datei
         */
		public List<City> get_saved_data(string file_path)
        {
            if (File.Exists(file_path))
            {
                TextReader reader = new StreamReader(file_path, Encoding.Default);
                var csv = new CsvReader(reader);

                //CsvHelper Konfiguration
                csv.Configuration.Delimiter = ";";
                csv.Configuration.Encoding = Encoding.Default;

				var records = csv.GetRecords<City>();
				return records.ToList();
			}
            else
            {
                return null;
            }
        }

		/*
         * CSV-Writer
         * 
         * Soll die Objekte der Klasse City in einer CSV-datei speicher
         * 
         * Übergabeparameter:
         * string file_path -> Pfad zu Datei
         * List<City> cities -> Liste aller erzeugten Objekte
         */
		public void save_data_in_csv(string file_path,List<City> cities)
		{
			TextWriter writer = new StreamWriter(file_path);
			var csv = new CsvWriter(writer);

			csv.Configuration.Delimiter = ";";

			csv.WriteHeader<City>();
			csv.NextRecord();
			csv.WriteRecords(cities);
			csv.NextRecord();

			writer.Close();
		}

		private string get_Random_Name()
        {
            Random rnd = new Random();
            List<City> cities = new List<City>();
            City city = new City();

            cities = get_saved_data("stadtnamen.csv");
            city.Name = cities[rnd.Next(0, cities.Count-1)].name;

            return city.name;
        }

		public string Name { get => name; set => name = value; }
        public int X_Pos { get => x_Pos; set => x_Pos = value; }
        public int Y_Pos { get => y_Pos; set => y_Pos = value; }
       
    }
}
