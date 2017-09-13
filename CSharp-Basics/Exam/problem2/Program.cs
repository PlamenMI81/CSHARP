using System;

namespace problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            decimal income = decimal.Parse(Console.ReadLine());
            double averageSuccess = double.Parse(Console.ReadLine());
            decimal minWorkSalarry = decimal.Parse(Console.ReadLine());
            decimal sociallScholarship = 0.0m;
            decimal excellentScholarship = 0.0m;

            if (income < minWorkSalarry && averageSuccess > 4.50)
                sociallScholarship = minWorkSalarry * 0.35m;

            if (averageSuccess >= 5.50)
                excellentScholarship = (decimal) averageSuccess * 25m;

            if (sociallScholarship > excellentScholarship)
                Console.WriteLine($"You get a Social scholarship {Math.Floor(sociallScholarship)} BGN");
            else if (excellentScholarship >= sociallScholarship && (sociallScholarship != 0.0m || excellentScholarship != 0.0m))
                Console.WriteLine(
                    $"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
            else
                Console.WriteLine("You cannot get a scholarship!");
        }
    }
}