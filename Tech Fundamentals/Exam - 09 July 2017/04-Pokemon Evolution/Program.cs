using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_Pokemon_Evolution
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<Pokemon>> pokemonData = new Dictionary<string, List<Pokemon>>();
            while (true)
            {
                var input = Console.ReadLine()
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (input[0].Contains("wubbalubbadubdub"))
                {
                    break;
                }
                if (input.Length>1)
                {
                    string pokeName = input[0].Trim();
                    string evoType = input[1].Trim();
                    int evoInd = int.Parse(input[2].Trim());

                    Pokemon currPokemonData = new Pokemon
                    {
                        EvolutionType = evoType,
                        EvolutionIndex = evoInd
                    };

                    if (!pokemonData.ContainsKey(pokeName))
                    {
                        pokemonData.Add(pokeName, new List<Pokemon>());
                        pokemonData[pokeName].Add(currPokemonData);
                    }
                    else
                    {
                        pokemonData[pokeName].Add(currPokemonData);
                    }
                }
                else
                {
                    string pokeName = input[0].Trim();
                    if (pokemonData.ContainsKey(pokeName))
                    {
                        Console.WriteLine($"# {pokeName}");
                        foreach (var pokemon in pokemonData[pokeName])
                        {
                            Console.WriteLine($"{pokemon.EvolutionType} <-> {pokemon.EvolutionIndex}");
                        }
                    }
                }
            }
            foreach (var kvp in pokemonData)
            {
                Console.WriteLine($"# {kvp.Key}");
                foreach (var x in kvp.Value.OrderByDescending(x=>x.EvolutionIndex))
                {
                    Console.WriteLine($"{x.EvolutionType} <-> {x.EvolutionIndex}");
                }
            }
        }
    }

    class Pokemon
    {
        public string EvolutionType { get; set; }
        public int EvolutionIndex { get; set; }

    }
}
