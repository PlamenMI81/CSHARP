using System;

namespace problem64
{
    internal class Program
    {
//Цифри
        private static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine()); //100...999
            int firstDigit = num / 100;
            int secondDigit = num / 10 % 10;
            int thirdDigit = num % 10;
            int rows = firstDigit + secondDigit;
            int cols = firstDigit + thirdDigit;
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= cols; j++)
                {
                    if (num % 5 == 0)
                        num = num - firstDigit;
                    else if (num % 3 == 0)
                        num = num - secondDigit;
                    else
                        num = num + thirdDigit;
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}