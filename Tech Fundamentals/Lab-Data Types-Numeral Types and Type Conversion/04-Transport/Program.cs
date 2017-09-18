using System;

namespace _04_Transport
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            double capacity = numOfPeople / 24.0;
            Console.WriteLine($"{Math.Ceiling(capacity)}");
        }
    }
}