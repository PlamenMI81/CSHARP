using System;
using System.Linq;
using System.Text;

namespace _06_Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFirstLine = Console.ReadLine().TrimStart('0');
            var inputSecondLine = Console.ReadLine().TrimStart('0');
            var diffLen = Math.Abs(inputFirstLine.Length - inputSecondLine.Length);
            var shortStr = inputFirstLine.Length <= inputSecondLine.Length ? inputFirstLine : inputSecondLine;
            var longStr = inputFirstLine.Length > inputSecondLine.Length ? inputFirstLine : inputSecondLine;
            if (diffLen != 0)
            {
                var leedingZeroes = new string('0', diffLen);
                shortStr = string.Concat(leedingZeroes, shortStr);
            }
            var stringResult = "";
            StringBuilder sb = new StringBuilder();
            var rem = 0;
            for (int i = shortStr.Length - 1; i >= 0; i--)
            {
                var currCharSum = (shortStr[i] - 48) + (longStr[i] - 48) +rem;
                if (currCharSum > 9 && i>0)
                {
                    rem = currCharSum / 10;
                    currCharSum = currCharSum - 10;
                }
                else
                {
                    rem = 0;
                }
                sb.Insert(0,currCharSum);
            }
            Console.WriteLine(stringResult = sb.ToString());
        }
    }
}
