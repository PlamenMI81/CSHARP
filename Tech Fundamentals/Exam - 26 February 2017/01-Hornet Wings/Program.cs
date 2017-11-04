using System;

namespace _01_Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {
            int wingFlaps =int.Parse(Console.ReadLine());
            double distance =double.Parse(Console.ReadLine()); // distance in meters for 1000 wing flaps
            int endurance =int.Parse(Console.ReadLine());

            var totallDistance = (wingFlaps / 1000) * distance;
            var time = wingFlaps / 100;
            var timeWithRest = wingFlaps / endurance * 5;
            var totalTime = time + timeWithRest;
            Console.WriteLine($"{totallDistance:f2} m.");
            Console.WriteLine($"{totalTime} s.");
        }
    }
}
