using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01_Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            var names = Console.ReadLine();
            MatchCollection matcedNames = Regex.Matches(names, patern);
            foreach (Match name in matcedNames)
            {
                Console.Write(name.Value+" ");
            }
            Console.WriteLine();
        }
    }
}
