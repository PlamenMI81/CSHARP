    using System;
    using System.Collections.Generic;
    using System.Linq;

namespace _04_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine()
                .Split(new string[] {" ", ",", ",", "?", "!"}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> palindromes=new List<string>();
            //check is Palindrom
            foreach (var word in inputStr)
            {
                
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine(string.Join(", ",palindromes.Distinct().OrderBy(x=>x)));
        }

        private static bool IsPalindrome(string word)
        {
            char[] wordToChar = word.ToArray();
            //var firstChar = char.Parse(wordToChar[0]);
            //var lastChar = char.Parse(wordToChar[wordToChar.Length - 1]);
            for (var i = 0; i < word.Length/2; i++)
            {
                if ((wordToChar[i]) != (wordToChar[wordToChar.Length - 1-i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
