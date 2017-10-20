using System;
using System.Collections.Generic;
using System.IO;

namespace _02_Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(@"Input.txt");
            var output = new List<string>();
            for (var index = 0; index < lines.Length; index++)
            {
                {
                    output.Add(lines[index]);
                }
            }
            for (var i = 0; i < output.Count; i++)
            {
                
                File.AppendAllText(@"Output.txt", $"{i+1}. {output[i]+Environment.NewLine}");
            }
        }
    }
}
