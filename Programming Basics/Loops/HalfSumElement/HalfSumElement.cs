using System;
using System.Linq;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int sum = numbers.Sum();
            int max = numbers.Max();
            if (max == sum - max)
            {
                Console.WriteLine($"Yes\nSum = {max}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(max - (sum - max))}");
            }
        }
    }
}
