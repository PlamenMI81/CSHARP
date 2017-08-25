using System;

namespace problem3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int dancers = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string sezon = Console.ReadLine().ToLower();
            string place = Console.ReadLine().ToLower();
            double nagrada;
            double razhod = 0.0;
            if (place == "bulgaria")
            {
                nagrada = points * dancers;
            }
            else
            {
                nagrada = dancers * points;
                nagrada = nagrada + nagrada * 0.50;
            }
            if (sezon == "summer" && place == "bulgaria")
            {
                razhod = nagrada * 0.05 - razhod;
                nagrada = nagrada - razhod;
            }
            if (sezon == "summer" && place == "abroad")
            {
                razhod = nagrada * 0.10 - razhod;
                nagrada = nagrada - razhod;
            }
            if (sezon == "winter" && place == "bulgaria")
            {
                razhod = nagrada * 0.08 - razhod;
                nagrada = nagrada - razhod;
            }
            if (sezon == "winter" && place == "abroad")
            {
                razhod = nagrada * 0.15 - razhod;
                nagrada = nagrada - razhod;
            }
            double darenie = nagrada * 0.75;
            double ostanalaSuma = nagrada - darenie;
            double moneyPerDancer = ostanalaSuma / dancers;
            Console.WriteLine($"Charity - {darenie:f2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:f2}");
        }
    }
}