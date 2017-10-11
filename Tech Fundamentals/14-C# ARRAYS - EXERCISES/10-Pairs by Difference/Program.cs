using System;
using System.Linq;

namespace _10_Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diffrence = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < seq.Length; i++)
            {
                for (int j = i; j < seq.Length; j++)
                {
                    if (i != seq.Length - 1)
                    {
                        if (Math.Abs(seq[i] - seq[j]) == diffrence)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
