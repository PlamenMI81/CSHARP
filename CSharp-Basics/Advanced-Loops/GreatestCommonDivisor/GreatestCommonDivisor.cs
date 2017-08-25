using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b!=0)
            {
                int oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine("COD = {0}",a);
        }
    }
}
