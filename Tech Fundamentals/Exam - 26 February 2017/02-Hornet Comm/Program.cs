using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            var patternPM = @"^(\d+) \<\-\> ([a-zA-Z0-9]+)$";
            var patternBroadcast = @"^(\D+) \<\-\> ([a-zA-Z0-9]+)$";
            List<string> outputPm = new List<string>();
            List<string> outputBr = new List<string>();
            Regex pm = new Regex(patternPM);
            Regex br = new Regex(patternBroadcast);
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Hornet is Green")
                {
                    break;
                }
                if (pm.IsMatch(input))
                {
                    var tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var code = tokens[0];
                    var message = tokens[1];
                    var reversedCode = new string(code.Reverse().ToArray());
                    var resultrString = $"{reversedCode} -> {message}";
                    outputPm.Add(resultrString);

                }
                if (br.IsMatch(input))
                {
                    var tokens = input.Split(new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    var message = tokens[0];
                    var frequence = tokens[1];
                    var newFreq = new string(frequence
                        .ToCharArray()
                        .Select(c =>
                        {
                            if (char.IsLower(c))
                            {
                                c = char.ToUpper(c);
                                return c;
                            }
                            c = char.ToLower(c);
                            return c;
                        })
                    .ToArray());
                    var resultrString = $"{newFreq} -> {message}";
                    outputBr.Add(resultrString);
                }
            }
            Console.WriteLine("Broadcasts:");
            Console.WriteLine(outputBr.Any() ? string.Join("\n", outputBr) : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(outputPm.Any() ? string.Join("\n", outputPm) : "None");
        }
    }
}
