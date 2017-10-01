using System;

namespace _13_Vowel_or_Digit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            bool isDigit = int.TryParse(input, out _);
            if (isDigit)
                Console.WriteLine("digit");
            else if (input == "a" || input == "o" || input == "u" || input == "e" || input == "i")
                Console.WriteLine("vowel");
            else
                Console.WriteLine("other");
        }
    }
}