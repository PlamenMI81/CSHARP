using System;

namespace DailyEarnings
{
    class DailyEarnings
    {
        static void Main(string[] args)
        {
            var workDaysInMont=int.Parse(Console.ReadLine());
            var moneyOnDay = double.Parse(Console.ReadLine());
            var exchangeRateUsdToBgn = double.Parse(Console.ReadLine());

            var monthSalary = workDaysInMont * moneyOnDay;
            var yearSalary = monthSalary * 12 + monthSalary * 2.5;
            var tax = yearSalary * 0.25;
            var netYearSalaryInBgn = (yearSalary - tax)*exchangeRateUsdToBgn;
            var averageDaySalary = netYearSalaryInBgn / 365;
            Console.WriteLine("{0:f2}", averageDaySalary);


        }
    }
}
