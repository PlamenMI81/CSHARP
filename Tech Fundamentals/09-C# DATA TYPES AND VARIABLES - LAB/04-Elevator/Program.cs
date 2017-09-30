using System;

namespace _04_Elevator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int fullCources = (int) Math.Ceiling((double) numOfPeople / capacity);
            Console.WriteLine(fullCources);
        }
    }
}