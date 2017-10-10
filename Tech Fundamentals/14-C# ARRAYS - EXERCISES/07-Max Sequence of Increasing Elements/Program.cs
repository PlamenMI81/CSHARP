using System;
using System.Linq;

namespace _07_Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int end = seq.Length - 1;
            string element = null;
            string bestElement = null;
            int len = 1;
            int bestLen = 1;
            for (int i = 0; i <end; i++)
            {
                if (seq[i+1] == seq[i] + 1)
                {
                    element = seq[i]+" "+seq[i+1]+" "+element;
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
            
            Console.Write($"{bestElement} ");
            
            
        }
    }
}
