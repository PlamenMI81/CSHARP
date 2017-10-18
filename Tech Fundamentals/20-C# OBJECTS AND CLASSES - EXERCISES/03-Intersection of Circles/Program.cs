using System;
using System.Linq;

namespace _03_Intersection_of_Circles
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCircleArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircleArgs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Circle circleFirst = new Circle
            {
                Radius = firstCircleArgs[2],
                Center = new Point()
                {
                    X =firstCircleArgs[0],
                    Y=firstCircleArgs[1]
                }
            };

            Circle circleSecond = new Circle()
            {
                Radius = secondCircleArgs[2],
                Center = new Point()
                {
                    X=secondCircleArgs[0],
                    Y=secondCircleArgs[1]
                }
            };

            var isIntersect=IsIntersect(circleFirst.Radius,circleFirst.Center.X,circleFirst.Center.Y,circleSecond.Radius,circleSecond.Center.X,circleSecond.Center.Y);
            Console.WriteLine(isIntersect ? "Yes" : "No");
        }

        private static bool IsIntersect(int circleFirstRadius, int centerX1, int centerY1, int circleSecondRadius, int centerX2, int centerY2)
        {
            var distance= Math.Sqrt(Math.Pow((centerX1 - centerX2), 2) + Math.Pow((centerY1 - centerY2), 2));
            if (distance <= circleFirstRadius + circleSecondRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Circle
    {
        public int Radius { get; set; }
        public Point Center =new Point();
    }


}
