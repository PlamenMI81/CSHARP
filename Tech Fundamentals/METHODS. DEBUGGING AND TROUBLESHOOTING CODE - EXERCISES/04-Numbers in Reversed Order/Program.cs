using System;
using System.Linq;

namespace _04_Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            ReverseNumber(number);
        }

        private static void ReverseNumber(string number)
        {
            int index = 0;
            for (int i = 1; i <= number.Length; i++)
            {
                char lastSybmol = number[number.Length - 1 - index];
                Console.Write(lastSybmol);
                index++;
            }
            Console.WriteLine();
        }
    }
}
