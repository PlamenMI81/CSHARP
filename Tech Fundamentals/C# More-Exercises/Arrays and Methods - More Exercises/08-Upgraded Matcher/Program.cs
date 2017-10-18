using System;
using System.Linq;

namespace _08_Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantities = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var prices = Console.ReadLine().Split().Select(double.Parse).ToArray();

            string command = Console.ReadLine();

            while (command != "done")
            {
                var commandArgs = command.Split();
                var currProduct = commandArgs[0];
                var orderedQuantity = long.Parse(commandArgs[1]);

                var productCurrIndex = Array.IndexOf(products, currProduct);

                if (productCurrIndex>quantities.Length-1)
                {
                    Console.WriteLine($"We do not have enough {currProduct}");
                    command = Console.ReadLine();
                    continue;
                }

                if (orderedQuantity>quantities[productCurrIndex])
                {
                    Console.WriteLine($"We do not have enough {currProduct}");
                }
                else
                {
                    Console.WriteLine($"{currProduct} x {orderedQuantity} costs {prices[productCurrIndex] * orderedQuantity:f2} ");

                    quantities[productCurrIndex] -= orderedQuantity;
                }

                command = Console.ReadLine();
            }
        }
    }
}
