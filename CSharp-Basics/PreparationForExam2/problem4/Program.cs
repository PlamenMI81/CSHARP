using System;

namespace problem4
{ //Парична награда
    internal class Program
    {
        private static void Main(string[] args)
        {
            int piecesOfProject = int.Parse(Console.ReadLine());
            decimal pricePerPoint = decimal.Parse(Console.ReadLine());
            decimal sumPoints = 0;
            for (int i = 1; i <= piecesOfProject; i++)
            {
                int points = 0;
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{i} (x2): ");
                    Console.ResetColor();
                    points = int.Parse(Console.ReadLine());
                    points = points * 2;
                }
                else
                {
                    Console.Write($"{i}: ");
                    points = int.Parse(Console.ReadLine());
                }
                sumPoints = sumPoints + points;
            }
            sumPoints = sumPoints * pricePerPoint;
            Console.WriteLine($"The project prize was {sumPoints:f2} lv.");
        }
    }
}