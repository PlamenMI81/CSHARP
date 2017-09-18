using System;

namespace problem2._2
{ //Магазин за цветя
    internal class Program
    {
        private static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            decimal priceGift = decimal.Parse(Console.ReadLine());
            decimal priceMagnolii = 3.25m;
            decimal priceRozi = 3.5m;
            decimal priceZumbuli = 4.0m;
            decimal priceKaktusi = 8.0m;
            decimal porachka = magnolii * priceMagnolii + zumbuli * priceZumbuli + rozi * priceRozi +
                               kaktusi * priceKaktusi;
            porachka -= porachka * 0.05m;
            if (porachka >= priceGift)
                Console.WriteLine($"She is left with {Math.Floor(porachka - priceGift)} leva.");
            else
                Console.WriteLine($"She will have to borrow {Math.Ceiling(priceGift - porachka)} leva.");
        }
    }
}