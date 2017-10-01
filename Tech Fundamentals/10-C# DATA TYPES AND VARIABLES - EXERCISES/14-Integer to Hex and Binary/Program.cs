using System;

namespace _14_Integer_to_Hex_and_Binary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int decimalNumber = int.Parse(Console.ReadLine());
            string hexsadecimal = Convert.ToString(decimalNumber, 16).ToUpper();
            string binary = Convert.ToString(decimalNumber, 2);
            Console.WriteLine($"{hexsadecimal}\r\n{binary}");
        }
    }
}