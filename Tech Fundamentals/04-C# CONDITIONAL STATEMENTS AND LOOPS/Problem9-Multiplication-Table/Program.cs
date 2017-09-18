using System;

namespace Problem9_Multiplication_Table
{//Problem 10. Multiplication Table 2.0
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m= int.Parse(Console.ReadLine());
            for (int i = m; i <= 10; i++)
            {
                int mult = n * i;
                Console.WriteLine($"{n} X {i} = {mult}");
            }
            if (m>10)
            {
                int mult = n * m;
                Console.WriteLine($"{n} X {m} = {mult}");
            }
        }
    }
}