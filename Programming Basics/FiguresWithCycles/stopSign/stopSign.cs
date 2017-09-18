using System;
using System.Text;

namespace stopSign
{
    internal class stopSign
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
            string dots = ".";
            string underline = "_";
            string doubleRightSlash = "//";
            string doubleLeftSlash = "\\\\";
            Console.WriteLine("{0}{1}{0}", GenerateFrom(dots, n + 1), GenerateFrom(underline, 2 * n + 1));
            for (int i = 1; i <= n + 1; i++)
                if (i == n + 1)
                    Console.WriteLine("{0}{1}{2}STOP!{2}{3}{0}",
                        GenerateFrom(dots, n + 1 - i), doubleRightSlash,
                        GenerateFrom(underline, (n * 2 + i * 2 - 3 - 5) / 2), doubleLeftSlash);
                else
                    Console.WriteLine("{0}{1}{2}{3}{0}",
                        GenerateFrom(dots, n + 1 - i), doubleRightSlash, GenerateFrom(underline, n * 2 + i * 2 - 3),
                        doubleLeftSlash);
            for (int i = 1; i <= n; i++)
                Console.WriteLine("{0}{1}{2}{3}{0}",
                    GenerateFrom(dots, i - 1), doubleLeftSlash, GenerateFrom(underline, n * 4 - i * 2 + 1),
                    doubleRightSlash);
        }
    }
}