using System;

namespace problem2
{ //Transport Price
    internal class Program
    {
        private static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine().ToLower();
            double price = 0;
            if (km < 20)
            {
                double startPrice = 0.70;
                if (dayOrNight == "day")
                    price = startPrice + km * 0.79;
                else
                    price = startPrice + km * 0.90;
            }
            else if (km >= 20 && km < 100)
            {
                price = km * 0.09;
            }
            else if (km >= 100)
            {
                price = km * 0.06;
            }
            Console.WriteLine($"{price}");
        }
    }
}