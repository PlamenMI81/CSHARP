using System;

namespace Paralelepiped
{
    internal class Paralelepiped
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 1;
            int tildeSign = n - 2;
            int rightDots = width - tildeSign - 2;
            Console.WriteLine("+{0}+{1}", new string('~', tildeSign), new string('.', rightDots));
            rightDots--;
            int leftDots = 0;
            for (int i = 0; i < n * 2 + 1; i++)
            {
                leftDots = i;
                Console.WriteLine("|{0}\\{1}\\{2}", new string('.', leftDots), new string('~', tildeSign),
                    new string('.', rightDots));
                rightDots--;
            }
            for (int i = 0; i < n * 2 + 1; i++)
            {
                leftDots = i;
                rightDots = width - leftDots - tildeSign - 3;
                Console.WriteLine("{0}\\{1}|{2}|", new string('.', leftDots), new string('.', rightDots),
                    new string('~', tildeSign));
            }
            leftDots++;
            Console.WriteLine("{0}+{1}+", new string('.', leftDots), new string('~', tildeSign));
        }
    }
}