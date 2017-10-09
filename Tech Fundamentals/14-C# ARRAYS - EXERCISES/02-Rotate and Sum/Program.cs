using System;
using System.Linq;

namespace _02_Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotation =int.Parse(Console.ReadLine());
            int[]resultInts=new int[inputArray.Length];
            for (int i = 0; i < rotation; i++)
            {
                int tmp = inputArray[inputArray.Length - 1];
                for (int j = inputArray.Length-1; j > 0; j--)
                {
                    inputArray[j] = inputArray[j - 1];
                }
                inputArray[0] = tmp;
                for (int j = 0; j < inputArray.Length; j++)
                {
                    resultInts[j] += inputArray[j];
                }
            }
            Console.WriteLine(string.Join(" ",resultInts));
        }
    }
}
