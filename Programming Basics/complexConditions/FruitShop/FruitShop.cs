using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string dayOfweek = Console.ReadLine().ToLower();
            double quantity =double.Parse(Console.ReadLine());

            double price;

            switch (dayOfweek)
            {
                case "monday":
                case "tuesday":
                case "wednesday":
                case "thursday":
                case "friday":
                    if (fruit=="banana")
                    {
                        Console.WriteLine($"{price=quantity*2.50:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine($"{price = quantity * 1.20:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine($"{price=quantity* 0.85:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine($"{price = quantity * 1.45:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine($"{price = quantity * 2.70:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine($"{price = quantity * 5.50:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine($"{price = quantity * 3.85:f2}");
                    }
                    else
                        Console.WriteLine("error");
                    break;

                case "saturday":
                case "sunday":
                    if (fruit == "banana")
                    {
                        Console.WriteLine($"{price = quantity * 2.70:f2}");
                    }
                    else if (fruit == "apple")
                    {
                        Console.WriteLine($"{price = quantity * 1.25:f2}");
                    }
                    else if (fruit == "orange")
                    {
                        Console.WriteLine($"{price = quantity * 0.90:f2}");
                    }
                    else if (fruit == "grapefruit")
                    {
                        Console.WriteLine($"{price = quantity * 1.60:f2}");
                    }
                    else if (fruit == "kiwi")
                    {
                        Console.WriteLine($"{price = quantity * 3.00:f2}");
                    }
                    else if (fruit == "pineapple")
                    {
                        Console.WriteLine($"{price = quantity * 5.60:f2}");
                    }
                    else if (fruit == "grapes")
                    {
                        Console.WriteLine($"{price = quantity * 4.20:f2}");
                    }
                    else
                        Console.WriteLine("error");

                    break;
                    default: Console.WriteLine("error");
                    break;


            }
            

        }
    }
}
