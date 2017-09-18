using System;

namespace Problem6_IntervalofNumbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secNum = int.Parse(Console.ReadLine());
            int small = 0, big = 0;
            if (firstNum < secNum)
            {
                small = firstNum;
                big = secNum;
            }
            else
            {
                small = secNum;
                big = firstNum;
            }
            for (int i = small; i <= big; i++)
                Console.WriteLine(i);
        }
    }
}