using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _08_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0.0;
            for (int i = 0; i < input.Length; i++)
            {
                sum = ManipulateString(input[i]) + sum;
            }
            Console.WriteLine($"{sum:f2}");
        }

        private static double ManipulateString(string currentString)
        {
            var positionInAlphabet = 0;
            var operationFirstLetter = 0.0;
            var operationLastLetter = 0.0;
            var firstLetterUpper = currentString[0];
            var lastLetterUpper = currentString[currentString.Length - 1];
            var numberBetwinLetters = double.Parse(currentString.Substring(1, currentString.Length - 2));
            if (char.IsUpper(firstLetterUpper))
            {
                positionInAlphabet = firstLetterUpper - 64;
                operationFirstLetter = numberBetwinLetters / positionInAlphabet;

            }
            else
            {
                positionInAlphabet = firstLetterUpper - 96;
                operationFirstLetter = numberBetwinLetters * positionInAlphabet;
            }

            if (char.IsUpper(lastLetterUpper))
            {
                positionInAlphabet = lastLetterUpper - 64;
                operationLastLetter = operationFirstLetter - positionInAlphabet;
            }
            else
            {
                positionInAlphabet = lastLetterUpper - 96;
                operationLastLetter = operationFirstLetter + positionInAlphabet;
            }
            return operationLastLetter;
        }
    }
}
