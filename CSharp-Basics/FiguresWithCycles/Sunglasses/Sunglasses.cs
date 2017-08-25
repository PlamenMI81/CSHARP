using System;

namespace Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.Write("*");
                if (n % 2 == 0)
                {
                    if (i == n / 2-1)
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }
                }
                else
                {
                    if (i == n / 2)
                    {
                        Console.Write(new string('|', n));
                    }
                    else
                    {
                        Console.Write(new string(' ', n));
                    }
                }
                Console.Write("*");
                Console.Write(new string('/', n * 2 - 2));
                Console.WriteLine("*");
            }
            Console.Write(new string('*', n * 2));
            Console.Write(new string(' ', n));
            Console.WriteLine(new string('*', n * 2));
        }
    }
}
