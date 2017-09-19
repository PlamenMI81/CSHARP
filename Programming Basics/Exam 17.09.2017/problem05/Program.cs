using System;

namespace problem05
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int leftRightDots = (width - 1) / 2;
            Console.WriteLine("{0}x{0}", new string('.', leftRightDots));
            leftRightDots--;
            Console.WriteLine("{0}/x\\{0}", new string('.', leftRightDots));
            Console.WriteLine("{0}x|x{0}", new string('.', leftRightDots));
            leftRightDots = (width - 1 - n * 2) / 2;
            int theXSign = n;
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', leftRightDots), new string('x', theXSign));
                leftRightDots--;
                theXSign++;
            }
            leftRightDots += 2;
            theXSign -= 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', leftRightDots), new string('x', theXSign));
                leftRightDots++;
                theXSign--;
            }
            leftRightDots = (width - 3) / 2;
            Console.WriteLine("{0}/x\\{0}", new string('.', leftRightDots));
            Console.WriteLine("{0}\\x/{0}", new string('.', leftRightDots));
            leftRightDots = (width - 1 - n * 2) / 2;
            theXSign = n;
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', leftRightDots), new string('x', theXSign));
                leftRightDots--;
                theXSign++;
            }
            leftRightDots += 2;
            theXSign -= 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}|{1}{0}", new string('.', leftRightDots), new string('x', theXSign));
                leftRightDots++;
                theXSign--;
            }
            leftRightDots = (width - 3) / 2;
            Console.WriteLine("{0}x|x{0}", new string('.', leftRightDots));
            Console.WriteLine("{0}\\x/{0}", new string('.', leftRightDots));
            leftRightDots++;
            Console.WriteLine("{0}x{0}", new string('.', leftRightDots));
        }
    }
}