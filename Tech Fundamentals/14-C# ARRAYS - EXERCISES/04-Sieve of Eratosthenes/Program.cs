using System;

namespace _04_Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number =int.Parse(Console.ReadLine());
            bool[] primes=new Boolean[number];
            for (int i = 2; i <primes.Length; i++)
            {
                primes[i] = true;
            }
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (primes[i])
                {
                    int j = i * i;
                    int firstIndex = 1;
                    while (j<number)
                    {
                        primes[j] = false;
                        j = i * i + firstIndex * i;
                        firstIndex++;
                    }
                }
            }
            for (int i = 1; i < primes.Length; i++)
            {
                if (primes[i])
                {
                    Console.Write(i+" ");
                } 
            }
            Console.WriteLine();
        }
    }
}
