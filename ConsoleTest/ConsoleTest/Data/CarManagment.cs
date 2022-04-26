using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    public static class CarManagment
    {

        public static void OverSPZ (string spz)
        {
            if(spz == "3U2-6666")
            {
                Console.WriteLine("Neni kradeno");
            } else
            {
                Console.WriteLine("Je kradeno");
            }
        }

    }
}
