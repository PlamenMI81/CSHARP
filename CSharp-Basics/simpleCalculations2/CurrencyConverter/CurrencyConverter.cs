using System;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            string inputCurrency = Console.ReadLine();
            string outputCurrency = Console.ReadLine();
            decimal usd = 1.79549m;
            decimal eur = 1.95583m;
            decimal gbp = 2.53405m;


            if (inputCurrency == "BGN" && outputCurrency == "USD")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount / usd, 2), outputCurrency);
            }
            else if (inputCurrency == "BGN" && outputCurrency == "EUR")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount / eur, 2), outputCurrency);
            }
            else if (inputCurrency == "BGN" && outputCurrency == "GBP")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount / gbp, 2), outputCurrency);
            }


            if (inputCurrency == "USD" && outputCurrency == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount * usd, 2), outputCurrency);
            }
            else if (inputCurrency == "EUR" && outputCurrency == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount * eur, 2), outputCurrency);
            }
            else if (inputCurrency == "GBP" && outputCurrency == "BGN")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount * gbp, 2), outputCurrency);
            }


            if (inputCurrency == "USD" && outputCurrency == "EUR")
            {
                Console.WriteLine("{0} {1}", Math.Round(amount * usd / eur, 2), outputCurrency);
            }
            if (inputCurrency == "USD" && outputCurrency == "GBP")
            {                
                Console.WriteLine("{0} {1}", Math.Round( amount * usd/ gbp, 2), outputCurrency);
            }


            if (inputCurrency == "EUR" && outputCurrency == "USD")
            {                
                Console.WriteLine("{0} {1}", Math.Round(amount * eur / usd, 2), outputCurrency);
            }
            else if (inputCurrency == "EUR" && outputCurrency == "GBP")
            {                
                Console.WriteLine("{0} {1}", Math.Round(amount * eur / gbp, 2), outputCurrency);
            }


            if (inputCurrency == "GBP" && outputCurrency == "USD")
            {                
                Console.WriteLine("{0} {1}", Math.Round(amount * gbp / usd, 2), outputCurrency);
            }
            else if (inputCurrency == "GBP" && outputCurrency == "EUR")
            {                
                Console.WriteLine("{0} {1}", Math.Round(amount * eur / eur, 2), outputCurrency);
            }
        }
    }
}
