using System;

namespace _16_Comparing_Floats
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            const double eps = 0.000001;
            bool isEqual = true;
            double diff = Math.Abs(num1 - num2);
            if (diff >= eps)
                isEqual = false;
            Console.WriteLine(isEqual);
        }
    }
}