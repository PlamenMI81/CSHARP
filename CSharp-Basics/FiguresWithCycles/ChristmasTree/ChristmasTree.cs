using System;
using System.Text;

namespace ChristmasTree
{
    class ChristmasTree
    {
        private static string GenerateFrom(string input, int times)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                builder.Append(input);
            }
            return builder.ToString();
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.Write(GenerateFrom(" ", n - i));
                Console.Write(GenerateFrom("*", i));
                Console.Write(" | ");
                Console.WriteLine(GenerateFrom("*", i));
            }
        }
    }
}
