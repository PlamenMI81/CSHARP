using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberStr =(Console.ReadLine());
            int number =int.Parse(numberStr);
            bool isSpecial = false;
            int sumOfDigits=0;
            
            number = int.Parse(numberStr);
            for (int i = 1; i <= number; i++)
            {
                for (int i = 1; i <= numberStr.Length; i++)
                {
                    sumOfDigits = sumOfDigits + number % 10;
                    number = number / 10;
                }
                if (sumOfDigits==5 || sumOfDigits==7 || sumOfDigits==11)
                {
                    isSpecial = true;
                }
                Console.WriteLine($"{i} -> {isSpecial}");
            }

        }
    }
}
