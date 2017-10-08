using System;

namespace _03_Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i - k; j <= i - 1; j++)
                {
                    if (j >= 0)
                    {
                        sequence[i] += sequence[j];
                    }
                }
            }
            foreach (var nums in sequence)
            {
                Console.Write(nums+" ");
            }
            Console.WriteLine();
        }
    }
}
