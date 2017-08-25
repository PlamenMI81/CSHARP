using System;

namespace problem1
{ //Благотворителна кампания
    internal class Program
    {
        private static void Main(string[] args)
        {
            int campaignDays = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int gofrets = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());
            decimal sumPerDayCakes = cakes * 45m;
            decimal sumPerGofrets = gofrets * 5.8m;
            decimal sumPerPancakes = pancakes * 3.2m;
            decimal allSumPerDay = (sumPerDayCakes + sumPerGofrets + sumPerPancakes) * sladkari;
            decimal allSumForCampaign = allSumPerDay * campaignDays;
            decimal allSum = allSumForCampaign - allSumForCampaign * 0.125m;
            Console.WriteLine($"{allSum:f2}");
        }
    }
}