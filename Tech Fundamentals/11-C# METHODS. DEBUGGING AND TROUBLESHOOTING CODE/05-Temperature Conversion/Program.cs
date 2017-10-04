using System;

namespace _05_Temperature_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempFahrenheit =double.Parse(Console.ReadLine());
            double celsius=ConvertFahrenheitToCelsius(tempFahrenheit);
            Console.WriteLine($"{celsius:f2}");
        }

        private static double ConvertFahrenheitToCelsius(double temperature)
        {
            return ((temperature-32)*5/9);

        }
    }
}
