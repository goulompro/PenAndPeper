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
    public class Enemy : Character
    {
        private bool spawnforrest;
        private bool spawnplains;
        private bool spawnmountain;
        private bool spawnlake;

        public bool Spawnforrest { get => spawnforrest; set => spawnforrest = value; }
        public bool Spawnplains { get => spawnplains; set => spawnplains = value; }
        public bool Spawnmountain { get => spawnmountain; set => spawnmountain = value; }
        public bool Spawnlake { get => spawnlake; set => spawnlake = value; }
    }
}
