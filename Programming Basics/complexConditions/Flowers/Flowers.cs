using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int lale = int.Parse(Console.ReadLine());
            string sezon = Console.ReadLine().ToLower();
            string isPraznik = Console.ReadLine().ToUpper();
            int buket = 0;
            double priceHrizantemi = 0.0;
            double priceRose = 0.0;
            double priceLale = 0.0;
            double buketPrice = 0.0;

            switch (sezon)
            {
                case "spring":
                case "summer":
                    priceHrizantemi = 2.0;
                    priceRose = 4.1;
                    priceLale = 2.5;
                    break;
                case "autumn":
                case "winter":
                    priceHrizantemi = 3.75;
                    priceRose = 4.5;
                    priceLale = 4.15;
                    break;
            }
            if (isPraznik == "Y")
            {
                priceHrizantemi += (priceHrizantemi * 0.15);
                priceRose += (priceRose * 0.15);
                priceLale += (priceLale * 0.15);
            }
            buketPrice = (priceHrizantemi*hrizantemi) + (priceRose*rose) + (priceLale*lale) ;
            buket = hrizantemi + rose + lale;

            if (lale > 7 && sezon == "spring")
            {
                buketPrice = buketPrice-(buketPrice * 0.05);
            }
            if (rose >= 10 && sezon == "winter")
            {
                buketPrice = buketPrice - (buketPrice * 0.1);
            }
            if (buket > 20)
            {
                buketPrice = buketPrice - (buketPrice * 0.2);
            }
            Console.WriteLine($"{buketPrice+2:f2}");
        }
    }
}
