using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            List<int> sequences = new List<int>();
            for (int i = 0; i < InputNumbers.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j <= i; j++)
                {
                    if (InputNumbers[i] == InputNumbers[j]) counter++;
                }
                sequences.Add(counter);
            }

            int maxSequence = sequences.Max();
            int positionmax = sequences.IndexOf(sequences.Max());
            for (int i = 0; i < maxSequence; i++)
            {
                Console.Write(InputNumbers[positionmax]);
                if (i != maxSequence - 1) Console.Write(" ");
                else Console.WriteLine();
            }
        }
    }
}
