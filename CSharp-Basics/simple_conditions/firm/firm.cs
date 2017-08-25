using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firm
{
    class firm
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int neededDays = int.Parse(Console.ReadLine());
            int workEmployeeDopylnitelno = int.Parse(Console.ReadLine());

            double workDays = neededDays - (neededDays * 0.1);
            double workHours = workDays * 8;
            double employeeDop = workEmployeeDopylnitelno * (2 * neededDays);
            double totallHour = Math.Floor(workHours + employeeDop);

            if (totallHour >= neededHours)
            {
                Console.WriteLine($"Yes!{totallHour - neededHours} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{Math.Abs(totallHour - neededHours)} hours needed.");
            }
        }
    }
}
