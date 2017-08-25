using System;

namespace Crown
{
    internal class Crown
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n - 1;
            int spacesFirstRow = (width - 3) / 2;
            int spaceSecondRow = (width - 5) / 2;
            Console.WriteLine("@{0}@{0}@", new string(' ', spacesFirstRow));
            Console.WriteLine("**{0}*{0}**", new string(' ', spaceSecondRow));
            int spaceInCycle = spaceSecondRow - 2;
            int midDots = 1;
            int i;
            for (i = 1; i < n / 2 - 1; i++)
            {
                Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                    new string('.', i), new string(' ', spaceInCycle), new string('.', midDots));
                spaceInCycle -= 2;
                midDots += 2;
            }
            Console.WriteLine("*{0}*{1}*{0}*",
                new string('.', i), new string('.', midDots));
            int midStars = (midDots - 1) / 2;
            Console.WriteLine("*{0}{1}.{1}{0}*", new string('.', i + 1), new string('*', midStars));
            for (int j = 1; j <= 2; j++)
                Console.WriteLine("{0}", new string('*', width));
        }
    }
}