using System;

namespace Problem3_Miles_to_Kilometers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double miles = double.Parse(Console.ReadLine());
            double convertToKm = miles * 1.60934;
            Console.WriteLine($"{convertToKm:f2}");
        }
    }
}