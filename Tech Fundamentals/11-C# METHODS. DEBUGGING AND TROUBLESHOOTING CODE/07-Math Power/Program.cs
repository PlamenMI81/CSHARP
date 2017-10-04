using System;

namespace _07_Math_Power
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RiceToPower(number, power);
            Console.WriteLine(result);
        }

        private static double RiceToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}