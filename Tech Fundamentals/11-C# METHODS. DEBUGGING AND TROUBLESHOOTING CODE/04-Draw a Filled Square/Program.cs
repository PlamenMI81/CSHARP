using System;

namespace _04_Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintDashes(number);
            for (int i = 1; i <= number - 2; i++)
            {
                PrintInnerPart(number);
            }
            PrintDashes(number);
        }

        private static void PrintInnerPart(int n)
        {
            Console.Write("-");
            for (int i = 1; i <= n - 1; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        private static void PrintDashes(int n)
        {
            Console.WriteLine($"{new string('-', n * 2)}");
        }
    }
}
