using System;
using System.Linq;

namespace _06_Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var jewelPrice = prices[0];
            var goldprice = prices[1];
            string heistInfoStr = Console.ReadLine();
            var totalearning = 0.0;
            while (heistInfoStr != "Jail Time")
            {
                CalcCurrenEarning(jewelPrice, goldprice, heistInfoStr, ref totalearning);
                heistInfoStr = Console.ReadLine();
            }
           // Console.WriteLine(new string('-',50));
            if (totalearning>=0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalearning}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {Math.Abs(totalearning)}.");
            }
        }

        private static void CalcCurrenEarning(int jewelPrice, int goldprice, string heistInfoStr, ref double totalearning)
        {
            var heistInfo = heistInfoStr.Split().ToArray();
            char[] heistLoot = heistInfo[0].ToCharArray();
            var heistExpences = double.Parse(heistInfo[1]);
            var countJewel = 0;
            var countGold = 0;
            foreach (char c in heistLoot)
            {
                if (c.Equals('%'))
                {
                    countJewel++;

                }
                else if (c.Equals('$'))
                {
                    countGold++;
                }
            }
            totalearning += countJewel * jewelPrice + countGold * goldprice - heistExpences;
        }
    }
}
