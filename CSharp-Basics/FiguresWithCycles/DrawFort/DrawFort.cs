using System;
using System.Text;

namespace DrawFort
{
    internal class DrawFort
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
            char rightSlash = '/';
            char leftSlash = '\\';
            string triangle = "^";
            char pipe = '|';
            string underline = "_";
            int underscoreWidth = 2 * n - n / 2 * 2 - 4;
            int triangleWidth = n / 2;
            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}",
                rightSlash, GenerateFrom(triangle, triangleWidth), leftSlash, GenerateFrom(underline, underscoreWidth));
            for (int i = 1; i <= n - 2; i++)
                if (i == n - 2)
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                        pipe, GenerateFrom(" ", triangleWidth + 1), GenerateFrom(underline, underscoreWidth));
                else
                    Console.WriteLine("{0}{1}{0}", pipe, GenerateFrom(" ", 2 * n - 2));
            Console.WriteLine("{0}{1}{2}{3}{0}{1}{2}",
                leftSlash, GenerateFrom(underline, triangleWidth), rightSlash, GenerateFrom(" ", underscoreWidth));
        }
    }
}