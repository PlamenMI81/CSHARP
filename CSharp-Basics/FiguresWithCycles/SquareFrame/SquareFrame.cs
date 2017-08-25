using System;
using System.Text;

namespace SquareFrame
{
    class SquareFrame
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
            Console.Write(GenerateFrom("+ ",1));
            Console.Write(GenerateFrom("- ",n-2));
            Console.WriteLine(GenerateFrom("+",1));
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write(GenerateFrom("| ", 1));
                Console.Write(GenerateFrom("- ", n - 2));
                Console.WriteLine(GenerateFrom("|", 1));
            }
            Console.Write(GenerateFrom("+ ", 1));
            Console.Write(GenerateFrom("- ", n - 2));
            Console.WriteLine(GenerateFrom("+", 1));
        }
    }
}
