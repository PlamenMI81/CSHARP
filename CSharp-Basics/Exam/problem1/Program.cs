using System;

namespace problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double l = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double goleminaZala = l * 100 * (w * 100);
            double goleminaGarderob = a * 100 * (a * 100);
            double goleminaPejka = goleminaZala / 10;
            double freeArea = goleminaZala - goleminaGarderob - goleminaPejka;
            double dancers = freeArea / (40 + 7000);
            Console.WriteLine($"{Math.Floor(dancers)}");
        }
    }
}