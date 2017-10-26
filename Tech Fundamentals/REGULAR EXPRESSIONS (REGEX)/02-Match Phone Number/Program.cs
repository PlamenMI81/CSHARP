using System;
using System.Text.RegularExpressions;

namespace _02_Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern1 = @"";
            string patern2=
            var names = Console.ReadLine();
            MatchCollection matcedNames = Regex.Matches(names, patern);
            foreach (Match name in matcedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
