using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    internal class Auto
    {
        private static string SPZ;
        private static string Barva;
        private static double NajeteKM;
        private static string Znacka;

        public static string GetSPZ()
        {
            return SPZ;
        }
        public static string GetBarva()
        {
            return Barva;
        }
        public static double GetNajeteKM()
        {
            return NajeteKM;
        }
        public static string GetZnacka()
        {
            return Znacka;
        }

    }
}
