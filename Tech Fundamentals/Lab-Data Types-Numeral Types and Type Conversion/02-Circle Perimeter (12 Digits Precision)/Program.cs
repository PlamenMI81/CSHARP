using System;

namespace _02_Circle_Perimeter__12_Digits_Precision_
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double result = 2 * Math.PI * radius;
            Console.WriteLine($"{result:f12}");
        }
    }
}