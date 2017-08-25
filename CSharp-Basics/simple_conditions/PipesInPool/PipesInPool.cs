using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipesInPool
{
    class PipesInPool
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double VinTheMoment = (p1 + p2) * h;


            if (VinTheMoment <= v)
            {
                double percent = (VinTheMoment / v) * 100;
                double p1Percent = ((p1 * h) / VinTheMoment) * 100;
                double p2Percent = ((p2 * h) / VinTheMoment) * 100;
                Console.WriteLine($"The pool is {(int)percent}% full. Pipe 1: {(int)p1Percent}%. Pipe 2: {(int)p2Percent}%.");
            }
            else if (VinTheMoment>v)
            {
                double overFlow = VinTheMoment - v;
                Console.WriteLine($"For {h} hours the pool overflows with {overFlow:f1} liters.");
            }
        }
    }
}
