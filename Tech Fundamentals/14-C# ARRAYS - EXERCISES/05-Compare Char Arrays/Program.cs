using System;
using System.Linq;

namespace _05_Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] first = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] second = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int shortestArr = 0;
            shortestArr = first.Length<=second.Length ? first.Length : second.Length;
            string stringResult=string.Empty;
            bool isEqual = false;
            for (int i = 0; i < shortestArr; i++)
            {
                isEqual = false;
                if (first[i]<second[i])
                {
                    stringResult = $"{string.Join("",first)}\r\n{string.Join("",second)}";
                }else if (first[i] > second[i])
                {
                    stringResult = $"{string.Join("", second)}\r\n{string.Join("", first)}";
                }else if (first[i]==second[i])
                {
                    isEqual = true;
                }
            }
            if (isEqual)
            {
                stringResult = first.Length<=second.Length 
                    ? $"{string.Join("", first)}\r\n{string.Join("", second)}" 
                    : $"{string.Join("", second)}\r\n{string.Join("", first)}";
            }
            Console.WriteLine(stringResult);
        }
    }
}
