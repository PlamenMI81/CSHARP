using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] InputNumbers = File.ReadAllText(@"input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            File.WriteAllText("output.txt", "");
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

            int maxsequence = sequences.Max();
            int positionmax = sequences.IndexOf(sequences.Max());
            for (int i = 0; i < maxsequence; i++)
            {
                //Console.Write(InputNumbers[positionmax]);
                File.AppendAllText(@"output.txt", InputNumbers[positionmax].ToString());
                if (i != maxsequence - 1) //Console.Write(" ");
                    File.AppendAllText(@"output.txt", " ");
                else
                    //Console.WriteLine();
                    File.AppendAllText(@"output.txt", Environment.NewLine);
            }
        }
    }
}
