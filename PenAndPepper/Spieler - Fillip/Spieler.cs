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

namespace PenAndPepper
{
    public class Spieler : Character 
    {
		private int xPos;

		private int yPos;

		public Spieler()
        {
        }

		public Spieler(int x, int y)
		{
			XPos = x;
			YPos = y;
		}

		public int XPos
		{
			get { return xPos; }
			set { xPos = value; }
		}

		public int YPos
		{
			get { return yPos; }
			set { yPos = value; }
		}


		#region CSVHelper
		public void save_data_in_csv(string file_path,Spieler spieler)
		{
			TextWriter writerPlayer = new StreamWriter(file_path);
			var csv = new CsvWriter(writerPlayer);

			csv.Configuration.Delimiter = ";";
			
			csv.WriteHeader<Spieler>();
			csv.NextRecord();
			csv.WriteRecord(spieler);
			csv.NextRecord();
			writerPlayer.Close();
		}

		public void save_data_in_csv(string file_path,List<Spieler> player)
        {
            TextWriter writer = new StreamWriter(file_path);
            var csv = new CsvWriter(writer);

            csv.Configuration.Delimiter = ";";

            csv.WriteHeader<Spieler>();
            csv.NextRecord();
            csv.WriteRecords(player);
            csv.NextRecord();
            writer.Close();
        }

        public List<Spieler> get_saved_Spieler(string file_path)
        {
            if (File.Exists(file_path))
            {
                TextReader reader = new StreamReader(file_path,Encoding.Default);
                var csv = new CsvReader(reader);

                //CsvHelper Konfiguration
                csv.Configuration.Delimiter = ";";
                csv.Configuration.Encoding = Encoding.Default;
                
                var records = csv.GetRecords<Spieler>();
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
