using System;

namespace vegetableBorsa
{
    class vegetableBorsa
    {
        static void Main(string[] args)
        {
            Console.Write("Цена за кг зеленчуци: ");
            double priceVegetables = double.Parse(Console.ReadLine());

            Console.Write("Цена за кг плодове: ");
            double priceFruits = double.Parse(Console.ReadLine());

            Console.Write("Общо кг зеленчуци: ");
            double totallVegetablesKg = double.Parse(Console.ReadLine());

            Console.Write("Общо кг плодове: ");
            double totallFruitsKg = double.Parse(Console.ReadLine());

            double totallVegetables = totallVegetablesKg * priceVegetables;
            double totalFruits = totallFruitsKg * priceFruits;

            double sumVegetablesFruits = totallVegetables + totalFruits;
            double sumVegFruitsEUR = sumVegetablesFruits / 1.94;

            Console.WriteLine($"Сумата в ЕВРО е: {sumVegFruitsEUR:f2}.");            
        }
    }
}
