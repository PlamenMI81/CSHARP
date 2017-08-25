using System;

namespace problem5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int spacesLeftRight = n;
            int hash = width - spacesLeftRight * 2;
            for (int i = 1; i <= n / 2; i++)
            {
                Console.WriteLine("{0}{1}{0}",
                    new string('.', spacesLeftRight), new string('#', hash));
                spacesLeftRight++;
                hash -= 2;
            }
            int middleDots = hash - 2;
            for (int i = 1; i <= n / 2 + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}",
                    new string('.', spacesLeftRight), new string('.', middleDots));
                spacesLeftRight++;
                middleDots -= 2;
            }
            spacesLeftRight--;
            int middleHash = width - spacesLeftRight * 2;
            Console.WriteLine("{0}{1}{0}",
                new string('.', spacesLeftRight), new string('#', middleHash));
            spacesLeftRight -= 2;
            middleHash += 4;
            for (int i = 1; i <= n / 2; i++)
                Console.WriteLine("{0}{1}{0}",
                    new string('.', spacesLeftRight), new string('#', middleHash));
            int spacesLeftRightdance = (width - 10) / 2;
            string dance = "D^A^N^C^E^";
            Console.WriteLine("{0}{1}{0}",
                new string('.', spacesLeftRightdance), dance);
            for (int i = 1; i <= n / 2 + 1; i++)
                Console.WriteLine("{0}{1}{0}",
                    new string('.', spacesLeftRight), new string('#', middleHash));
        }
    }
}