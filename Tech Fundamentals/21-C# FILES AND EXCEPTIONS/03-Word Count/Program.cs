using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03_Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText(@"Input.txt").ToLower()
                .Split(new char[] { ' ', ',', '-', '!', '?', '.' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var wordToCount = File.ReadAllText(@"words.txt").ToLower()
                .Split()
                .ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();
            foreach (var word in wordToCount)
            {
                words[word] = 0;
            }
            foreach (string s in input)
            {
                if (words.ContainsKey(s))
                {
                    words[s]++;
                }
            }
            File.WriteAllText("Output.txt", "");

            foreach (KeyValuePair<string, int> keyValuePair in words.OrderByDescending(x=>x.Value))
            {
                File.AppendAllText(@"Output.txt", $"{keyValuePair.Key} - {keyValuePair.Value + Environment.NewLine}");
            }
        }
    }
}
