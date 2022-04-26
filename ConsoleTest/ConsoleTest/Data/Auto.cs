using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    internal class Auto
    {
        public string SPZ { get; set; }
        public string Barva { get; set; }
        public double NajeteKM { get; set; }
        public string Znacka { get; set; }

        public Auto()
        {

        }

        public Auto(string spz, string barva, double najeteKM, string znacka)
        {
            SPZ = spz;
            Barva = barva;
            NajeteKM = najeteKM;
            Znacka = Znacka;
        }

        public static string overitKradeneAuto()
        { 
            //JAK ACCESNU TU PROMENOU SPZ ? 
            return "Je kradene";
        }

    }
}
