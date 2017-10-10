using System;
using System.Linq;

namespace _06_Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = seq.Length - 1;
            int element = 0;
            int bestElement = 0;
            int len = 1;
            int bestLen = 1;
            for (int i = start; i >= 1; i--)
            {
                if (seq[i] == seq[i - 1] )
                {
                    element = seq[i];
                    len++;
                    if (len >= bestLen)
                    {
                        bestElement = element;
                        bestLen = len;
                    }
                }
                else
                {
                    len = 1;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write($"{bestElement} "); 
            }
            Console.WriteLine();
        }
    }
}
