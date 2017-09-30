using System;

namespace _06_Triples_of_Letters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (char i = 'a'; i < 'a' + n; i++)
            for (char j = 'a'; j < 'a' + n; j++)
            for (char k = 'a'; k < 'a' + n; k++)
                Console.WriteLine($"{i}{j}{k}");
        }
    }
}