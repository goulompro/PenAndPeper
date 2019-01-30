using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
	public class Debug
	{
		private DateTime timeStamp;
		private string class_name;
		private string debug_function;
		private string debug_text;

		public Debug()
		{
		}

        public Debug(DateTime timeStamp, string class_name, string debug_function, string debug_text)
        {
            this.TimeStamp = timeStamp;
            this.Class_name = class_name;
            this.Debug_function = debug_function;
            this.Debug_text = debug_text;
        }

        List<Debug> debug_log = new List<Debug>();

        public DateTime TimeStamp { get => timeStamp; set => timeStamp = value; }
        public string Class_name { get => class_name; set => class_name = value; }
        public string Debug_function { get => debug_function; set => debug_function = value; }
        public string Debug_text { get => debug_text; set => debug_text = value; }


		public Debug(bool startBackGroundWorker)
		{
			InitializeComponent();

			InitializeBackgroundWorker();
		}

		private System.ComponentModel.BackgroundWorker backgroundWorker;
		public void InitializeComponent()
		{
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.WorkerReportsProgress = true;
			this.backgroundWorker.WorkerSupportsCancellation = true;
		}

		// Set up the BackgroundWorker object by 
		// attaching event handlers. 
		private void InitializeBackgroundWorker()
		{
			backgroundWorker.DoWork +=
				new DoWorkEventHandler(backgroundWorker_DoWork);
		}

		// This event handler is where the actual,
		// potentially time-consuming work is done.
		private void backgroundWorker_DoWork(object sender,
			DoWorkEventArgs e)
		{
			// Get the BackgroundWorker that raised this event.
			BackgroundWorker worker = sender as BackgroundWorker;

			// Assign the result of the computation
			// to the Result property of the DoWorkEventArgs
			// object. This is will be available to the 
			// RunWorkerCompleted eventhandler.
			writeLogs(worker, e);
		}

		/*
		 * Author: Christopher Wendholt
		 * 
		 */
		public void writeLogs(BackgroundWorker worker, DoWorkEventArgs e)
		{
			int delay = 1000;

			this.save_data_in_csv("logs.csv");
			Thread.Sleep(delay);
		}

        /*
         * CSV-Writer
         * 
         * Soll die Objekte der Klasse Debug in einer CSV-datei speicher
         * 
         * Übergabeparameter:
         * string file_path -> Pfad zu Datei
         * 
         */
        public void save_data_in_csv(string file_path)
        {
            TextWriter writer = new StreamWriter(file_path);
            var csv = new CsvWriter(writer);

            csv.WriteHeader<Debug>();
            csv.NextRecord();

            csv.Configuration.Delimiter = ";";

            csv.WriteRecords(debug_log);
            csv.NextRecord();

            writer.Close();
        }

        /*
         * #if DEBUG
         *          debug.write(this, MethodBase.GetCurrentMethod(), "Verabschiedungen werden eingelesen!");
         * #endif
         */
        public void write(Object _class, Object _debug_function, string _debug_text)
        {
            Debug debug = new Debug(DateTime.Now, _class.ToString(), _debug_function.ToString(), _debug_text);
            debug_log.Add(debug);
            Console.WriteLine(DateTime.Now.ToString() + " " +_class +" "+ _debug_function + ": " + _debug_text);
        }

        public void write(Object _class, Object _debug_function, int _debug_int)
        {
            this.Class_name = _class.ToString();
            this.Debug_function = _debug_function.ToString();
            this.Debug_text = _debug_int.ToString();
            Console.WriteLine(DateTime.Now.ToString() + " " + _class + " " + _debug_function + ": " + _debug_int);
        }

        public void write(Object _class, Object _debug_function, object _debug_object)
        {
            this.Class_name = _class.ToString();
            this.Debug_function = _debug_function.ToString();
            this.Debug_text = _debug_object.ToString();

            save_data_in_csv("log.csv");

            Console.WriteLine(DateTime.Now.ToString() + " " + _class + " " + _debug_function + ": " + _debug_object);
        }

        public void write(Object _class, Object _debug_function, float _debug_float)
        {
            this.Class_name = _class.ToString();
            this.Debug_function = _debug_function.ToString();
            this.Debug_text = _debug_float.ToString();

            save_data_in_csv("log.csv");

            Console.WriteLine(DateTime.Now.ToString() + " " + _class + " " + _debug_function + ": " + _debug_float);
        }
        /*
         * debug.write_line(dl.Dialog_sentence + " ; " + dl.Assigned_character + " ; " + dl.Answer_type + " ; " + dl.Type);
         */
        public void write_line(string _debug_text)
        {
            Console.WriteLine(DateTime.Now.ToString() +'\t'+ _debug_text + '\n');
        }

    }
}
