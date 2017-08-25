using System;

namespace problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int steps = int.Parse(Console.ReadLine());
            int dancers = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            double stepsperDay = Math.Ceiling((double) steps / days / steps * 100);
            double stepsPerDancer = stepsperDay / dancers;
            if (stepsperDay <= 13)
                Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:f2}%.");
            else
                Console.WriteLine(
                    $"No, They will not succeed in that goal! Required {stepsPerDancer:f2}% steps to be learned per day.");
        }
    }
}