using System;

namespace rocket
{
    internal class rocket
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int leftRightDots = (width - 2) / 2;
            int emptySpace = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', leftRightDots), new string(' ', emptySpace));
                leftRightDots--;
                emptySpace += 2;
            }
            leftRightDots = n / 2;
            int slash = width - leftRightDots * 2 - 2;
            Console.WriteLine("{0}{1}{0}", new string('.', leftRightDots), new string('*', slash + 2));
            for (int i = 1; i <= n * 2; i++)
                Console.WriteLine("{0}|{1}|{0}", new string('.', leftRightDots), new string('\\', slash));
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}/{1}\\{0}", new string('.', leftRightDots), new string('*', slash));
                leftRightDots--;
                slash += 2;
            }
        }
    }
}