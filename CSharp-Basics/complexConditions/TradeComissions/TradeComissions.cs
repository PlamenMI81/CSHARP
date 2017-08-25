using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sellings = double.Parse(Console.ReadLine());
            double comission;
            if (sellings >= 0 && sellings <= 500)
            {
                switch (town)
                {
                    case "sofia":
                        comission = sellings * 0.05;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "varna":
                        comission = sellings * 0.045;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "plovdiv":
                        comission = sellings * 0.055;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sellings > 500 && sellings <= 1000)
            {
                switch (town)
                {
                    case "sofia":
                        comission = sellings * 0.07;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "varna":
                        comission = sellings * 0.075;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "plovdiv":
                        comission = sellings * 0.08;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sellings > 1000 && sellings <= 10000)
            {
                switch (town)
                {
                    case "sofia":
                        comission = sellings * 0.08;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "varna":
                        comission = sellings * 0.10;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "plovdiv":
                        comission = sellings * 0.12;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sellings>10000)
            {
                switch (town)
                {
                    case "sofia":
                        comission = sellings * 0.12;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "varna":
                        comission = sellings * 0.13;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    case "plovdiv":
                        comission = sellings * 0.145;
                        Console.WriteLine($"{comission:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
