using System;
using System.Text.RegularExpressions;

namespace PROBLEM3
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodedText = Console.ReadLine();
            var placeholders = Console.ReadLine();
            var pattern = @"([a-zA-Z]+)(.+)(\1)";
            var pattern2 = @"\{([\w+\s+]+)\}";
            Regex rg = new Regex(pattern);
            Regex rg2 = new Regex(pattern2);
            var match = rg.Matches(encodedText);
            var match2 = rg2.Matches(placeholders);

            var result = "";




            var i = 0;
            foreach (Match m in match)
            {
                //foreach (Match m2 in match2)
                //{

                var placeholderToReplace = m.Groups[2].ToString();
                var replacement = match2[i].Value.TrimStart('{').TrimEnd('}');
                encodedText = encodedText.Replace(placeholderToReplace, replacement);
                i++;
                //}
            }
            Console.WriteLine(encodedText);
        }
    }
}
