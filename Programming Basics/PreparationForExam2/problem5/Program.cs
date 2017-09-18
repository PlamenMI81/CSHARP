using System;

namespace problem5
{ //Christmas Hat
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int height = 2 * n + 5;
            int leftRightDots = (width - 3) / 2;
            Console.WriteLine("{0}/|\\{0}", new string('.', leftRightDots));
            Console.WriteLine("{0}\\|/{0}", new string('.', leftRightDots));
            for (int i = 0; i < 2 * n; i++)
            {
                int minusSign = i;
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', leftRightDots), new string('-', minusSign));
                leftRightDots--;
            }
            Console.WriteLine("{0}", new string('*', width));
            for (int i = 1; i <= 2 * n; i++)
                Console.Write("*.");
            Console.WriteLine("*");
            Console.WriteLine("{0}", new string('*', width));
        }
    }
}