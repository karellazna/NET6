using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    internal class Adresa
    {

        public string Ulice { get; set; } = "";
        public string Mesto { get; set; } = "";
        public string Zeme { get; set; } = "";
        public int Cislo_Popisne { get; set; } = 00000;

        public override string ToString()
        {
            return $"{Ulice},{Mesto},{Zeme}, {Cislo_Popisne}";
        }

    }
}
