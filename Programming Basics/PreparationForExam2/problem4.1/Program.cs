using System;

namespace problem4._1
{ //Логистика
    internal class Program
    {
        private static void Main(string[] args)
        {
            int broiTovari = int.Parse(Console.ReadLine());
            int tonaj;
            int tonajMikrobus = 0;
            int tonajKamion = 0;
            int tonajVlak = 0;
            for (int i = 1; i <= broiTovari; i++)
            {
                tonaj = int.Parse(Console.ReadLine());
                if (tonaj <= 3)
                    tonajMikrobus += tonaj;
                else if (tonaj > 3 && tonaj <= 11)
                    tonajKamion += tonaj;
                else
                    tonajVlak += tonaj;
            }
            decimal sumTonaj = tonajMikrobus + tonajKamion + tonajVlak;
            decimal averagePerTon = (tonajMikrobus * 200 + tonajKamion * 175 + tonajVlak * 120) / sumTonaj;
            Console.WriteLine($"{averagePerTon:f2}");
            Console.WriteLine($"{tonajMikrobus / sumTonaj * 100:f2}%");
            Console.WriteLine($"{tonajKamion / sumTonaj * 100:f2}%");
            Console.WriteLine($"{tonajVlak / sumTonaj * 100:f2}%");
        }
    }
}