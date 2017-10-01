using System;

namespace _07_Exchange_Variable_Values
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte a = 5;
            byte b = 10;
            byte temp;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}