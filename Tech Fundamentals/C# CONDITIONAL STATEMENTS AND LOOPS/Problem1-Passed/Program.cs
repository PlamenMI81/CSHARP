using System;

namespace Problem1_Passed
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 3.00)
                Console.WriteLine("Passed!");
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}