using System;

namespace problem3._1
{ //Велосъстезание
    internal class Program
    {
        private static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine().ToLower();
            decimal taxJ = 0m;
            decimal taxS = 0m;
            switch (trace)
            {
                case "trail":
                    taxJ = 5.5m;
                    taxS = 7.0m;
                    break;
                case "cross-country":
                    taxJ = 8.0m;
                    taxS = 9.5m;
                    if (juniors + seniors >= 50)
                    {
                        taxJ -= taxJ * 0.25m;
                        taxS -= taxS * 0.25m;
                    }
                    break;
                case "downhill":
                    taxJ = 12.25m;
                    taxS = 13.75m;
                    break;
                case "road":
                    taxJ = 20.0m;
                    taxS = 21.5m;
                    break;
            }
            decimal collectedSum = juniors * taxJ + seniors * taxS;
            decimal razhod = 0.05m;
            collectedSum -= collectedSum * razhod;
            Console.WriteLine($"{collectedSum:f2}");
        }
    }
}