using System;

namespace problem3
{ //Плодови коктейли
    internal class Program
    {
        private static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string sizeCocktail = Console.ReadLine().ToLower();
            int numOfCocktails = int.Parse(Console.ReadLine());
            decimal priceCocktail = 0;
            if (fruit == "watermelon" && sizeCocktail == "small")
                priceCocktail = 2 * 56m;
            else if (fruit == "watermelon" && sizeCocktail == "big")
                priceCocktail = 5 * 28.70m;
            else if (fruit == "mango" && sizeCocktail == "small")
                priceCocktail = 2 * 36.66m;
            else if (fruit == "mango" && sizeCocktail == "big")
                priceCocktail = 5 * 19.60m;
            else if (fruit == "pineapple" && sizeCocktail == "small")
                priceCocktail = 2 * 42.10m;
            else if (fruit == "pineapple" && sizeCocktail == "big")
                priceCocktail = 5 * 24.80m;
            else if (fruit == "raspberry" && sizeCocktail == "small")
                priceCocktail = 2 * 20m;
            else if (fruit == "raspberry" && sizeCocktail == "big")
                priceCocktail = 5 * 15.20m;
            decimal allCocktailPrice = priceCocktail * numOfCocktails;
            if (allCocktailPrice >= 400 && allCocktailPrice <= 1000)
                allCocktailPrice = allCocktailPrice - allCocktailPrice * 0.15m;
            else if (allCocktailPrice > 1000)
                allCocktailPrice = allCocktailPrice - allCocktailPrice * 0.50m;
            Console.WriteLine($"{allCocktailPrice:f2} lv.");
        }
    }
}