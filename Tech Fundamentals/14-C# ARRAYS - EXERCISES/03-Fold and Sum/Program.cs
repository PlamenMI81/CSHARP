using System;
using System.Linq;

namespace _03_Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sum = new int[inputArray.Length / 2];
            Fold(inputArray);
            Sum(inputArray,sum);
        }

        private static int[] Sum(int[] inputArray, int[] sum)
        {
            for (int i = 0; i <inputArray.Length/4; i++)
            {
                sum[i] = inputArray[i] + inputArray[i + inputArray.Length / 4];
            }
            for (int i = inputArray.Length/2; i < (inputArray.Length - inputArray.Length / 4); i++)
            {
                sum[i] = inputArray[i] + inputArray[i + (inputArray.Length-inputArray.Length/4)];
            }
            return  sum;
        }

        private static int[] Fold(int[] inputArray)
        {
            int leftFoldEndBorder = inputArray.Length / 4;
            int rightFoldStartBorder = inputArray.Length - (inputArray.Length / 4);
            Array.Reverse(inputArray, 0, leftFoldEndBorder);
            Array.Reverse(inputArray, rightFoldStartBorder, leftFoldEndBorder);
            return inputArray;
        }
    }
}