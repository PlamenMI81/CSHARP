using System;

namespace NumberGenerator
{
    internal class NumberGenerator
    {
        private static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());
            for (int i = m; i >= 1; i--)
            {
                for (int j = n; j >= 1; j--)
                {
                    for (int k = l; k >= 1; k--)
                    {
                        int number = i * 100 + j * 10 + k;
                        if (specialNum >= controlNum)
                            break;
                        if (number % 3 == 0)
                            specialNum += 5;
                        else if (number % 10 == 5)
                            specialNum -= 2;
                        else if (number % 2 == 0)
                            specialNum *= 2;
                    }
                    if (specialNum >= controlNum)
                        break;
                }
                if (specialNum >= controlNum)
                    break;
            }
            Console.WriteLine(specialNum >= controlNum
                ? $"Yes! Control number was reached! Current special number is {specialNum}."
                : $"No! {specialNum} is the last reached special number.");
        }
    }
}