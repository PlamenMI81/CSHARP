using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int numberOfHolidays = int.Parse(Console.ReadLine());
            int weekendsInHomeTown = int.Parse(Console.ReadLine());
            double weekendsInSofia = 48 - weekendsInHomeTown;
            double saturdayGamesInSofia = weekendsInSofia * 3.0 / 4;
            double sundaygamesInHomeTown = weekendsInHomeTown;
            double holidayGamesInSofia = numberOfHolidays * 2.0 / 3;
            double allGames = saturdayGamesInSofia + sundaygamesInHomeTown + holidayGamesInSofia;

            if (year=="normal")
            {
                Console.WriteLine($"{Math.Floor(allGames)}");
            }
            else if (year=="leap")
            {
                allGames=allGames+(allGames*0.15);
                Console.WriteLine($"{Math.Floor(allGames)}");
            }
        }
    }
}
