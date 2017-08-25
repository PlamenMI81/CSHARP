using System;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int counterP1 = 0;
            int counterP2 = 0;
            int counterP3 = 0;
            int counterP4 = 0;
            int counterP5 = 0;
            for (int i = 1; i <= n; i++)
            {
                number=int.Parse(Console.ReadLine());
                if (number<200)
                {
                    counterP1++;
                }else if (number >=200 && number<=399)
                {
                    counterP2++;
                }
                else if (number >= 400 && number <= 599)
                {
                    counterP3++;
                }
                else if (number >= 600 && number <= 799)
                {
                    counterP4++;
                }
                else if (number >= 800)
                {
                    counterP5++;
                }
            }
            double p1 = ((double)counterP1 / n) * 100;
            double p2 = ((double)counterP2 / n) * 100;
            double p3 = ((double)counterP3 / n) * 100;
            double p4 = ((double)counterP4 / n) * 100;
            double p5 = ((double)counterP5 / n) * 100;
            
            Console.WriteLine($"{p1:f2}%\n{p2:f2}%\n{p3:f2}%\n{p4:f2}%\n{p5:f2}%");
        }
    }
}
