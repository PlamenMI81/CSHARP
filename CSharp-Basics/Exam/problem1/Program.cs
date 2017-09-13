using System;

namespace problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double tableLenght = double.Parse(Console.ReadLine()); //daljina
            double tableWidth = double.Parse(Console.ReadLine()); //shiro4ina
            double allTableclothArea = tables * (tableLenght + 2 * 0.30) * (tableWidth + 2 * 0.30);
            double allKareArea = tables * (tableLenght / 2) * (tableLenght / 2);
            double priceInDolars = allTableclothArea * 7.00 + allKareArea * 9.00;
            double priceInLev = priceInDolars * 1.85;
            Console.WriteLine($"{priceInDolars:f2} USD\n{priceInLev:f2} BGN");
        }
    }
}