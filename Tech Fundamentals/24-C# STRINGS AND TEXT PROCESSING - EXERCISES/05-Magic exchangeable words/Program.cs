using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Magic_exchangeable_words
{
    class Program
    {
        static void Main()
        {
            again:
            var inputLine = Console.ReadLine().Split();
            var result = IsMagic(inputLine);
            Console.WriteLine(result.ToString().ToLower());
            goto again;
        }

        public static bool IsMagic(string[] inputLine)
        {
            var firstWord = inputLine[0].Distinct().ToArray();
            var secondWord = inputLine[1].Distinct().ToArray();
            return firstWord.Length==secondWord.Length;
            //var shorterString = firstWord.Length <= secondWord.Length ? firstWord.ToCharArray() : secondWord.ToCharArray();
            //var longerString = firstWord.Length > secondWord.Length ? firstWord.ToCharArray() : secondWord.ToCharArray();
            //Dictionary<char, char> mappedChars = new Dictionary<char, char>();

            //for (int i = 0; i < shorterString.Length; i++)
            //{
            //    var charFromShorterWord = shorterString[i];
            //    var charfromLongerWord = longerString[i];
            //    if (!mappedChars.ContainsKey(charFromShorterWord))
            //    {
            //        mappedChars.Add(charFromShorterWord, charfromLongerWord);
            //    }
            //    if (!mappedChars[charFromShorterWord].Equals(charfromLongerWord))
            //    {
            //        return false;
            //    }
            //}
            //for (int j = shorterString.Length; j < longerString.Length; j++)
            //{
            //    var charFromLongerWord = longerString[j];
            //    if (!mappedChars.ContainsValue(charFromLongerWord))
            //    {
            //        return false;
            //    }
            //}
            //return true;
        }
    }
}
