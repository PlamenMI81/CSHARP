using System;

namespace _03_Exact_Product_of_Real_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal product = 1m;
            decimal number = 0.0m;
            for (int i = 1; i <= n; i++)
            {
                number = decimal.Parse(Console.ReadLine());
                product = product * number;
            }
            Console.WriteLine(product);
        }
    }
}