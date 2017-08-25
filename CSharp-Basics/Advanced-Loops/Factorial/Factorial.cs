using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fact = 1;
            do
            {
                fact = fact * n;
                n--;
            } while (n>1);
            Console.WriteLine(fact);
        }
    }
}
