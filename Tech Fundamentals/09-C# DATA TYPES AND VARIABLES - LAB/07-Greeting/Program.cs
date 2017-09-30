using System;

namespace _07_Greeting
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string firsName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firsName} {lastName}. You are {age} years old.");
        }
    }
}