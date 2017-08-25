using System;

namespace fox
{
    internal class fox
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 3;
            int star = 1;
            int tire = width - 2 * star - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('*', i), new string('-', tire));
                tire -= 2;
            }
            int leftRightStar = n / 2;
            int middleStar = width - leftRightStar * 2 - 4;
            int middlePartHeight = n / 3;
            for (int i = 1; i <= middlePartHeight; i++)
            {
                Console.WriteLine("|{0}\\{1}/{0}|", new string('*', leftRightStar), new string('*', middleStar));
                leftRightStar++;
                middleStar -= 2;
            }
            star = 1;
            star = width - 2 * star - 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{0}", new string('-', i), new string('*', star));
                star -= 2;
            }
        }
    }
}