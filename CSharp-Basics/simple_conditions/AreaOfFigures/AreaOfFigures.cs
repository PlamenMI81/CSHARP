using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string typeOfFigure = Console.ReadLine();

            if (typeOfFigure == "square")
            {
                double side =double.Parse(Console.ReadLine());
                double faceOfSquare = side * side;
                Console.WriteLine(Math.Round(faceOfSquare,3));
            }
            else if (typeOfFigure=="rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double faceOfRectangle = side1 * side2;
                Console.WriteLine(Math.Round(faceOfRectangle, 3));
            }
            else if (typeOfFigure=="circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double faceOfCircle = Math.PI*Math.Pow(radius,2);
                Console.WriteLine(Math.Round(faceOfCircle, 3));
            }
            else if (typeOfFigure=="triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double faceOfTriangle = side*height/2;
                Console.WriteLine(Math.Round(faceOfTriangle, 3));
            }
        }
    }
}
