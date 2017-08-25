using System;

namespace OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number;
            int oddSum = 0;
            int evenSum = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    oddSum = oddSum + number;
                }
                else
                {
                    evenSum = evenSum + number;
                }
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine($"Yes, sum = {oddSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(oddSum - evenSum)}");
            }
        }
    }
}
