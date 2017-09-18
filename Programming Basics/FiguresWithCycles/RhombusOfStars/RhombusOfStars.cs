using System;
using System.Text;

namespace RhombusOfStars
{
    class RhombusOfStars
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
            for (int row = 1; row <= n; row++)
            {
                Console.Write(GenerateFrom(" ",n-row));
                Console.Write("*");
                Console.WriteLine(GenerateFrom(" *",row-1));
            }
            for (int rowDown = n-1; rowDown >= 1; rowDown--)
            {
                Console.Write(GenerateFrom(" ",n-rowDown) );
                Console.Write(GenerateFrom("* ", rowDown));
                Console.WriteLine();
            }
        }
    }
}
