using System;

namespace _01_Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceBetweenTargets = int.Parse(Console.ReadLine());
            int exhautationFactor = int.Parse(Console.ReadLine());
            var pokedCount = 0;
            var fiftyPercentFrompower = pokePower / 2.0;
            while (pokePower >= distanceBetweenTargets)
            {
                pokePower = pokePower - distanceBetweenTargets;
                pokedCount++;
                if (pokePower == fiftyPercentFrompower && exhautationFactor != 0)
                {
                    pokePower = (int)(pokePower / exhautationFactor);
                }
            }
            Console.WriteLine($"{pokePower}");
            Console.WriteLine($"{pokedCount}");
        }
    }
}
