using System;

namespace problem04
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double rakiaLiters = 0.0;
            double rakiaDegrees = 0.0;
            double sumRakiaLiters = 0.0;
            double sumRakiaDegrees = 0.0;

            for (int i = 1; i <= days; i++)
            {
                rakiaLiters = double.Parse(Console.ReadLine());
                rakiaDegrees = double.Parse(Console.ReadLine());
                sumRakiaLiters += rakiaLiters;
                sumRakiaDegrees += rakiaLiters * rakiaDegrees;
            }

            double totalDegrees = sumRakiaDegrees / sumRakiaLiters;
            Console.WriteLine($"Liter: {sumRakiaLiters:f2}\n" +
                              $"Degrees: {totalDegrees:f2}");
            if (totalDegrees < 38)
                Console.WriteLine("Not good, you should baking!");
            else if (totalDegrees > 42)
                Console.WriteLine("Dilution with distilled water!");
            else
                Console.WriteLine("Super!");
        }
    }
}