using System;

namespace Problem3_Megapixels
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double megapixel = width * height / 1000000.0;
            Console.WriteLine($"{width}x{height} => {Math.Round(megapixel,1)}MP");
        }
    }
}