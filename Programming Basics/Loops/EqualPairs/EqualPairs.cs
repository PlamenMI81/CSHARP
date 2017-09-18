using System;

namespace EqualPairs
{
    class EqualPairs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1;
            int num2;
            double pairSum = 0.0;
            double lastSum = 0.0;
            double diff = 0.0;
            double maxDiff = 0.0;
            for (int i = 1; i <= n; i++)
            {

                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());
                pairSum = num1 + num2;
                if (i > 1)
                {
                    diff = Math.Abs(pairSum - lastSum);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                }
                lastSum = pairSum;
            }
            if (maxDiff==0)
            {
                Console.WriteLine("Yes, value=" + pairSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff=" + maxDiff);
            }
            
        }
    }
}

