using System;
using System.Linq;

namespace _04_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine().Split();
            var firstString = inputStr[0].ToCharArray();
            var secondString = inputStr[1].ToCharArray();
            var shorterString = firstString.Length <= secondString.Length ? firstString : secondString;
            var longerString= firstString.Length >= secondString.Length ? firstString : secondString;
            var result = 0;

            for (int i = 0; i < shorterString.Length; i++)
            {
                result = firstString[i] * secondString[i] + result;
            }
            for (int i = shorterString.Length; i < longerString.Length; i++)
            {
                result = result + longerString[i];
            }



            //if (firstString.Length != secondString.Length)
            //{
            //    var diff = longerString.Length - shorterString.Length;
            //    var sumlast = longerString.TakeLast(diff).Sum(x => x);
            //    result = result + sumlast;
            //}
            Console.WriteLine(result);
        }
    }
}
