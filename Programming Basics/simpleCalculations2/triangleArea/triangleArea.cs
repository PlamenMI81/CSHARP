using System;

namespace triangleArea
{
    class triangleArea
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = side * height / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}