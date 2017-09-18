using System;

namespace Problem11_Odd_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int num = int.Parse(Console.ReadLine());
                num = Math.Abs(num);
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                    continue;
                }
                Console.WriteLine($"The number is: {num}");
                break;
            }
        }
    }
}