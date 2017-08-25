using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {

            int sideOfPlayground = int.Parse(Console.ReadLine());

            double widthOfTile = double.Parse(Console.ReadLine());
            double lenghtOfTile = double.Parse(Console.ReadLine());

            double widthOfBench = double.Parse(Console.ReadLine());
            double lenghtOfBench = double.Parse(Console.ReadLine());

            double sizeOfPlayground = Math.Pow(sideOfPlayground,2); 

            double sizeOfBench = widthOfBench * lenghtOfBench;
            double sizeOfTile = widthOfTile * lenghtOfTile;

            double areaToCover = sizeOfPlayground - sizeOfBench;
            double tiles = areaToCover / sizeOfTile;
            double time = tiles * 0.20;

            Console.WriteLine("{0:f2}", tiles);
            Console.WriteLine("{0:f2}", time);

        }
    }
}
