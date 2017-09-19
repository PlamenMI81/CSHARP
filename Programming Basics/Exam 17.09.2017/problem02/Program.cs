using System;

namespace problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double firstBrotherCleanTime = double.Parse(Console.ReadLine());
            double secondBrotherCleanTime = double.Parse(Console.ReadLine());
            double thirdBrotherCleanTime = double.Parse(Console.ReadLine());
            double fishingTimeFather = double.Parse(Console.ReadLine());
            double timeWithBreak = 0.0;

            double allCleanTime =
                1 / (1 / firstBrotherCleanTime + 1 / secondBrotherCleanTime + 1 / thirdBrotherCleanTime);
            timeWithBreak = allCleanTime * 0.15 + allCleanTime;

            Console.WriteLine($"Cleaning time: {timeWithBreak:f2}");
            if (timeWithBreak < fishingTimeFather)
                Console.WriteLine(
                    $"Yes, there is a surprise - time left -> {Math.Floor(fishingTimeFather - timeWithBreak)} hours.");
            else if (timeWithBreak >= fishingTimeFather)
                Console.WriteLine(
                    $"No, there isn't a surprise - shortage of time -> {Math.Ceiling(timeWithBreak - fishingTimeFather)} hours.");
        }
    }
}