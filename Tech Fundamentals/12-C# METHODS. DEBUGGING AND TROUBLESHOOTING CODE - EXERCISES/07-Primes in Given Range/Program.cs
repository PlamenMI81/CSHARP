using System;
using System.Collections.Generic;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            long start = long.Parse(Console.ReadLine());
            long end = long.Parse(Console.ReadLine());
            List<long> primeList = FindPrimesInRange(start, end);
            string numbers = String.Join(", ", primeList.ToArray());
            Console.WriteLine(numbers);
        }

        static List<long> FindPrimesInRange(long startNum, long endNum)
        {
            List<long> list = new List<long>();
            for (long i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        private static bool IsPrime(long n)
        {
            bool prime = true;
            if (n <= 1)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        prime = false;
                        break;
                    }
                }
            }
            return prime;
        }
    }
}