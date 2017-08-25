using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rekolta
{
    class rekolta
    {
        static void Main(string[] args)
        {
            int areaLoze =int.Parse(Console.ReadLine());
            double grape =double.Parse(Console.ReadLine());

            int needLitres =int.Parse(Console.ReadLine());
            int workers =int.Parse(Console.ReadLine());

            double allGrape=areaLoze*grape;
            double wine = 0.4 * allGrape / 2.5;
            double ostatak = Math.Abs(wine - needLitres);

            if (wine >= needLitres)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters. " +
                                  $"\n {Math.Ceiling(ostatak)} liters left -> {Math.Ceiling(ostatak/workers)} liters per person.");
            }
            else // (wine<needLitres)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(needLitres-wine)} liters wine needed.");
            }
        }
    }
}
