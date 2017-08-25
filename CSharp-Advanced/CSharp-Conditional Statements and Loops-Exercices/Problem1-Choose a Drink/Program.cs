using System;

namespace Problem1_ChooseaDrink
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string profession = Console.ReadLine().ToLower();
            string drink;
            switch (profession)
            {
                case "athlete":
                    drink = "Water";
                    break;
                case "businessman":
                case "businesswoman":
                    drink = "Coffee";
                    break;
                case "softuni student":
                    drink = "Beer";
                    break;
                default:
                    drink = "Tea";
                    break;
            }
            Console.WriteLine(drink);
        }
    }
}