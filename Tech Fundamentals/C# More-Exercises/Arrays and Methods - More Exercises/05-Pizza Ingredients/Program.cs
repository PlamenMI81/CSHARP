using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split();
            List<string> aproovedIngredients=new List<string>();
            byte length =byte.Parse(Console.ReadLine());
            for (int index = 0; index < ingredients.Length; index++)
            {
                if (ingredients[index].Length==length)
                {
                    if (aproovedIngredients.Count < 10)
                    {
                        aproovedIngredients.Add(ingredients[index]);
                        Console.WriteLine($"Adding {ingredients[index]}.");
                    }
                    else
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {aproovedIngredients.Count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ",aproovedIngredients)}.");
        }
    }
}
