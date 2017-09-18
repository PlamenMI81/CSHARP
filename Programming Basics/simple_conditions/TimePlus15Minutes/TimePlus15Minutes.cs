using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Minutes
{
    class TimePlus15Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            if (minutes + 15 <= 59)
            {
                Console.WriteLine($"{hour}:{minutes+15:00}");
            }
            else if (minutes + 15 >= 60)
            {
                hour += 1;
                minutes =Math.Abs(minutes+15)- 60;

                if (hour>23)
                {
                    Console.WriteLine($"0:{minutes:00}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minutes:00}");
                }
                
            }
        }
    }
}
