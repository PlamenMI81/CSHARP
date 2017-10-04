using System;

namespace _09_Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputIntNumber =int.Parse(Console.ReadLine());
            inputIntNumber = Math.Abs(inputIntNumber);
            Console.WriteLine(GetMultipleOfEvensAndOdds(inputIntNumber));
        }

        private static int GetMultipleOfEvensAndOdds(int inputIntNumber)
        {
            int sumEvens=GetSumOfEvenDigits(inputIntNumber);
            int sumOdds = GetSumOfOddDigits(inputIntNumber);
            return sumEvens * sumOdds;
        }

        private static int GetSumOfOddDigits(int inputIntNumber)
        {
            int sum = 0;
            while (inputIntNumber>0)
            {
                
                int lastDigit = inputIntNumber % 10;
                if (lastDigit%2 !=0)
                {
                    sum += lastDigit;
                }
                inputIntNumber /= 10;
            }
            return sum;
        }

        private static int GetSumOfEvenDigits(int inputIntNumber)
        {
            int sum = 0;
            while (inputIntNumber > 0)
            {

                int lastDigit = inputIntNumber % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                inputIntNumber /= 10;
            }
            return sum;
        }
    }
}
