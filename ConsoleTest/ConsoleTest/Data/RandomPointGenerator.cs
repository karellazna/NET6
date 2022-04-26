using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    internal class RandomPointGenerator
    {
        public static Point2D GetRandomPoint()
        {
            Random random = new Random();

            double x = random.Next(int.MinValue, int.MaxValue);
            double y = random.Next(int.MaxValue, int.MaxValue);

            Point2D vysledek = new Point2D(x, y);
            return vysledek;
        }
    }
}
