using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            var sumRemovedValues = 0;
            while (input.Count > 0)
            {
                var returnedValue = 0;
                int index = int.Parse(Console.ReadLine());
                if (index < 0)
                {
                    returnedValue = CopyLastIndexInFirstIndex(input);
                }
                else if (index > input.Count - 1)
                {
                    returnedValue = CopyFirstIndexInLastIndex(input, input.Count - 1);
                }
                else
                {
                    returnedValue = IncreaseDercreeseValues(input, index);
                }
                sumRemovedValues += returnedValue;
            }
            Console.WriteLine(sumRemovedValues);
        }
        private static int IncreaseDercreeseValues(List<int> input, int index)
        {
            var removedValue = input[index];
            input.RemoveAt(index);
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= removedValue)
                {
                    input[i] += removedValue;
                }
                else if (input[i] > removedValue)
                {
                    input[i] -= removedValue;
                }
            }
            return removedValue;
        }

        private static int  CopyFirstIndexInLastIndex(List<int> input, int lastIndex)
        {
            var lastValue = input[lastIndex];
            input[lastIndex] = input[0];
            var removedValue = lastValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= removedValue)
                {
                    input[i] += removedValue;
                }
                else if (input[i] > removedValue)
                {
                    input[i] -= removedValue;
                }
            }
            return lastValue;
        }

        private static int CopyLastIndexInFirstIndex(List<int> input)
        {
            var firstValue = input[0];
            input[0] = input[input.Count - 1];
            var removedValue = firstValue;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= removedValue)
                {
                    input[i] += removedValue;
                }
                else if (input[i] > removedValue)
                {
                    input[i] -= removedValue;
                }
            }
            return firstValue;
        }
    }
}
