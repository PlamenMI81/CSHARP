using System;

namespace problem4._3
{ //Football League
    internal class Program
    {
        private static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int fens = int.Parse(Console.ReadLine());
            double countA = 0;
            double countB = 0;
            double countV = 0;
            double countG = 0;
            for (int i = 1; i <= fens; i++)
            {
                string fenSector = Console.ReadLine().ToLower();
                switch (fenSector)
                {
                    case "a": countA++; break;
                    case "b": countB++; break;
                    case "v": countV++; break;
                    case "g": countG++; break;
                }
            }
            Console.WriteLine($"{countA / fens * 100:f2}%");
            Console.WriteLine($"{countB / fens * 100:f2}%");
            Console.WriteLine($"{countV / fens * 100:f2}%");
            Console.WriteLine($"{countG / fens * 100:f2}%");
            Console.WriteLine($"{(double)fens / stadiumCapacity * 100:f2}%");
        }
    }
}