using System;

namespace _10_Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side =double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "face": CalcFaceOfCube(side);break;
                case "space": CalcSpceOfCube(side);break;
                case "volume": CalcVolumeOfCube(side);break;
                case "area": CalcAreaOfCube(side);break;
            }
        }

        private static void CalcAreaOfCube(double side)
        {
            double area = 6 * Math.Pow(side, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void CalcVolumeOfCube(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:f2}");
        }

        private static void CalcSpceOfCube(double side)
        {
            double spaceDiagonal= Math.Sqrt(3*Math.Pow(side, 2));
            Console.WriteLine($"{spaceDiagonal:f2}");
        }

        private static void CalcFaceOfCube(double side)
        {
            double faceDiagonal = Math.Sqrt(2*Math.Pow(side, 2));
            Console.WriteLine($"{faceDiagonal:f2}");
            
        }
    }
}
