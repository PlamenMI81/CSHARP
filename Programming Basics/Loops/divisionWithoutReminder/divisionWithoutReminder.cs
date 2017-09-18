using System;

namespace divisionWithoutReminder
{
    class divisionWithoutReminder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterP1 = 0;
            int counterP2 = 0;
            int counterP3 = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    counterP1++;
                }
                if (number % 3 == 0)
                {
                    counterP2++;
                }
                if (number % 4 == 0)
                {
                    counterP3++;
                }

            }
            double p1 = ((double) counterP1 / n) * 100;
            double p2 = ((double) counterP2 / n) * 100;
            double p3 = ((double) counterP3 / n) * 100;


            Console.WriteLine($"{p1:f2}%\n{p2:f2}%\n{p3:f2}%");
        }

    }
}