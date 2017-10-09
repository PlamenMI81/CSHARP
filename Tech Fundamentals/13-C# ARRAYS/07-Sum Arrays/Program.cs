using System;
using System.Linq;

namespace _07_Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stringOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] stringTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int longerArray = Math.Max(stringOne.Length, stringTwo.Length);
            int[] sumArrays = new int[longerArray];
            for (int i = 0; i < longerArray; i++)
            {
                sumArrays[i] = stringOne[i % stringOne.Length] + stringTwo[i % stringTwo.Length];

            }
            foreach (int sumArray in sumArrays)
            {
                Console.Write(sumArray + " ");
            }
            Console.WriteLine();
        }
    }
}
