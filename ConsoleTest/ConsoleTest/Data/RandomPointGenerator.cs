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
        private static int Counter;

        public static int GetCount()
        {
            return Counter;
        }
        public static Point2D GetRandomPoint()
        {
            Counter++;

            Random random = new Random();
            double x = random.Next(int.MinValue, int.MaxValue);
            double y = random.Next(int.MinValue, int.MaxValue);

            Point2D result = new Point2D(x, y);

            return result;
        }
    }
}
