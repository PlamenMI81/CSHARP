using System;

namespace _08_Greater_of_Two_Values
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string dataType = Console.ReadLine();

            if (dataType == "int")
            {
                int firstValue = int.Parse(Console.ReadLine());
                int secondValue = int.Parse(Console.ReadLine());
                int max = GetMax(firstValue, secondValue);
                Console.WriteLine(max);
            }
            else if (dataType == "char")
            {
                char firstValue = char.Parse(Console.ReadLine());
                char secondValue = char.Parse(Console.ReadLine());
                char max = GetMax(firstValue, secondValue);
                Console.WriteLine(max);
            }
            else if (dataType == "string")
            {
                string firstValue = Console.ReadLine();
                string secondValue = Console.ReadLine();
                string max = GetMax(firstValue, secondValue);
                Console.WriteLine(max);
            }
        }

        private static int GetMax(int firstValue, int secondValue)
        {
            if (firstValue >= secondValue)
                return firstValue;
            return secondValue;
        }

        private static char GetMax(char firstValue, char secondValue)
        {
            if (firstValue >= secondValue)
                return firstValue;
            return secondValue;
        }

        private static string GetMax(string firstValue, string secondValue)
        {
            if (firstValue.CompareTo(secondValue) >= 0)
                return firstValue;
            return secondValue;
        }
    }
}