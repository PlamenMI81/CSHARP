using System;
using System.Linq;

namespace _03_Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var banedWords = Console.ReadLine().Split(new string[] {", "},StringSplitOptions.RemoveEmptyEntries).ToArray();
            var text = Console.ReadLine();
            foreach (var banWord in banedWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord, new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
