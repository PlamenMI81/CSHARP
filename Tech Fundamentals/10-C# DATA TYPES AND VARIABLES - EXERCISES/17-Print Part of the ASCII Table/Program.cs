using System;

namespace _17_Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (char i = (char) startIndex; i <= (char) endIndex; i++)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}