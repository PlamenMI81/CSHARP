using System;

namespace problem2
{ //Световен рекорд по плуване
    internal class Program
    {
        private static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double metersSwim = double.Parse(Console.ReadLine());
            double timeFor1m = double.Parse(Console.ReadLine());
            double timeAllMeters = metersSwim * timeFor1m;
            double delay = (int) metersSwim / 15 * 12.5;
            double allTime = timeAllMeters + delay;
            if (recordInSec <= allTime)
                Console.WriteLine($"No, he failed! He was {allTime - recordInSec:f2} seconds slower.");
            else if (recordInSec > allTime)
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:f2} seconds.");
        }
    }
}