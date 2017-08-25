using System;

namespace Problem1_X
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middleSpace = n - 2;
            int leftSpace = 0;

            for (int i = 0; i < n / 2; i++)
            {
                leftSpace = i;
                Console.WriteLine("{0}x{1}x", new string(' ', leftSpace), new string(' ', middleSpace));
                middleSpace -= 2;
            }
            leftSpace++;
            Console.WriteLine("{0}x", new string(' ', leftSpace));
            leftSpace--;
            middleSpace = 1;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}x{1}x", new string(' ', leftSpace), new string(' ', middleSpace));
                leftSpace--;
                middleSpace += 2;
            }
        }
    }
}