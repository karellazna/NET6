using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    public static class CarManagment
    {
        public static List<string> StolenCars = new List<string>();
        public static bool IsFileLoaded = false;


        public static bool OverSPZ (string spz)
        {

            if (!IsFileLoaded)
            {
                Console.WriteLine("Neco se nezdarilo");
            }
            foreach(string s in StolenCars)
            {
                if (spz == s)
                    return true;
                
            }
            return false;
            
        }

        public static void LoadStolenCars(string file)
        {
            string[] lines = File.ReadAllLines(file);

            foreach(string line in lines)
            {
                StolenCars.Add(line);
            }
            IsFileLoaded = true;

        }

    }
}
