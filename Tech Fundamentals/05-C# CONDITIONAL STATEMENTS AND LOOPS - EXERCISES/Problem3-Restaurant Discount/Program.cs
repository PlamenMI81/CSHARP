using System;

namespace Problem3_RestaurantDiscount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string typeOfPackage = Console.ReadLine();
            string hall;
            decimal priceHall = 0;
            decimal priceDisc = 0;
            decimal disc = 0;
            if (groupSize <= 50)
            {
                hall = "Small Hall";
                priceHall = 2500.0m;
            }
            else if (groupSize <= 100 && groupSize > 50)
            {
                hall = "Terrace";
                priceHall = 5000.0m;
            }
            else if (groupSize <= 120 && groupSize > 100)
            {
                hall = "Great Hall";
                priceHall = 7500.0m;
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            switch (typeOfPackage)
            {
                case "Normal":
                    priceDisc = 500.0m;
                    disc = 0.05m;
                    break;
                case "Gold":
                    priceDisc = 750.0m;
                    disc = 0.10m;
                    break;
                case "Platinum":
                    priceDisc = 1000.0m;
                    disc = 0.15m;
                    break;
            }
            decimal totallPrice = priceHall + priceDisc;
            totallPrice = totallPrice - totallPrice * disc;
            decimal pricePerPerson = totallPrice / groupSize;
            Console.WriteLine($"We can offer you the {hall}\n" +
                              $"The price per person is {pricePerPerson:f2}$");
        }
    }
}