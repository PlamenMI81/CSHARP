using System;

namespace problem01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            int aquarimVolume = lenght * width * height;
            double totallLitres = aquarimVolume * 0.001;
            double realLitres = totallLitres - totallLitres * (percent/100);
            Console.WriteLine($"{realLitres:f3}");
        }
    }
}