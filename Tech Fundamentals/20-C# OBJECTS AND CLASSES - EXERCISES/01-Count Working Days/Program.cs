using System;
using System.Globalization;
using System.Linq;

namespace _01_Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] nonWorkingDays =new DateTime[11];
            nonWorkingDays[0] = new DateTime(4, 01, 01);
            nonWorkingDays[1] = new DateTime(4, 03, 03);
            nonWorkingDays[2] = new DateTime(4, 05, 01);
            nonWorkingDays[3] = new DateTime(4, 05, 06);
            nonWorkingDays[4] = new DateTime(4, 05, 24);
            nonWorkingDays[5] = new DateTime(4, 09, 06);
            nonWorkingDays[6] = new DateTime(4, 09, 22);
            nonWorkingDays[7] = new DateTime(4, 11, 01);
            nonWorkingDays[8] = new DateTime(4, 12, 24);
            nonWorkingDays[9] = new DateTime(4, 12, 25);
            nonWorkingDays[10] = new DateTime(4, 12, 26);

            int workingDayCounter = 0;

            for (DateTime currDate = startDate; currDate <= endDate; currDate = currDate.AddDays(1))
            {
                DayOfWeek currentDayOfWeek = currDate.DayOfWeek;
                DateTime currentDate = new DateTime(4,currDate.Month, currDate.Day);
                if (!nonWorkingDays.Contains(currentDate) && !currentDayOfWeek.Equals(DayOfWeek.Saturday) && !currentDayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    workingDayCounter++;
                }
            }
            Console.WriteLine(workingDayCounter);
        }
    }
}
