using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {

            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var cart = int.Parse(Console.ReadLine());
            var brickOnOneCours = 0;
            var totalCourses = 0;
            brickOnOneCours = workers * cart;

            if (bricks % brickOnOneCours == 0)
            {
                totalCourses = bricks / brickOnOneCours;
            }
            else
            {
                totalCourses = bricks / brickOnOneCours + 1;
            }
            Console.WriteLine(totalCourses);
        }
    }
}
