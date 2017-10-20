using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _01_Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines=File.ReadAllLines(@"Input.txt");
            var output = new List<string>();
            for (var index = 0; index < lines.Length; index++)
            {
                if (index%2!=0)
                {
                    output.Add(lines[index]);
                }
            }
            foreach (var line in output)
            {
                File.AppendAllText(@"Output.txt", line+Environment.NewLine);
            }
        }
    }
}
