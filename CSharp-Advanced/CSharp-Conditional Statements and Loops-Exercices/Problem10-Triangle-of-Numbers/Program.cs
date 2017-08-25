using System;

namespace Problem10_Triangle_of_Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write($"{i} ");
                Console.WriteLine();
            }
        }
    }
}