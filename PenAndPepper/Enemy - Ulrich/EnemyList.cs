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
    class EnemyList
    {
        List<Enemy> enemies = new List<Enemy>();

        public List<Enemy> Enemies { get => enemies; set => enemies = value; }

        public void Get_saved_Enemys(string file_path)
        {
            if (File.Exists(file_path))
            {
                TextReader reader = new StreamReader(file_path, Encoding.Default);
                var csv = new CsvReader(reader);

                //CsvHelper Konfiguration
                csv.Configuration.Delimiter = ";";
                csv.Configuration.Encoding = Encoding.Default;
                csv.Configuration.HasHeaderRecord = true;

                Enemies = csv.GetRecords<Enemy>().ToList();
            }
        }
    }
}
