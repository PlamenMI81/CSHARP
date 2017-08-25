using System;

namespace Sequence2k_1
{
    class Sequence2k_1
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            while (num<=n)
            {
                Console.WriteLine(num);
                num = num * 2 + 1;
            }
        }
    }
}
