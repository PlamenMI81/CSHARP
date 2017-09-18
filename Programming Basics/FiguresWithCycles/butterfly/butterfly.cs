using System;
using System.Text;

namespace butterfly
{
    internal class butterfly
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
            string starSign = "*";
            string minusSign = "-";
            string leftSlash = "\\";
            string rightSlash = "/";
            for (int i = 1; i <= n - 2; i++)
                if (i % 2 != 0)
                    Console.WriteLine("{0}{1} {2}{0}",
                        GenerateFrom(starSign, n - 2), leftSlash, rightSlash);
                else
                    Console.WriteLine("{0}{1} {2}{0}",
                        GenerateFrom(minusSign, n - 2), leftSlash, rightSlash);
            Console.WriteLine("{0}@", GenerateFrom(" ", n - 1));
            for (int i = 1; i <= n - 2; i++)
                if (i % 2 != 0)
                    Console.WriteLine("{0}{1} {2}{0}",
                        GenerateFrom(starSign, n - 2), rightSlash, leftSlash);
                else
                    Console.WriteLine("{0}{1} {2}{0}",
                        GenerateFrom(minusSign, n - 2), rightSlash, leftSlash);
        }
    }
}