using System;

namespace Problem5_Character_Stats
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHelth = int.Parse(Console.ReadLine());
            int maxHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}\n" +
                              $"Health: |{new string('|', currentHelth)}{new string('.', maxHealth - currentHelth)}|\n" +
                              $"Energy: |{new string('|', currentEnergy)}{new string('.', maxEnergy - currentEnergy)}|");
        }
    }
}