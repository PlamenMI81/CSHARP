using System;

namespace NumberInRange_1_100_
{
    class NumberInRange_1_100_
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num<1 || num>100)
            {
                Console.WriteLine("Invalid number!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: {0}", num);
        }
    }
}
