using System;

namespace _06_Calculate_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangle =double.Parse(Console.ReadLine());
            double heightTriangle =double.Parse(Console.ReadLine());
            double area=CalculateTriangleArea(baseTriangle, heightTriangle);
            Console.WriteLine(area);
        }

        private static double CalculateTriangleArea(double baseT, double height)
        {
            return (baseT*height/2);
        }
    }
}
