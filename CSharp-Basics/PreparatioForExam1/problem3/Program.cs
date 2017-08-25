using System;

namespace problem3
{ // Flower shop
    internal class Program
    {
        private static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int lale = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine().ToLower();
            string isPraznik = Console.ReadLine().ToLower();
            double priceHrizantemi = 0;
            double priceRozi = 0;
            double priceLale = 0;
            if (sezon == "spring" || sezon == "summer")
            {
                priceHrizantemi = hrizantemi * 2;
                priceRozi = rozi * 4.1;
                priceLale = lale * 2.5;
            }
            if (sezon == "autumn" || sezon == "winter")
            {
                priceHrizantemi = hrizantemi * 3.75;
                priceRozi = rozi * 4.50;
                priceLale = lale * 4.15;
            }
            if (isPraznik == "y")
            {
                priceHrizantemi = priceHrizantemi + priceHrizantemi * 0.15;
                priceRozi = priceRozi + priceRozi * 0.15;
                priceLale = priceLale + priceLale * 0.15;
            }
            double buketPrice = priceHrizantemi + priceRozi + priceLale;
            if (sezon == "spring" && lale > 7)
                buketPrice = buketPrice - buketPrice * 0.05;
            if (sezon == "winter" && rozi > 9)
                buketPrice = buketPrice - buketPrice * 0.10;
            if (hrizantemi + rozi + lale > 20)
                buketPrice = buketPrice - buketPrice * 0.20;
            Console.WriteLine($"{buketPrice + 2:f2}");
        }
    }
}