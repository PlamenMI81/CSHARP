using System;

namespace Problem4_Beverage_Labels
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyPer100gr = int.Parse(Console.ReadLine());
            int sugarPer100gr = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:\n" +
                              $"{energyPer100gr * (volume / 100.0)}kcal, {sugarPer100gr * (volume / 100.0)}g sugars");
        }
    }
}