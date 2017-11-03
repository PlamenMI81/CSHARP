using System;
using System.Runtime.InteropServices.ComTypes;
using System.Text.RegularExpressions;

namespace _02_Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputKeyword = Console.ReadLine().Trim();
            var text = Console.ReadLine();
            var pattern = $@"[a-zA-Z0-9-, ]+{inputKeyword},?(\s[a-zA-Z0-9- ]+[\.\!\?]|[\.\!\?])";
            MatchCollection sentences = Regex.Matches(text, pattern);
            foreach (Match sentence in sentences)
            {
                Console.WriteLine(sentence.Value.TrimStart().TrimEnd('.', '!'));
            }
        }
    }
}
