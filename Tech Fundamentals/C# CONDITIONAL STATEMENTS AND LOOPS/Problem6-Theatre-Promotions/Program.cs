using System;

namespace Problem6_Theatre_Promotions
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int ageOfPerson = int.Parse(Console.ReadLine());
            decimal price = 0.0m;
            if (ageOfPerson >= 0 && ageOfPerson <= 18)
                switch (dayType)
                {
                    case "weekday":
                        price = 12m;
                        break;
                    case "weekend":
                        price = 15m;
                        break;
                    case "holiday":
                        price = 5m;
                        break;
                }
            else if (ageOfPerson > 18 && ageOfPerson <= 64)
                switch (dayType)
                {
                    case "weekday":
                        price = 18m;
                        break;
                    case "weekend":
                        price = 20m;
                        break;
                    case "holiday":
                        price = 12m;
                        break;
                }
            else if (ageOfPerson > 64 && ageOfPerson <= 122)
                switch (dayType)
                {
                    case "weekday":
                        price = 12m;
                        break;
                    case "weekend":
                        price = 15m;
                        break;
                    case "holiday":
                        price = 10m;
                        break;
                }
            Console.WriteLine(price != 0 ? $"{price}$" : "Error!");
        }
    }
}