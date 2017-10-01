using System;

namespace _11_Convert_Speed_Units
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            uint distanceInMeters = uint.Parse(Console.ReadLine());
            byte hours = byte.Parse(Console.ReadLine());
            byte minutes = byte.Parse(Console.ReadLine());
            byte seconds = byte.Parse(Console.ReadLine());
            ushort timeToSeconds = (ushort) (hours * 3600 + minutes * 60 + seconds);
            float speedMetersPerSeconds = (float) distanceInMeters / timeToSeconds;
            float speedKmPerHour = (float) distanceInMeters / 1000 / ((float) timeToSeconds / 3600);
            float speedMilesPerHour = (float) distanceInMeters / 1000 / 1.609f / ((float) timeToSeconds / 3600);
            Console.WriteLine($"{speedMetersPerSeconds}");
            Console.WriteLine($"{speedKmPerHour}");
            Console.WriteLine($"{speedMilesPerHour}");
        }
    }
}