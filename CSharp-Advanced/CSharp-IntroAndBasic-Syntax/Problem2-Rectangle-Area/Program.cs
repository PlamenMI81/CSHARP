using System;

namespace Problem2_Rectangle_Area
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:f2}");
        }
    }
}