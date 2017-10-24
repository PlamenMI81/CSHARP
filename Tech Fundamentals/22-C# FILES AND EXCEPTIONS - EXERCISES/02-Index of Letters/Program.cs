using System;
using System.IO;
using System.Linq;

namespace _02_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] seq = File.ReadAllText(@"input.txt").ToArray();
            File.WriteAllText("output.txt", "");
            for (int i = 0; i < seq.Length; i++)
            {
                File.AppendAllText(@"output.txt", $"{seq[i]} -> {(int)seq[i] - 97}"+Environment.NewLine);
            }
        }
    }
}
