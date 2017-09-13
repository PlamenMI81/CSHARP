using System;

namespace problem4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakePieces = cakeLenght * cakeWidth;
            int piecesTakenInt;
            string cake = null;
            for (int currentPiece = cakePieces; currentPiece >= 0; currentPiece -= piecesTakenInt)
            {
                string piecesTaken = Console.ReadLine();
                if (piecesTaken == "STOP")
                {
                    Console.WriteLine($"{currentPiece} pieces are left.");
                    return;
                }
                piecesTakenInt = int.Parse(piecesTaken);
                cake = $"No more cake left! You need {Math.Abs(currentPiece - piecesTakenInt)} pieces more.";
            }
            Console.WriteLine(cake);
        }
    }
}