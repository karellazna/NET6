using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    internal class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; } 
        public void Print()
        {
            Console.WriteLine($"x: {X} y: {Y}");
        }

        public void VypocetObsahuZeSouradnic()
        {
            
            double vysledek = X * Y;

            Console.WriteLine($"Obsah je: {vysledek} metru ctverecnich");
        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {

        }

    }
}
