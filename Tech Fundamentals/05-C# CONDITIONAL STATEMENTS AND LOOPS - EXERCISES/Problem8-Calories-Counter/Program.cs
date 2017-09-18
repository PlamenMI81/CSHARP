using System;

namespace Problem8_Calories_Counter
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int ingrAmount = int.Parse(Console.ReadLine());
            int sumCalories = 0;
            for (int i = 1; i <= ingrAmount; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                int calories;
                if (ingredient == "cheese")
                    calories = 500;
                else if (ingredient == "tomato sauce")
                    calories = 150;
                else if (ingredient == "salami")
                    calories = 600;
                else if (ingredient == "pepper")
                    calories = 50;
                else
                    continue;
                sumCalories += calories;
            }
            Console.WriteLine($"Total calories: {sumCalories}");
        }
    }
}