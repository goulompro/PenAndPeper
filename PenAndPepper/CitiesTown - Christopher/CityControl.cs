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

namespace PenAndPepper.CitiesTown
{
	/*
	 * Author Christopher Wendholt
	 * 
	 * Controls the background processes 
	 * 
	 * Functions:
	 * City get_City_by_Posititon -> returns the City by given cordinates
	 * City find_City_in_CSV_File -> returns the City found in CSV-File
	 */
	class CityControl
	{
		Debug debug = new Debug();

		List<City> cities = new List<City>();

		private City find_City_in_CSV_File(string filename, int x, int y)
		{
			City city = new City();

			cities = city.get_saved_data(filename);

			int i_Counter = 0;
			bool foundCity = new bool();
			do
			{
				if (cities[i_Counter].X_Pos == y && cities[i_Counter].Y_Pos == x)
				{
					city = cities[i_Counter];

					foundCity = true;
					i_Counter++;
				}
				else
				{
					foundCity = false;
					i_Counter++;
				}
			}
			while (foundCity != true);

			return city;
		}

		public City get_City_by_Posititon(int x, int y)
		{
			City city = new City();

			city = find_City_in_CSV_File("city.csv", x, y);

#if DEBUG
			debug.write(this, MethodBase.GetCurrentMethod(), "User ist in: " + city.Name + " bei (x/y): " + city.X_Pos + "/" + city.Y_Pos);
#endif

			return city;
		}
	}
}
