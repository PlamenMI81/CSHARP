using System;

namespace problem63
{ //Битки
    internal class Program
    {
        private static void Main(string[] args)
        {
            int firstPlayerPokemon = int.Parse(Console.ReadLine());
            int secondPlayerPokemon = int.Parse(Console.ReadLine());
            int maxBattles = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= firstPlayerPokemon; i++)
            for (int j = 1; j <= secondPlayerPokemon; j++)
            {
                counter++;
                if (counter <= maxBattles)
                    Console.Write($"({i} <-> {j}) ");
                else
                    return;
            }
        }
    }
}