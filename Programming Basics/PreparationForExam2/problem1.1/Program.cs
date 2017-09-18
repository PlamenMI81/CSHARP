using System;

namespace problem1._1
{ //Рибна борса
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal priceSkumriq = decimal.Parse(Console.ReadLine());
            decimal priceCaca = decimal.Parse(Console.ReadLine());
            decimal kgPalamud = decimal.Parse(Console.ReadLine());
            decimal kgSafrid = decimal.Parse(Console.ReadLine());
            decimal kgMidi = decimal.Parse(Console.ReadLine());
            decimal pricePalamud = priceSkumriq + priceSkumriq * 0.6m;
            decimal priceSafrid = priceCaca + priceCaca * 0.8m;
            decimal allSumFish = pricePalamud * kgPalamud + priceSafrid * kgSafrid + 7.50m * kgMidi;
            Console.WriteLine($"{allSumFish:f2}");
        }
    }
}