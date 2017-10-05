using System;

namespace _12_Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (IsPalindrome(i) && SumOfDigits(i) && ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            while (i > 0)
            {
                int lastDigit = i % 10;
                if (lastDigit%2==0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigits(int i)
        {
            int sum = 0;
            while (i>0)
            {
                int lastDigit = i % 10;
                sum += lastDigit;
                i /= 10;
            }
            if (sum % 7==0) return true;
            return false;
            
        }

        private static bool IsPalindrome(int i)
        {
            string sNum = i.ToString();
            for (int j = 0; j < sNum.Length; j++)
                if (sNum[j] != sNum[sNum.Length - 1 - j]) return false;

            return true;
        }
    }
}
