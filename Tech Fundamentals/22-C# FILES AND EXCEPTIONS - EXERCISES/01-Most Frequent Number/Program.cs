using System;
using System.IO;
using System.Linq;

namespace _01_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = File.ReadAllText(@"input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int equalSigns = 0;
            int howTimes = 1;
            int bestSign = 1;
            int bestHowTimes = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i; j < sequence.Length; j++)
                {
                    if (sequence[i] == sequence[j])
                    {
                        equalSigns = sequence[i];
                        howTimes++;
                    }

                    if (howTimes > bestHowTimes)
                    {
                        bestSign = equalSigns;
                        bestHowTimes = howTimes;
                    }
                }
                howTimes = 1;
            }
            File.WriteAllText("output.txt", "");
            File.AppendAllText(@"output.txt", bestSign.ToString());
        }
    }
}
