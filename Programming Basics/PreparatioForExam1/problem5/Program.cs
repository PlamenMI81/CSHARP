using System;

namespace problem5
{ //Axe
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int leftDash = 3 * n;
            int rightDash = width - leftDash - 2;
            int middledash = 0;
            for (int i = 0; i < n; i++)
            {
                middledash = i;
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDash), new string('-', middledash), new string('-', rightDash));
                rightDash -= 1;
            }
            int middlePartHeight = n / 2;
            int leftStar = leftDash;
            for (int i = 1; i <= middlePartHeight; i++)
                Console.WriteLine("{0}*{1}*{1}", new string('*', leftStar), new string('-', middledash));
            int downPartHeight = n / 2;
            leftDash = leftStar;
            rightDash = middledash;
            for (int i = 1; i <= downPartHeight; i++)
                if (i == downPartHeight)
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('-', leftDash), new string('*', middledash), new string('-', rightDash));
                }
                else
                {
                    Console.WriteLine("{0}*{1}*{2}",
                        new string('-', leftDash), new string('-', middledash), new string('-', rightDash));
                    leftDash -= 1;
                    middledash += 2;
                    rightDash -= 1;
                }
        }
    }
}