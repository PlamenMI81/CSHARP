using System;

namespace Diamond2
{
    internal class Diamond2
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //4 to 32
            int widthRow = 5 * n;
            int h = 3 * n + 2;
            int leftRightDots = n;
            int star = widthRow - leftRightDots * 2;
            Console.WriteLine("{0}{1}{0}", new string('.', leftRightDots), new string('*', star));
            for (int i = 1; i <= n - 1; i++)
            {
                leftRightDots--;
                int middleDots = widthRow - 2 * leftRightDots - 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftRightDots), new string('.', middleDots));
            }
            Console.WriteLine(new string('*', widthRow));
            int downPart = h - (n + 1);
            for (int i = 1; i <= downPart; i++)
            {
                char symbol = '.';
                if (i == downPart)
                    symbol = '*';
                leftRightDots = i;
                int middleDots = widthRow - leftRightDots * 2 - 2;
                Console.WriteLine("{0}*{1}*{0}", new string('.', leftRightDots), new string(symbol, middleDots));
            }
        }
    }
}