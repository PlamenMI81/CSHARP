using System;

namespace Problem2_Vapor_Store
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            decimal moneyBalance = decimal.Parse(Console.ReadLine());
            string game = string.Empty;
            decimal price = 0.0m;
            decimal sumSpent = 0.0m;

            for (int i = 1;; i++)
            {
                game = Console.ReadLine();
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
                    default: break;
                }
            }
        }
    }
}