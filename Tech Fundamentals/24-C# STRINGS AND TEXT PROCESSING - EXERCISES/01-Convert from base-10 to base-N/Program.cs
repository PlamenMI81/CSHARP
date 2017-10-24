using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01_Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var baseN = int.Parse(input[0]);
            BigInteger base10 = BigInteger.Parse(input[1]);

            ConvertToBaseN(baseN, base10);
        }

        private static void ConvertToBaseN(BigInteger baseN, BigInteger base10)
        {
            string toBaseN = "";
            BigInteger start = base10;
            var resultString = "";
            while (true)
            {
                if (start < baseN)
                {
                    resultString += start;
                    break;
                }
                resultString = resultString + (start % baseN);
                start = start / baseN;
            }
            toBaseN = new string(resultString.ToCharArray().Reverse().ToArray());
            Console.WriteLine(toBaseN);
        }
    }
}
