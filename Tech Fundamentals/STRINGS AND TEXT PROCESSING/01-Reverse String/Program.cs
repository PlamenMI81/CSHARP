using System;
using System.Linq;

namespace _01_Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine().Reverse().ToArray();
            //var reversedstring=word.Reverse().ToString();
            Console.WriteLine(word);
        }
    }
}
