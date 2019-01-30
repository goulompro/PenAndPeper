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
    class dialog
    {
        private string dialog_sentence;
        private string assigned_character;
        private string type;
        private string answer_type;

		Debug debug = new Debug();

        public dialog()
        {
 
        }

        public dialog(string dialog_sentence, string assigned_character, string type, string answer_type)
        {
            this.Dialog_sentence = dialog_sentence;
            this.Assigned_character = assigned_character;
            this.Type = type;
            this.Answer_type = answer_type;
        }

        public string Dialog_sentence { get => dialog_sentence; set => dialog_sentence = value; }
        public string Assigned_character { get => assigned_character; set => assigned_character = value; }
        public string Type { get => type; set => type = value; }
        public string Answer_type { get => answer_type; set => answer_type = value; }

        public void save_data_in_csv(string file_path)
        {
            TextWriter writer = new StreamWriter(file_path);
            var csv = new CsvWriter(writer);

            csv.WriteHeader<dialog>();
            csv.NextRecord();
            
            var records = new dialog { Dialog_sentence = this.dialog_sentence, Assigned_character = this.assigned_character, Type = this.type, answer_type = this.type};
            csv.WriteRecord(records);
            csv.NextRecord();
            writer.Close();
        }

        public List<dialog> get_saved_data(string file_path)
        {
            if (File.Exists(file_path))
            {
                TextReader reader = new StreamReader(file_path,Encoding.Default);
                var csv = new CsvReader(reader);

                //CsvHelper Konfiguration
                csv.Configuration.Delimiter = ";";
                csv.Configuration.Encoding = Encoding.Default;
                csv.Configuration.HasHeaderRecord = false;
                
                var records = csv.GetRecords<dialog>();
                return records.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}
