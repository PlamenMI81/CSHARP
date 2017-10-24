using System;
using System.Collections.Generic;
using System.IO;

namespace _06_Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllLines(@"input.txt");
            File.Delete("output.txt");
            Dictionary<string, string> emailCollector = new Dictionary<string, string>();
            for (int i = 0; i < input.Length; i+=2)
            {
                if (input[i]=="stop" || input[i+1]=="stop")
                {
                    break;
                }
                var name = input[i];
                var mail = input[i + 1];
                if (mail.EndsWith(".uk") || mail.EndsWith("us"))
                {
                    continue;
                }
                var output = $"{name} -> {mail}" + Environment.NewLine;
                File.AppendAllText("output.txt", output);
            }
        }

    }
} 
