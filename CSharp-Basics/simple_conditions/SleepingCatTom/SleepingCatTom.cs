using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SleepingCatTom
{
    class SleepingCatTom
    {
        static void Main(string[] args)
        {
            int daysOff =int.Parse(Console.ReadLine());
            int daysOn = 365 - daysOff;
            int timeForPlay = daysOff * 127 + daysOn * 63;
            int diff = (Math.Abs(timeForPlay-30000));
            int hours = diff / 60;
            int minutes = diff % 60;


            if (timeForPlay>30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else if (timeForPlay<30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }

        }
    }
}
