using System;
using System.Text;

namespace House
{
    internal class House
    {
        private static string GenerateFrom(string input, int times)
        {
            var builder = new StringBuilder();
            for (int i = 0; i < times; i++)
                builder.Append(input);
            return builder.ToString();
        }

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int roofIteratio = (n + 1) / 2;
            for (int i = 1; i <= roofIteratio; i++)
                if (n % 2 == 0)
                {
                    Console.Write(new string('-', n / 2 - i));
                    Console.Write(GenerateFrom("**", i));
                    Console.WriteLine(new string('-', n / 2 - i));
                }
                else
                {
                    Console.Write(new string('-', (n + 1) / 2 - i));
                    if (i == 1)
                        Console.Write(new string('*', i));
                    else
                        Console.Write(new string('*', i * 2 - 1));
                    Console.WriteLine(new string('-', (n + 1) / 2 - i));
                }
            for (int j = 1; j <= n - roofIteratio; j++)
            {
                Console.Write(new string('|', 1));
                Console.Write(new string('*', n - 2));
                Console.WriteLine(new string('|', 1));
            }
        }
    }
}