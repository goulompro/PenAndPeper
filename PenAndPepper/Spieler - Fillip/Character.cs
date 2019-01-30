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
	public class Character
	{
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private float lifepoints;
		public float Lifepoints
		{
			get { return lifepoints; }
			set { lifepoints = value; }
		}
		private int strength;
		public int Strength
		{
			get { return strength; }
			set { strength = value; }
		}
		private int endurance;
		public int Endurance
		{
			get { return endurance; }
			set { endurance = value; }
		}
		private int dexterity;
		public int Dexterity
		{
			get { return dexterity; }
			set { dexterity = value; }
		}
		private int intelligent;
		public int Intelligent
		{
			get { return intelligent; }
			set { intelligent = value; }
		}
		private int charisma;
		public int Charisma
		{
			get { return charisma; }
			set { charisma = value; }
		}
		private int level;
		public int Level
		{
			get { return level; }
			set { level = value; }
		}
		private double nededexprience;
		public double Nededexprience
		{
			get { return nededexprience; }
			set { nededexprience = value; }
		}
		private int role;
		public int Role
		{
			get { return role; }
			set { role = value; }
		}
		private double experience;
		public double Experience
		{
			get { return experience; }
			set { experience = value; }
		}
		private bool gender;
		public bool Gender
		{
			get { return gender; }
			set { gender = value; }
		}
		private int item;
		public int Item
		{
			get { return item; }
			set { item = value; }
		}
	}
}
