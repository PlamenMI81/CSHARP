using System;

namespace Problem12_Number_checker
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num;
            try
            {
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("It is a number.");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}