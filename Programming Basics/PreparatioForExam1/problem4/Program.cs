using System;

namespace problem4
{ //Lilly
    class Program
    {
        static void Main(string[] args)
        {
            int liliAge = int.Parse(Console.ReadLine());
            double peralnqPrice = double.Parse(Console.ReadLine());
            double pricePerToy = double.Parse(Console.ReadLine());
            int countToy = 0;
            int countMoney = 0;
            double money = 0;
            for (int i = 1; i <= liliAge; i++)
            {
                if (i % 2 != 0)
                {
                    countToy++;
                }
                else
                {
                    money = money + 10 * (i / 2);
                    countMoney++;
                }
            }
            double soldToysMoney = countToy * pricePerToy;
            money = money + soldToysMoney - countMoney;
            if (money >= peralnqPrice)
            {
                Console.WriteLine($"Yes! {money - peralnqPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {peralnqPrice - money:f2}");
            }
        }
    }
}