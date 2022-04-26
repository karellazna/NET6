using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Model
{
    internal class Point2D
    {
        public Point2D(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        public Point2D()
        {

        }
        public double X { get; set; }
        public double Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"x: {X} y: {Y}");
        }

        public override string ToString()
        {
            return $"x: {X} y: {Y}";
        }

        public double CalculateArea()
        {
            return Math.Abs(X) * Math.Abs(Y);
        }

        public Quadrant GetQuadrant()
        {
            if (X == 0 && Y == 0)
                return Quadrant.Origin;

            if (X >= 0 && Y >= 0)
                return Quadrant.Quadrant1;
            else if (X < 0 && Y >= 0)
                return Quadrant.Quadrant2;
            else if (X < 0 && Y < 0)
                return Quadrant.Quadrant3;
            else if (X >= 0 && Y < 0)
                return Quadrant.Quadrant4;

            return Quadrant.Error;
        }
    }
}
