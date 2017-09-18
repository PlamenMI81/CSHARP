using System;

namespace problem65
{ //Максимален брой комбинации
    internal class Program
    {
        private static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxCombination = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = start; i <= end; i++)
            for (int j = start; j <= end; j++)
            {
                Console.Write($"<{i}-{j}>");
                counter++;
                if (counter == maxCombination)
                    return;
            }
        }
    }
}