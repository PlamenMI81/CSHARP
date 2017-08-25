using System;

namespace Problem4_Hotel
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            int studioFreeNight = 0;
            decimal studioPrice = 0.0m, doublePrice = 0.0m, suitePrice = 0.0m;
            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50.0m;
                    doublePrice = 65.0m;
                    suitePrice = 75.0m;
                    if (nights > 7)
                        studioPrice *= 0.95m;
                    break;
                case "June":
                case "September":
                    studioPrice = 60.0m;
                    doublePrice = 72.0m;
                    suitePrice = 82.0m;
                    if (nights > 14)
                        doublePrice *= 0.90m;
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68.0m;
                    doublePrice = 77.0m;
                    suitePrice = 89.0m;
                    if (nights > 14)
                        suitePrice *= 0.85m;
                    break;
            }
            if (nights > 7 && (month == "September" || month == "October"))
                studioFreeNight = 1;
            studioPrice = studioPrice * (nights - studioFreeNight);
            doublePrice = doublePrice * nights;
            suitePrice = suitePrice * nights;
            Console.WriteLine($"Studio: {studioPrice:f2} lv.\n" +
                              $"Double: {doublePrice:f2} lv.\n" +
                              $"Suite: {suitePrice:f2} lv.");
        }
    }
}