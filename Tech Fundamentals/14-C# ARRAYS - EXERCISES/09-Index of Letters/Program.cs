using System;
using System.Linq;

namespace _09_Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] seq = Console.ReadLine().ToArray();
            for (int i = 0; i < seq.Length; i++)
            {
                Console.WriteLine($"{seq[i]} -> {(int)seq[i]-97}");
            }
        }
    }
}
