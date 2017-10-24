using System;
using System.IO;
using System.Linq;

namespace _03_Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = File.ReadAllText(@"input.txt")
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int leftSum = 0;
            int rightSum = 0;
            string index = "no";

            for (int i = 0; i < sequence.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    leftSum += sequence[j];
                }
                for (int k = i + 1; k < sequence.Length; k++)
                {
                    rightSum += sequence[k];
                }
                if (leftSum == rightSum)
                {
                    index = i.ToString();

                }
                leftSum = 0;
                rightSum = 0;
            }
            File.WriteAllText("output.txt", "");
            File.AppendAllText(@"output.txt", index);
        }
    }
}
