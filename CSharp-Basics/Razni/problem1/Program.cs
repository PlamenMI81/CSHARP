using System;

namespace problem1
{ // sum of digits of N-digit number
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nToStr = n.ToString();
            int length = nToStr.Length;
            int sum = 0;
            for (int i = 1; i <= length; i++)
            {
                int lastDigit = n % 10;
                sum = sum + lastDigit;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits is: " + sum);
        }
    }
}