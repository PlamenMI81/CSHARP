using System;
using System.Text;

namespace Rectangle_of_N_x_N_Stars
{
    class Rectangle_of_N_x_N_Stars
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
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(GenerateFrom("* ", num));
                //Console.WriteLine($"{new string('*', num)}{new string(' ',num)}");
            }
        }
    }
}
