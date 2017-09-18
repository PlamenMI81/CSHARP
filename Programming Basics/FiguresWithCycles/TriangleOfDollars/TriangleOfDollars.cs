using System;
using System.Text;

namespace TriangleOfDollars
{
    class TriangleOfDollars
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
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(GenerateFrom("$ ",i));
            }
        }
    }
}
