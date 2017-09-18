using System;

namespace problem2._1
{ //Домашни любимци
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double dogFoodPerDay = double.Parse(Console.ReadLine());
            double catFoodPerDay = double.Parse(Console.ReadLine());
            double turtleFoodPerDay = double.Parse(Console.ReadLine()) / 1000;
            double dogNeededFood = days * dogFoodPerDay;
            double catNeededFood = days * catFoodPerDay;
            double turtleNeededFood = days * turtleFoodPerDay;
            double allNeededFod = dogNeededFood + catNeededFood + turtleNeededFood;
            if (allNeededFod <= food)
                Console.WriteLine($"{Math.Floor(food - allNeededFod)} kilos of food left.");
            else
                Console.WriteLine($"{Math.Ceiling(allNeededFod - food)} more kilos of food are needed.");
        }
    }
}