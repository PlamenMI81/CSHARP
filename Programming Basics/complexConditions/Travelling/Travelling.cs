using System;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            string season =  Console.ReadLine();
            decimal priceForRent;
            if (budget<=100)
            {
                switch (season)
                {
                    case "summer":
                        priceForRent = budget * 0.30m;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Camp - {priceForRent:f2}");
                        break;
                    case "winter":
                        priceForRent = budget * 0.70m;
                        Console.WriteLine("Somewhere in Bulgaria");
                        Console.WriteLine($"Hotel - {priceForRent:f2}");

                        break;
                }
            }
            else if (budget>1000)
            {
                priceForRent = budget * 0.90m;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {priceForRent:f2}");
            }
            else
            {
                switch (season)
                {
                    case "summer":
                        priceForRent = budget * 0.40m;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Camp - {priceForRent:f2}");
                        break;
                    case "winter":
                        priceForRent = budget * 0.80m;
                        Console.WriteLine("Somewhere in Balkans");
                        Console.WriteLine($"Hotel - {priceForRent:f2}");
                        break;
                }
            }
        }
    }
}
