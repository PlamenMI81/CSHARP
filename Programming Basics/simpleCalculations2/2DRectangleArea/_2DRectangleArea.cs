using System;

namespace _2DRectangleArea
{
    class _2DRectangleArea
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double sideX = Math.Abs(x2-x1);
            double sideY = Math.Abs(y2-y1);

            double area = sideX * sideY;
            double perimeter = 2 * (sideX + sideY);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);

        }
    }
}
