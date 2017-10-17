using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var count = new SortedDictionary<double, int>();
            foreach (double num in input)
            {
                if (count.ContainsKey(num))
                {
                    count[num]++;
                }
                else
                {
                    count[num] = 1;
                }
            }
            foreach (var keyValuePair in count)
            {
                Console.WriteLine($"{keyValuePair.Key} -> {keyValuePair.Value}");
            }
        }
    }
}
