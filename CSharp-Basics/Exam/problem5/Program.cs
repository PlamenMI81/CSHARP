using System;

namespace problem5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 2 * n + 1;
            int width = 2 * n + 3;
            int leftRightDot = 0;
            int middleDots = n;

            for (int i = 0; i < n - 1; i++)
            {
                leftRightDot = i;
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', leftRightDot), new string('.', middleDots));
                middleDots--;
            }
            leftRightDot++;
            Console.WriteLine("{0}*****{0}", new string('.', leftRightDot));
            Console.WriteLine("{0}", new string('*', width));
            Console.WriteLine("{0}*****{0}", new string('.', leftRightDot));
            leftRightDot--;
            middleDots++;
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', leftRightDot), new string('.', middleDots));
                leftRightDot--;
                middleDots++;
            }
        }
    }
}