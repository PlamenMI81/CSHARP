using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int adults = int.Parse(Console.ReadLine());
            int junior = int.Parse(Console.ReadLine());
            double nights = double.Parse(Console.ReadLine());           
            string transportType = Console.ReadLine();
            double adultsMoney = 0.0;
            double juniorMoney = 0.0;
            double transportMoney = 0.0;
            double comision = 0.0;
            switch (transportType)
            {
                case "train":
                    
                    if (adults + junior>=50)
                    {
                        adultsMoney = (24.99 * 2)-((24.99*2)*0.5);          //50 % намаление от отиване и връщане
                        juniorMoney = (14.99 * 2) - ((14.99 * 2) * 0.5);    //50 % намаление от отиване и връщане
                    }
                    else
                    {
                        adultsMoney = 24.99 * 2;
                        juniorMoney = 14.99 * 2;
                    }
                    break;
                case "bus":
                    adultsMoney = 32.50 * 2;
                    juniorMoney = 28.50 * 2;

                    break;
                case "boat":
                    adultsMoney = 42.99 * 2;
                    juniorMoney = 39.99 * 2;
                    break;
                case "airplane":
                    adultsMoney = 70.0 * 2;
                    juniorMoney = 50.0 * 2;
                    break;
            }
            nights = nights * 82.99;
            transportMoney = (adults*adultsMoney) + (junior*juniorMoney) + nights;
            comision = transportMoney * 0.1;
            transportMoney = transportMoney + comision;
            Console.WriteLine($"{transportMoney:f2}");
        }
    }
}
