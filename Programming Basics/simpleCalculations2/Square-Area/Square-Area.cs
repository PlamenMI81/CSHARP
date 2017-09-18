using System;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the side: ");
            int side = int.Parse(Console.ReadLine());
            var squareArea = side * side;
            Console.WriteLine(squareArea);
        }
    }
}