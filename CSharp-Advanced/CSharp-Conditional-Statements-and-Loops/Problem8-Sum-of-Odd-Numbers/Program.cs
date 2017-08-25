using System;

namespace Problem8_Sum_of_Odd_Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            int counter = 1;
            while (counter <= n)
            {
                Console.WriteLine(i);
                sum += i;
                i += 2;
                counter++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}