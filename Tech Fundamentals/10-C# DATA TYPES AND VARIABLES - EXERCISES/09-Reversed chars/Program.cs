using System;

namespace _09_Reversed_chars
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char ch1 = char.Parse(Console.ReadLine());
            char ch2 = char.Parse(Console.ReadLine());
            char ch3 = char.Parse(Console.ReadLine());
            Console.WriteLine($"{ch3}{ch2}{ch1}");
        }
    }
}