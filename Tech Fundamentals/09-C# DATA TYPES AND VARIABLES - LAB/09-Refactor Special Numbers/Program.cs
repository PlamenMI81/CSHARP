using System;

namespace _09_Refactor_Special_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int ch = 1; ch <= number; ch++)
            {
                int sumDigits = 0;
                int currentDigit = ch;
                while (ch > 0)
                {
                    sumDigits += ch % 10;
                    ch = ch / 10;
                }
                bool isSpecial = sumDigits == 5 || sumDigits == 7 || sumDigits == 11;
                Console.WriteLine($"{currentDigit} -> {isSpecial}");
                ch = currentDigit;
            }
        }
    }
}