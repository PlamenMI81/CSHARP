using System;

namespace _04_Variable_in_Hexadecimal_Format
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string hexadecimalNumber = Console.ReadLine();
            decimal decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
            Console.WriteLine(decimalNumber);
        }
    }
}