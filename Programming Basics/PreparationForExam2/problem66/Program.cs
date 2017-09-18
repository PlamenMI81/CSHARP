using System;

namespace problem66
{ //Letters Combinations
    internal class Program
    {
        private static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char missedLetter = char.Parse(Console.ReadLine());
            int count = 0;
            for (char i = startLetter; i <= endLetter; i++)
            for (char j = startLetter; j <= endLetter; j++)
            for (char k = startLetter; k <= endLetter; k++)
                if (k == missedLetter || j == missedLetter || i == missedLetter)
                {
                }
                else
                {
                    Console.Write($"{i}{j}{k} ");
                    count++;
                }
            Console.WriteLine(count);
        }
    }
}