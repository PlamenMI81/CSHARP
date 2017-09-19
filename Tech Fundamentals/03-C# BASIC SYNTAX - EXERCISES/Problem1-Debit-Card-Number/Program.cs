using System;

namespace Problem1_Debit_Card_Number
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1:0000} {num2:0000} {num3:0000} {num4:0000}");
        }
    }
}