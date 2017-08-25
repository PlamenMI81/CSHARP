using System;

namespace problem6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char firstBigLetter = char.Parse(Console.ReadLine().ToUpper());
            char secondSmallLetter = char.Parse(Console.ReadLine().ToLower());
            char thirdSmallLetter = char.Parse(Console.ReadLine().ToLower());
            char forthSmallLetter = char.Parse(Console.ReadLine().ToLower());
            int digit = int.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = 'A'; i <= firstBigLetter; i++)
            for (char j = 'a'; j <= secondSmallLetter; j++)
            for (char k = 'a'; k <= thirdSmallLetter; k++)
            for (char l = 'a'; l <= forthSmallLetter; l++)
            for (int m = 0; m <= digit; m++)
                counter++;
            Console.WriteLine(counter-1);
        }
    }
}