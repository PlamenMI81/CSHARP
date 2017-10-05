using System;
using System.Numerics;

namespace _14_Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            CalculateFactoriel(number);
        }

        private static void CalculateFactoriel(int number)
        {
            BigInteger result = number;
            for (int i = 1; i < number; i++)
            {
                result = result * i;
            }
            CauntZeroesInResult(result);
        }

        private static void CauntZeroesInResult(BigInteger result)
        {
            string resultStr = result.ToString();
            int countZeros = 0;
            int stringlenght = resultStr.Length-1;
            for (int i = 0; i < stringlenght; i++)
            {
                if (resultStr.EndsWith("0"))
                {
                    countZeros++;
                    resultStr = resultStr.Remove(stringlenght - i);
                }
                else
                {
                    Console.WriteLine(countZeros);
                    return;
                }
            }
        }
    }
}
