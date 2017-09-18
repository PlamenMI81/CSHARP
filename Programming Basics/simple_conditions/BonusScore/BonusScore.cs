using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());

            double bonusPoints = 0;


            if (numberInput > 1000)
            {
                bonusPoints =Math.Round( numberInput * 0.10,1);
            }
            else if (numberInput > 100)
            {
                bonusPoints = Math.Round( bonusPoints + (numberInput * 0.20),1);
            }
            else
            {
                bonusPoints = 5;
            }

            if (numberInput % 2 == 0)
            {
                bonusPoints = bonusPoints + 1;
            }
            if (numberInput % 10 == 5)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine($"{bonusPoints}");
            Console.WriteLine($"{numberInput+bonusPoints}");
            
        }
    }
}