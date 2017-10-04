using System;

namespace _05_Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(n == 0 ? 1 : Fibonacci(n));
        }
        private static int Fibonacci(int n)
        {
            int f1 = 0;
            int f2 = 1;
            int fNext = 0;
            for (int i = 1; i <= n; i++)
            {
                fNext = f1 + f2;
                f1 = f2;
                f2 = fNext;
            }
            return fNext;
        }
    }
}
