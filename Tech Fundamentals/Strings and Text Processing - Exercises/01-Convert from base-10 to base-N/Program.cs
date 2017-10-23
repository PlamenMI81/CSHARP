using System;
using System.Linq;

namespace _01_Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseN = int.Parse(input[0]);
            var base10 = int.Parse(input[1]);
            var base10ToBinary = Convert.ToString(base10, 2).ToArray();
            var sum = 0.0;
            //var power = base10ToBinary.Length - 1;

            for (int i = 0; i < base10ToBinary.Length-1; i++)
            {
                var currChartoStr = base10ToBinary[0].ToString();
                var currChar = int.Parse(currChartoStr) * Math.Pow(baseN, base10ToBinary.Length - 1 - i);
                sum = sum + currChar;
            }
            
        }
    }
}
