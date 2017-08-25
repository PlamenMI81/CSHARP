using System;

namespace ticketForMach_another
{
    class ticketForMach_another
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int peopleIngroup = int.Parse(Console.ReadLine());
            double moneyForTransport;
            double leavedMoney;
            double moneyForTickets;
            if (peopleIngroup >= 1 && peopleIngroup <= 4)
            {
                moneyForTransport = budget * 0.75;
                leavedMoney = budget - moneyForTransport;
            }
            else if (peopleIngroup >= 5 && peopleIngroup <= 9)
            {
                moneyForTransport = budget * 0.60;
                leavedMoney = budget - moneyForTransport;
            }
            else if (peopleIngroup >= 10 && peopleIngroup <= 24)
            {
                moneyForTransport = budget * 0.50;
                leavedMoney = budget - moneyForTransport;
            }
            else if (peopleIngroup >= 25 && peopleIngroup <= 49)
            {
                moneyForTransport = budget * 0.40;
                leavedMoney = budget - moneyForTransport;
            }
            else
            {
                moneyForTransport = budget * 0.25;
                leavedMoney = budget - moneyForTransport;
            }
            if (category == "vip")
            {
                moneyForTickets = 499.99 * peopleIngroup;
                if (moneyForTickets <= leavedMoney)
                {
                    Console.WriteLine($"Yes! You have {leavedMoney - moneyForTickets:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {moneyForTickets - leavedMoney:f2} leva.");
                }
            }
            else
            {
                moneyForTickets = 249.99 * peopleIngroup;
                if (moneyForTickets <= leavedMoney)
                {
                    Console.WriteLine($"Yes! You have {leavedMoney - moneyForTickets:f2} leva left.");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {moneyForTickets - leavedMoney:f2} leva.");
                }
            }
        }
    }
}
