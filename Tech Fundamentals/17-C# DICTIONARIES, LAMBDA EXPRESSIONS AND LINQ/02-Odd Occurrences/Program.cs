using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var count = new Dictionary<string, int>();
            foreach (var num in input)
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
            List<string> result = new List<string>();
            foreach (var keyValuePair in count)
            {
                if (keyValuePair.Value %2 !=0)
                {
                    result.Add(keyValuePair.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
