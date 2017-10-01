using System;

namespace _15_Fast_Prime_Checker___Refactor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= range; currentNum++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currentNum); i++)
                    if (currentNum % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}