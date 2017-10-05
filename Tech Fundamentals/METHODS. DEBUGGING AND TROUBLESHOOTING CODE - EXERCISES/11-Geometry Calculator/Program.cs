using System;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "triangle": AreaOfTriangle();break;
                case "square": AreaOfSquare();break;
                case "rectangle": AreaOfRectangle();break;
                case "circle": AreaOfCircle();break;
            }
        }

        private static void AreaOfCircle()
        {
            double radius =double.Parse(Console.ReadLine());
            double area=Math.PI*(radius*radius);
            Console.WriteLine($"{area:f2}");
        }

        private static void AreaOfRectangle()
        {
            double width =double.Parse(Console.ReadLine());
            double height =double.Parse(Console.ReadLine());
            double area = width * height;
            Console.WriteLine($"{area:f2}");
        }

        private static void AreaOfSquare()
        {
            double side =double.Parse(Console.ReadLine());
            double area = side * side;
            Console.WriteLine($"{area:f2}");
        }

        private static void AreaOfTriangle()
        {
            double side =double.Parse(Console.ReadLine());
            double height =double.Parse(Console.ReadLine());
            double area = (side * height) / 2.0;
            Console.WriteLine($"{area:f2}");
        }
    }
}
