using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double cuantity =double.Parse(Console.ReadLine());

            if (town=="Sofia")
            {
                if (product=="coffee")
                {
                    Console.WriteLine(cuantity*0.5);
                }
                else if (product=="water")
                {
                    Console.WriteLine(cuantity * 0.80);
                }
                else if (product=="beer")
                {
                    Console.WriteLine(cuantity * 1.20);

                }else if (product=="sweets")
                {
                    Console.WriteLine(cuantity * 1.45);

                }else if (product=="peanuts")
                {
                    Console.WriteLine(cuantity * 1.60);

                }
            }
            else if (town=="Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(cuantity * 0.40);
                }
                else if (product == "water")
                {
                    Console.WriteLine(cuantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(cuantity * 1.15);

                }
                else if (product == "sweets")
                {
                    Console.WriteLine(cuantity * 1.30);

                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(cuantity * 1.50);

                }
            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(cuantity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(cuantity * 0.70);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(cuantity * 1.10);

                }
                else if (product == "sweets")
                {
                    Console.WriteLine(cuantity * 1.35);

                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(cuantity * 1.55);

                }
            }

        }
    }
}
