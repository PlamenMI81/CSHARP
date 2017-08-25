using System;

namespace softUniLogo
{
    internal class softUniLogo
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 12 * n - 5;
            int dots = (width - 1) / 2;
            int hashTag = 1;
            for (int i = 1; i <= 2 * n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', dots), new string('#', hashTag));
                dots -= 3;
                hashTag += 6;
            }
            dots = 3;
            hashTag = width - 6;
            for (int i = 1; i <= n - 2; i++)
            {
                Console.WriteLine("|{0}{1}{2}", new string('.', dots - 1), new string('#', hashTag),
                    new string('.', dots));
                dots += 3;
                hashTag -= 6;
            }
            int heightDownPart = n;
            for (int i = 1; i <= heightDownPart; i++)
            {
                char symbol = '|';
                if (i == heightDownPart)
                    symbol = '@';
                Console.WriteLine("{0}{1}{2}{3}", symbol, new string('.', dots - 1), new string('#', hashTag),
                    new string('.', dots));
            }
        }
    }
}