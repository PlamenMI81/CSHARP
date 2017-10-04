using System;

namespace _01_Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
        }

        private static void GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
