using System;
using System.Text.RegularExpressions;

namespace _03_Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            Regex didimon = new Regex(@"[^a-zA-Z-]+");
            Regex bojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");
            Match match;
            string matchedText = "";
            int matchIndex = 0;
            while (true)
            {
                match = didimon.Match(input,matchIndex);
                if (match.Success)
                {
                    matchedText = match.Value;
                    matchIndex = match.Index+matchedText.Length;
                    Console.WriteLine($"{matchedText}");
                }
                else
                {
                    break;
                }

                match = bojomon.Match(input,matchIndex);
                if (match.Success)
                {
                    matchedText = match.Value;
                    matchIndex = match.Index+matchedText.Length;
                    Console.WriteLine($"{matchedText}");
                }
                else
                {
                    break;
                }
            }
        }
    }
}