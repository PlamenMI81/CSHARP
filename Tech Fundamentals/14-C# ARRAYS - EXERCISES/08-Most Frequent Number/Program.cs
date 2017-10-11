using System;
using System.Linq;

namespace _08_Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int equalSigns=0;
            int howTimes = 1;
            int bestSign=1;
            int bestHowTimes = 1;
            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = i + 1; j < sequence.Length; j++)
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
                howTimes=1;
            }
            Console.WriteLine(bestSign);
        }
    }
}
