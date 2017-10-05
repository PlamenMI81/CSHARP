using System;
using System.Numerics;

namespace _13_Factorial
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
            Console.WriteLine(result);
        }
    }
}
