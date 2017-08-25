using System;

namespace ControlNumber
{
    internal class ControlNumber
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = m; j >= 1; j--)
                {
                    sum = sum + i * 2 + j * 3;
                    counter++;
                    if (sum >= controlNum)
                        break;
                }
                if (sum >= controlNum)
                    break;
            }
            if (sum >= controlNum)
            {
                Console.WriteLine($"{counter} moves");
                Console.WriteLine($"Score: {sum} >= {controlNum}");
            }
            else
            {
                Console.WriteLine($"{counter} moves");
            }
        }
    }
}