using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            decimal fullArena = rows * cols;
            if (typeProjection=="premiere")
            {
                Console.WriteLine($"{fullArena*12.00m:f2}");
            }
            else if (typeProjection=="normal")
            {
                Console.WriteLine($"{fullArena * 7.50m:f2}");
            }
            else if (typeProjection=="discount")
            {
                Console.WriteLine($"{fullArena * 5.00m:f2}");

            }
        }
    }
}
