using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyroom
{
    class studyroom
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());

            double lengthInCentimeters = length * 100;
            double widthInCentimetres = width * 100;

            int cols = ((int)widthInCentimetres - 100 )/ 70;
            int rows = (int)lengthInCentimeters / 120;
            int seats = (rows * cols) - 3;
            Console.WriteLine("Брой места:" +seats);
        }
    }
}
