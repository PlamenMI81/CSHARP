using System;
using System.Linq;
using System.Numerics;

namespace _02_Convert_from_base_N_to_base_10
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int baseN = int.Parse(input[0]);
            string numberInBaseN = input[1];

            ConvertToBase10(baseN, numberInBaseN);
        }

        private static void ConvertToBase10(int baseN, string numberInBaseN)
        {
            int power = (numberInBaseN.Length - 1);
            char[] numberToChar = numberInBaseN.ToCharArray();
            BigInteger result = 0;
            for (int i = 0; i < numberToChar.Length; i++)
            {
                result = result + (numberToChar[i] - 48) * BigInteger.Pow(baseN,power);
                power--;
            }
            Console.WriteLine(result);
        }
    }
}
