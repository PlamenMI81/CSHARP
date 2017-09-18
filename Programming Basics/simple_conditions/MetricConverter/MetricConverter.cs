using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConverter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double inputToConvert = double.Parse(Console.ReadLine());
            string fromUnit = Console.ReadLine();
            string toUnit = Console.ReadLine();

            double mm = 1000;
            double sm = 100;
            double mi = 0.000621371192;
            double inch = 39.3700787;
            double km = 0.001;
            double ft = 3.2808399;
            double yd = 1.0936133;

            string strMm = "mm";
            string strSm = "cm";
            string strMi = "mi";
            string strIn = "in";
            string strKm = "km";
            string strFt = "ft";
            string strYd = "yd";
            string strM = "m";

            double inputToMeters = 0;

            #region fromUnit
            if (fromUnit == strMm)
            {
                inputToMeters = inputToConvert / mm;
            }
            else if (fromUnit == strSm)
            {
                inputToMeters = inputToConvert / sm;
            }
            else if (fromUnit == strMi)
            {
                inputToMeters = inputToConvert / mi;
            }
            else if (fromUnit == strIn)
            {
                inputToMeters = inputToConvert / inch;
            }
            else if (fromUnit == strIn)
            {
                inputToMeters = inputToConvert / inch;
            }
            else if (fromUnit == strKm)
            {
                inputToMeters = inputToConvert / km;
            }
            else if (fromUnit == strFt)
            {
                inputToMeters = inputToConvert / ft;
            }
            else if (fromUnit == strYd)
            {
                inputToMeters = inputToConvert / yd;
            }
            else if (fromUnit == strM)
            {
                inputToMeters = inputToConvert;
            }
            #endregion

            #region toUnit
            if (toUnit == strMm)
            {
                inputToMeters *= mm;
            }
            else if (toUnit == strSm)
            {
                inputToMeters *= sm;
            }
            else if (toUnit == strMi)
            {
                inputToMeters *= mi;
            }
            else if (toUnit == strIn)
            {
                inputToMeters *= inch;
            }
            else if (toUnit == strIn)
            {
                inputToMeters *= inch;
            }
            else if (toUnit == strKm)
            {
                inputToMeters *= km;
            }
            else if (toUnit == strFt)
            {
                inputToMeters *= ft;
            }
            else if (toUnit == strYd)
            {
                inputToMeters *= yd;
            }
            else if (toUnit == strM)
            {
                inputToMeters = inputToMeters;
            }
            #endregion

            double result = Math.Round(inputToMeters, 8);
            Console.WriteLine($"{result} {toUnit}");

        }
    }
}
