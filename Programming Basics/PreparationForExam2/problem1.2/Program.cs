using System;

namespace problem1._2
{ //Distance
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstKmPerH = int.Parse(Console.ReadLine());
            int FirstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double firstKm = firstKmPerH * (FirstTime / 60.0);
            double secondKmPerH = firstKmPerH + firstKmPerH * 0.1;
            double secondKm = secondKmPerH * (secondTime / 60.0);
            double thirdKmPerH = secondKmPerH - secondKmPerH * 0.05;
            double thirdKm = thirdKmPerH * (thirdTime / 60.0);
            double allKm = firstKm + secondKm + thirdKm;
            Console.WriteLine($"{allKm:f2}");
        }
    }
}