using ConsoleTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Data
{
    internal class Math2D
    {
        public static Point2D MaxAreaFromOrigin(Point2D point1, Point2D point2)
        {
            if (point1.CalculateArea() >= point2.CalculateArea())
                return point1;
            else
                return point2;
        }


    }
}
