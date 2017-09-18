using System;

namespace Triangle
{
    internal class Triangle
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 4 * n + 1;
            int atSignRowPositin = n / 2 + 1;
            Console.WriteLine("{0}", new string('#', width));
            int leftRightDots = 0;
            int middleSpace = 1;
            int leftRightHashtag;
            for (int i = 1; i <= n; i++)
            {
                leftRightDots = i;
                leftRightHashtag = (width - leftRightDots * 2 - middleSpace) / 2;
                if (i != atSignRowPositin)
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        new string('.', leftRightDots), new string('#', leftRightHashtag),
                        new string(' ', middleSpace));
                else
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}",
                        new string('.', leftRightDots), new string('#', leftRightHashtag),
                        new string(' ', (middleSpace - 3) / 2));
                middleSpace += 2;
            }
            int middleHashtag = middleSpace - 2;
            leftRightDots += 1;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', leftRightDots), new string('#', middleHashtag));
                leftRightDots += 1;
                middleHashtag -= 2;
            }
        }
    }
}