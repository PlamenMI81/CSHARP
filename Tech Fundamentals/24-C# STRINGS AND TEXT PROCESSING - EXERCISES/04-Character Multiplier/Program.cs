using System;

namespace _04_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine().Split();
            var firstString = inputStr[0].ToCharArray();
            var secondString = inputStr[1].ToCharArray();
            var shortestString = firstString.Length <= secondString.Length ? firstString : secondString;
            var currMultiply = 0;

            for (int i = 0; i < shortestString.Length; i++)
            {
                currMultiply = firstString[i] * secondString[i] + currMultiply;
            }
        }
    }
}
