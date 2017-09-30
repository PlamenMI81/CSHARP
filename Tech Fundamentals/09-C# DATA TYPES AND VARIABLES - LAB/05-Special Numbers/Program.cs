using System;

namespace _05_Special_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digits = i;
                int digitSum = 0;
                while (digits > 0)
                {
                    int currentDigit = digits % 10;
                    digitSum = digitSum + currentDigit;
                    digits = digits / 10;
                }
                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                    Console.WriteLine($"{i} -> True");
                else
                    Console.WriteLine($"{i} -> False");
            }
        }
    }
}