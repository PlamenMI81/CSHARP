using System;
using System.Linq;

namespace _07_Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine().Split().ToArray();
            var quantities= Console.ReadLine().Split().ToArray();
            var prices= Console.ReadLine().Split().ToArray();

            string command = Console.ReadLine();

            while (command !="done")
            {
                var productCurrIndex=Array.IndexOf(products, command);
                Console.Write($"{command} costs: {prices[productCurrIndex]}; ");
                Console.WriteLine($"Available quantity: {quantities[productCurrIndex]}");
                command = Console.ReadLine();
            }
        }
    }
}
