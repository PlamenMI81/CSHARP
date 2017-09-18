using System;

namespace BigestNumber
{
    class BigestNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());
            int max = num;
            for (int i = 0; i < n-1; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num>max)
                {
                    max = num;
                }
            }
            Console.WriteLine(max);
        }
    }
}
