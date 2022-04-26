using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    public enum Quadranty
    {
        Quadrant_I,
        Quadrant_II,
        Quadrant_III,
        Quadrant_IV,
        Error
    }

    internal class Point2D
    {

        

        public double X { get; set; }
        public double Y { get; set; } 
        public void Print()
        {
            Console.WriteLine($"x: {X} y: {Y}");
        }

        public double VypocetObsahuZeSouradnic()
        {
            
            double vysledek = X * Y;

            Console.WriteLine($"Obsah je: {vysledek} metru ctverecnich");
            return vysledek;
        }

        public Quadranty ZjistiQuadrant()
        {
            if (X >= 0 && Y >= 0)
            {
                return Quadranty.Quadrant_I;
            } else if (X < 0 && Y >= 0)
            {
                return Quadranty.Quadrant_II;
            } else if (X < 0 && Y < 0)
            {
                return Quadranty.Quadrant_III;
            } else if (X >= 0 && Y < 0)
            {
                return Quadranty.Quadrant_IV;
            }
            else
            {
                return Quadranty.Error;

            }

        }

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point2D()
        {

        }


        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
}
