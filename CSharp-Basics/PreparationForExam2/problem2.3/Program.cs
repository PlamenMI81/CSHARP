using System;

namespace problem2._3
{ //Change Tiles
    internal class Program
    {
        private static void Main(string[] args)
        {
            double colectedMoney = double.Parse(Console.ReadLine());
            double widthFloor = double.Parse(Console.ReadLine());
            double lengthFloor = double.Parse(Console.ReadLine());
            double sideOfTriangle = double.Parse(Console.ReadLine());
            double heightOfTriangle = double.Parse(Console.ReadLine());
            double priceOfTile = double.Parse(Console.ReadLine());
            double sumMajstor = double.Parse(Console.ReadLine());

            double areaFloor = widthFloor * lengthFloor;
            double areaTile = sideOfTriangle * heightOfTriangle / 2;
            double neededTiles = Math.Ceiling(areaFloor / areaTile) + 5;
            double allSum = neededTiles * priceOfTile + sumMajstor;
            if (allSum <= colectedMoney)
                Console.WriteLine($"{colectedMoney - allSum:f2} lv left.");
            else
                Console.WriteLine($"You'll need {allSum - colectedMoney:f2} lv more.");
        }
    }
}