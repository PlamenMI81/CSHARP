using System;
using System.Linq;

namespace _03_Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToCharArray();
            foreach (char c in inputString)
            {
                Console.Write($"\\u{(int)c:x4}");
            }
            Console.WriteLine();
        }
    }
}
