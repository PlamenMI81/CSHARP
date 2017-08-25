using System;

namespace SmallestNumber
{
    class SmallestNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int min = num;
            for (int i = 0; i < n - 1; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }
    }
}
