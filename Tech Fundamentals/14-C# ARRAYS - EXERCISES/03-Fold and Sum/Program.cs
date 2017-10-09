using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = inputArray.Length / 4;

            int[] leftArr = inputArray.Take(k).ToArray();
            int[] mid = inputArray.Skip(k).Take(k * 2).ToArray();
            int[] rightArr = inputArray.Skip(k * 3).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] sum = leftArr.Concat(rightArr).ToArray();

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] += mid[i];
            }

            Console.WriteLine($"{string.Join(" ", sum)}");
        }
    }
}