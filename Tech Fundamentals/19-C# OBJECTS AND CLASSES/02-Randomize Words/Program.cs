using System;
using System.Linq;

namespace _02_Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            RandomizeInput(input);
        }

        private static void RandomizeInput(string[] input)
        {
            Random rand=new Random();
            for (int i = 0; i < input.Length; i++)
            {
                int firstWord = rand.Next(0, input.Length);
                int secondWord = rand.Next(0, input.Length);

                string changer = input[firstWord];
                input[firstWord] = input[secondWord];
                input[secondWord] = changer;
            }
            Console.WriteLine(string.Join(Environment.NewLine,input));
        }
    }
}
