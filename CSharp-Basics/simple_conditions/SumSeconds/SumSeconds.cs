using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int sek1 = int.Parse(Console.ReadLine());
            int sek2 = int.Parse(Console.ReadLine());
            int sek3 = int.Parse(Console.ReadLine());
            int allSeconds;

            allSeconds = sek1 + sek2 + sek3;
            if (allSeconds<60)
            {
                Console.WriteLine($"0:{allSeconds:00}");
            }
            else if (allSeconds<=119)
            {
                Console.WriteLine($"1:{allSeconds-60:00}");
            }
            else
            {
                Console.WriteLine($"2:{allSeconds-120:00}");
            }

        }
    }
}
