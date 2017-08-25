using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            double nasledstvoMoney = double.Parse(Console.ReadLine());
            int yearToLive = int.Parse(Console.ReadLine());
            int moneySpent = 0;
            int yearIndex = 17;
            int moneySpentEven = 0;
            int moneySpentOdd = 0;
            for (int i = 1800; i <= yearToLive; i++)
            {
                yearIndex = yearIndex+1;
                if (i%2==0)
                {
                    moneySpentEven = moneySpentEven + 12000;
                }
                else
                {
                    moneySpentOdd = (moneySpentOdd + 12000) + (50 * yearIndex);
                }
            }
            int allSpent = moneySpentEven + moneySpentOdd;
            if (allSpent<=nasledstvoMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {Math.Abs(allSpent-nasledstvoMoney):f2} dollars left.");
            }
            else
            {
                Console.WriteLine($"He will need {Math.Abs(allSpent-nasledstvoMoney):f2} dollars to survive.");
            }

        }
    }
}
