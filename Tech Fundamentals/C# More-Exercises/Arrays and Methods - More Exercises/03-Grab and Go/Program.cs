using System;
using System.Linq;

namespace _03_Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] input = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int lastNumToFind = int.Parse(Console.ReadLine());
            int lastIndex = -1;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i] == lastNumToFind)
                {
                    lastIndex = i; break;
                }
            }
            if (lastIndex < 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                var inputSum = input.Take(lastIndex).Sum();
                Console.WriteLine(inputSum);
            }
        }
    }
}
