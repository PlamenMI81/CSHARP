using System;
using System.Linq;

namespace _05_Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine().ToLower()
                .Split(new char[] {'.',',',':',';','(',')','[',']','\"','\'','\\','/','!','?',' '}, StringSplitOptions.RemoveEmptyEntries)
                .Distinct().ToArray();
            var result = inputText.Where(word => word.Length<5).OrderBy(word=>word);
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
