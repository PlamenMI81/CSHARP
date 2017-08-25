using System;

namespace problem4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int broiTrenirovachniDni = int.Parse(Console.ReadLine());
            int broiDancers = int.Parse(Console.ReadLine());
            double sumE1 = 0.0;
            double sumE2 = 0.0;
            double sumE3 = 0.0;
            double sumE4 = 0.0;
            for (int i = 1; i <= broiTrenirovachniDni; i++)
            {
                int chasove = int.Parse(Console.ReadLine());
                if (i % 2 == 0 && chasove % 2 == 0)
                {
                    double energy1 = broiDancers * 68;
                    sumE1 += energy1;
                }
                else if (i % 2 != 0 && chasove % 2 == 0)
                {
                    double energy2 = broiDancers * 49;
                    sumE2 += energy2;
                }
                else if (i % 2 == 0 && chasove % 2 != 0)
                {
                    double energy3 = broiDancers * 65;
                    sumE3 += energy3;
                }
                else if (i % 2 != 0 && chasove % 2 != 0)
                {
                    double energy4 = broiDancers * 30;
                    sumE4 += energy4;
                }
            }
            double allEnergy = 100 * broiDancers * broiTrenirovachniDni;
            double neizhabenaEnergy = allEnergy - (sumE1 + sumE2 + sumE3 + sumE4);
            double neizhabenaEnergiPerdancer = neizhabenaEnergy / broiDancers / broiTrenirovachniDni;
            double sredenRazhod = 100 - neizhabenaEnergiPerdancer;
            if (sredenRazhod >= 50)
                Console.WriteLine($"They are wasted! Energy left: {neizhabenaEnergiPerdancer:f2}");
            else
                Console.WriteLine($"They feel good! Energy left: {neizhabenaEnergiPerdancer:f2}");
        }
    }
}