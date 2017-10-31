using System;

namespace _01_Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cashAmmount =decimal.Parse(Console.ReadLine());
            int numGuests =int.Parse(Console.ReadLine());
            double priceBananaPerSet = double.Parse(Console.ReadLine())*2;
            double priceEggsPerSet = double.Parse(Console.ReadLine())*4;
            double priceBeriesPerSet = double.Parse(Console.ReadLine())*0.2;
            int setsOfPortion = (int)Math.Ceiling(numGuests / 6.0);
            double neededBananas = setsOfPortion *priceBananaPerSet;
            double neededEggs = setsOfPortion *priceEggsPerSet;
            double neededBeries = setsOfPortion * priceBeriesPerSet;
            var allPrice = neededBananas + neededEggs + neededBeries;
            if ((decimal)allPrice<=cashAmmount)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {allPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(decimal)allPrice-cashAmmount:f2}lv more.");
            }

        }
    }
}
