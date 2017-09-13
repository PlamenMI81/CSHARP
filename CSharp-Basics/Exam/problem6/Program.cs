using System;

namespace problem6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int monets1lv = int.Parse(Console.ReadLine());
            int monets2lv = int.Parse(Console.ReadLine());
            int banknotes5lv = int.Parse(Console.ReadLine());
            int sumTo = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i <= monets1lv; i++)
            for (int j = 0; j <= monets2lv; j++)
            for (int k = 0; k <= banknotes5lv; k++)
            {
                sum = i * 1 + j * 2 + k * 5;
                if (sum == sumTo)
                    Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
            }
        }
    }
}