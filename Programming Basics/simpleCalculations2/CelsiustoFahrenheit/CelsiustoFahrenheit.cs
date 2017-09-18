using System;

namespace CelsiustoFahrenheit
{
    class CelsiustoFahrenheit
    {
        static void Main(string[] args)
        {
            double tempCels = double.Parse(Console.ReadLine());

            double tempFahr = tempCels * 1.8 + 32;
            Console.WriteLine(Math.Round(tempFahr,2));
            
        }
    }
}
