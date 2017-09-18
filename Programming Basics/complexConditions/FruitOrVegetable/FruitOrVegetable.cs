using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitOrVegetable
{
    class FruitOrVegetable
    {
        static void Main(string[] args)
        {

            string product = Console.ReadLine();

            if (product=="banana" || product=="apple")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "kiwi" || product == "cherry")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "lemon" || product == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (product == "tomato" || product == "cucumber")
            {
                Console.WriteLine("vegetable");
            }
            else if (product == "pepper" || product == "carrot")
            {
                Console.WriteLine("vegetable");
            }

            else
            {
                Console.WriteLine("unknown");
            }
            
           

            
        }
    }
}
