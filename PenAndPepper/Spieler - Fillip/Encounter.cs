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

namespace PenAndPepper
{
	/*
	 * Author: Christopher Wendholt
	 */
	public class Encounter : Character
	{
		private City city;
		private string type;

		public Encounter(City city, string type)
		{
			this.city = city;
			this.type = type;
		}

		public City City { get => city; set => city = value; }
		public string Type { get => type; set => type = value; }
	}
}
