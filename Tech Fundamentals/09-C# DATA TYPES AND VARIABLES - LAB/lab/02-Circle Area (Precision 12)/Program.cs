using System;

namespace _02_Circle_Area__Precision_12_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double r =double.Parse(Console.ReadLine());
            double areaCircle = Math.PI * r * r;
            Console.WriteLine($"{areaCircle:f12}");
        }
    }
}