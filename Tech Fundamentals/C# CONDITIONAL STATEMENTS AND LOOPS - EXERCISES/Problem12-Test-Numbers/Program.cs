using System;

namespace Problem12_Test_Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = n; i >= 1; i--)
            for (int j = 1; j <= m; j++)
            {
                int nMultM = i * j * 3;
                sum = sum + nMultM;
                count++;
                if (sum >= maxSumBoundary)
                    goto exitCycle;
            }
            exitCycle:
            if (sum >= maxSumBoundary)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSumBoundary}");
            }
            else
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}