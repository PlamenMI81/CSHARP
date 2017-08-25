using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem1
{//House Painting
    class Program
    {
        static void Main(string[] args)
        {
            double x =double.Parse(Console.ReadLine());
            double y =double.Parse(Console.ReadLine());
            double h =double.Parse(Console.ReadLine());

            double sideWall = x * y;
            double window = 1.5 * 1.5;
            double twoSide = sideWall * 2 - 2*window;
            double backWall = x * x;
            double entrance = 1.2 * 2;
            double allwalls = 2 * backWall - entrance;
            double wallsInGreen = allwalls + twoSide;
            double greenPaint = wallsInGreen / 3.4;

            double roofRectangles=2*(x*y);
            double roofTrinagle=2*(h*x/2);
            double wallsInRed = roofTrinagle + roofRectangles;
            double redPaint = wallsInRed / 4.3;
            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
        }
    }
}
