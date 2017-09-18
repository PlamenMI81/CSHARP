using System;

namespace Problem2_Vapor_Store
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            decimal moneyBalance = decimal.Parse(Console.ReadLine());
            string game;
            decimal moneyInStart = moneyBalance;
            do
            {
                game = Console.ReadLine();
                if (game != "Game Time")
                {
                    decimal price;
                    switch (game)
                    {
                        case "OutFall 4":
                            price = 39.99m;
                            break;
                        case "CS: OG":
                            price = 15.99m;
                            break;
                        case "Zplinter Zell":
                            price = 19.99m;
                            break;
                        case "Honored 2":
                            price = 59.99m;
                            break;
                        case "RoverWatch":
                            price = 29.99m;
                            break;
                        case "RoverWatch Origins Edition":
                            price = 39.99m;
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            continue;
                    }
                    if (price > moneyBalance)
                    {
                        Console.WriteLine("Too Expensive");
                        continue;
                    }
                    if (moneyBalance <= 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                    Console.WriteLine($"Bought {game}");
                    moneyBalance = moneyBalance - price;
                }
            } while (game != "Game Time");
            Console.WriteLine(moneyBalance <= 0
                ? "Out of money!"
                : $"Total spent: ${moneyInStart - moneyBalance:f2}. Remaining: ${moneyBalance:f2}");
        }
    }
}