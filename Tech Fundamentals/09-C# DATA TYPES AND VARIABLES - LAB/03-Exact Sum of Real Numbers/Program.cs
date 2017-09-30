using System;

namespace _03_Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 1; i <= numbers; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                sum = sum + num;
            }
            Console.WriteLine(sum);
        }
    }
}