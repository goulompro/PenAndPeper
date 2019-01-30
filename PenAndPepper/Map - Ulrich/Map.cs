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
    public class Map
    {
        private List<List<Field>> map2DArray = new List<List<Field>>();

        private List<City> cities = new List<City>();
        Debug debug = new Debug();

        public List<List<Field>> Map2DArray
        {
            get { return map2DArray; }
            set { map2DArray = value; }
        }
        private int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        private int widht;

        public int Widht
        {
            get { return widht; }
            set { widht = value; }
        }

		private int mapSeed;

		public int MapSeed
		{
			get { return mapSeed; }
			set { mapSeed = value; }
		}

		public Map(int w, int h)
        {
            widht = w;
            height = h;

			MapSeed = get_Random_Map_Seed();

            GenerateMap(h, w);
        }

		public Map(int w, int h, int _mapSeed)
		{
			widht = w;
			height = h;
			mapSeed = _mapSeed;

			GenerateMap(h, w);
		}


		int get_Random_Map_Seed()
		{
			Random random = new Random();

			int seed = random.Next(10000, 99999);

			FileStream fs = new FileStream(@"seed.txt", FileMode.Create);
			StreamWriter writer = new StreamWriter(fs);
			writer.Write(seed);
			writer.Close();

			return seed;
		}


		/*
		 * Author: Ulrich Steffen
		 */
		private Field FieldProbability(Random rnd)
        {
            Field field = new Field();
            Array values = Enum.GetValues(typeof(Field.FieldTyp));
            int randomvalue = rnd.Next(100);
            field.Incident = Field.FieldTyp.plains;
            if (randomvalue < 40 && randomvalue >= 0)
            {
                field.Incident = Field.FieldTyp.forrest;
            }
            else if (randomvalue < 50 && randomvalue >= 40)
            {
                field.Incident = Field.FieldTyp.mountain;
            }
            else if (randomvalue < 52 && randomvalue >= 50)
            {
                field.Incident = Field.FieldTyp.lake;
            }
            return field;
        }


		/* 
         * Author: Christopher Wendholt
         * 
         * Create cities on random generated cordinates
		 * 
		 * Transfer variables:
		 * int x	=> x-Cordinates
		 * int y	=> y-Cordinates
         */
		private void setCities(int x, int y)
        {
            int[] a = { x, y };
            City city = new City(x,y);

            cities.Add(city);

            List<Field> map1DArray = map2DArray[x];
            map1DArray[y].Incident = Field.FieldTyp.town;
            map2DArray[x] = map1DArray;
        }

        /*
         * Author: Christopher Wendholt
         * 
         * Saves the cities including their names and position in an .csv document
         */
        void save_Cities_Attributes()
        {
			City city = new City();
			city.save_data_in_csv("city.csv",cities);       
        }


		/*
		 * Author: Ulrich Steffen
		 */
		public void GenerateMap(int h, int w)
        {
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "GenerateMap gestartet");
#endif
			Random rnd = new Random();
			if (mapSeed != -1)
			{
				rnd = new Random(MapSeed);
			}

			for (int i = 0; i < h; i++)
            {
                List<Field> map1DArray = new List<Field>();
                for (int j = 0; j < w; j++)
                {
                    Field field = new Field();
                    field = FieldProbability(rnd);
                    map1DArray.Add(field);
                }
                map2DArray.Add(map1DArray);
            }
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "GenerateMap abgeschlossen");
#endif
			//Create Towns and save them for later use in Town.cs
			generateCities(h, w);

            save_Cities_Attributes();
        }

		/*
		 * Author: Christopher Wendholt
		 * 
		 */
		private void generateCities(int h, int w)
        {
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Towns werden generiert");
#endif
			Random rnd = new Random(MapSeed);
			if (mapSeed != -1)
			{
				rnd = new Random(MapSeed);
			}

			for (int i = 0; i < ((h * w) / 100); i++)
            {
				setCities(rnd.Next(h), rnd.Next(w));
#if DEBUG
                foreach (City cs in cities)
                {
                    debug.write(this, MethodBase.GetCurrentMethod(), cs.Y_Pos + " y/" + "/x" + cs.X_Pos);
                }
#endif   
            }
#if DEBUG
            debug.write(this, MethodBase.GetCurrentMethod(), "Towns wurden generiert");
#endif
        }
		/*
		 * Author: Ulrich Steffen
		 */
		public void FieldTrueVisible(int x, int y)
        {
            List<Field> map1DArray;
            if (y > 0)
            {
                map1DArray = map2DArray[y - 1];
                map1DArray[x].IsVisible = true;
                map2DArray[y - 1] = map1DArray;
            }
            map1DArray = map2DArray[y];
            if (x > 0)
            {
                map1DArray[x - 1].IsVisible = true;
            }
            if (x < Widht - 1)
            {
                map1DArray[x + 1].IsVisible = true;
            }
            map2DArray[y] = map1DArray;
            if (y < Height - 1)
            {
                map1DArray = map2DArray[y + 1];
                map1DArray[x].IsVisible = true;
                map2DArray[y + 1] = map1DArray;
            }       
        }
    }
}
