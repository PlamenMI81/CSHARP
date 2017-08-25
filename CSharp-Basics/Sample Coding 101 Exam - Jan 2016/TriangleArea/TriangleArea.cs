using System;
namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double a, h, s;
            
            if (x2 > x3)
            {
                a = x2 - x3;
            }
            else
            {
                a = x3 - x2;
            }
            if (y1>y3)
            {
                h = y1 - (y3);
            }
            else
            {
                h = y3 - (y1);
            }
            s = a * h / 2;
            Console.WriteLine(s);

        }
    }
}
