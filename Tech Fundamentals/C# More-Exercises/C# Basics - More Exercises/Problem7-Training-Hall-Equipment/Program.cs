using System;

namespace Problem7_Training_Hall_Equipment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int numOfItems = int.Parse(Console.ReadLine());
            string itemName = null;
            decimal itemPrice = 0.0m;
            int itemCount = 0;
            decimal subtotal = 0.0m;
            for (int i = 1; i <= numOfItems; i++)
            {
                itemName = Console.ReadLine();
                itemPrice = decimal.Parse(Console.ReadLine());
                itemCount = int.Parse(Console.ReadLine());
                if (itemCount > 1)
                    itemName = itemName + "s";
                Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                subtotal = subtotal + itemPrice * itemCount;
            }
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            Console.WriteLine(subtotal <= budget
                ? $"Money left: ${budget - subtotal:f2}"
                : $"Not enough. We need ${Math.Abs(budget - subtotal)} more.");
        }
    }
}