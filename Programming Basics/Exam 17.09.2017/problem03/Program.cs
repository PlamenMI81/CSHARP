using System;

namespace problem03
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string termOfContract = Console.ReadLine().ToLower();
            string typeOfContract = Console.ReadLine().ToLower();
            string haveInternet = Console.ReadLine().ToLower();
            int monts = int.Parse(Console.ReadLine());
            decimal price = 0.0m;
            switch (typeOfContract)
            {
                case "small":
                    price = termOfContract == "one" ? 9.98m : 8.58m;
                    break;
                case "middle":
                    price = termOfContract == "one" ? 18.99m : 17.09m;
                    break;
                case "large":
                    price = termOfContract == "one" ? 25.98m : 23.59m;
                    break;
                case "extralarge":
                    price = termOfContract == "one" ? 35.99m : 31.79m;
                    break;
            }
            if (haveInternet == "yes")
                if (price > 30)
                    price += 3.85m;
                else if (price <= 10)
                    price += 5.50m;
                else
                    price += 4.35m;
            decimal totallPrice = price * monts;
            if (termOfContract == "two")
                totallPrice = totallPrice * 0.9625m;
            Console.WriteLine($"{totallPrice:f2} lv.");
        }
    }
}