using System;
using System.Linq;

namespace _06_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] seq = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int seqLen = seq.Length - 1;
            int equal = 1;
            int maxEqual = 1;
            int sign = 0;
            int bestSign = 0;
            MaxEqualSeq(seq, seqLen, equal, ref maxEqual, sign, ref bestSign);
            
            //Print result
            for (int i = 0; i < maxEqual; i++)
                if (i == maxEqual - 1)
                    Console.WriteLine(bestSign);
                else
                    Console.Write(bestSign + " ");
        }

        private static void MaxEqualSeq(int[] seq, int seqLen, int equal, ref int maxEqual, int sign, ref int bestSign)
        {
            for (int i = 0; i <= seqLen - 1; i++)
            {
                if (seq[i] == seq[i + 1])
                {
                    equal++;
                    sign = seq[i];
                }
                else
                {
                    equal = 1;
                }
                if (equal > maxEqual)
                {
                    maxEqual = equal;
                    bestSign = sign;
                }
            }
        }
    }
}