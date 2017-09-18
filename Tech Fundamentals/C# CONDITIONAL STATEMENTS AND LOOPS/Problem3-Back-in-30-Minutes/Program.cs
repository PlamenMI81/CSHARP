using System;

namespace Problem3_Back_in_30_Minutes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int timeAfter = min + 30;
            if (timeAfter > 59)
            {
                hour++;
                timeAfter = timeAfter - 60;
            }
            if (hour > 23)
                hour = 0;
            Console.WriteLine($"{hour}:{timeAfter:00}");
        }
    }
}