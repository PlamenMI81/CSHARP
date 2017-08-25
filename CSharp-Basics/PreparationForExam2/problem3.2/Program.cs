using System;

namespace problem3._2
{ //School Camp
    internal class Program
    {
        private static void Main(string[] args)
        {
            string season = Console.ReadLine().ToLower();
            string groupType = Console.ReadLine().ToLower();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            double pricePerNight = 0;
            string sport = null;
            if (season == "winter" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 9.60;
                sport = groupType == "boys" ? "Judo" : "Gymnastics";
            }
            else if (season == "spring" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 7.20;
                sport = groupType == "boys" ? "Tennis" : "Athletics";
            }
            else if (season == "summer" && (groupType == "boys" || groupType == "girls"))
            {
                pricePerNight = 15.00;
                sport = groupType == "boys" ? "Football" : "Volleyball";
            }
            else if (season == "winter" && groupType == "mixed")
            {
                pricePerNight = 10.00;
                sport = "Ski";
            }
            else if (season == "spring" && groupType == "mixed")
            {
                pricePerNight = 9.50;
                sport = "Cycling";
            }
            else if (season == "summer" && groupType == "mixed")
            {
                pricePerNight = 20.00;
                sport = "Swimming";
            }
            double priceAllNights = pricePerNight * nights * numberOfStudents;
            if (numberOfStudents >= 50)
                priceAllNights -= priceAllNights * 0.50;
            else if (numberOfStudents < 50 && numberOfStudents >= 20)
                priceAllNights -= priceAllNights * 0.15;
            else if (numberOfStudents < 20 && numberOfStudents >= 10)
                priceAllNights -= priceAllNights * 0.05;
            Console.WriteLine($"{sport} {priceAllNights:f2} lv.");
        }
    }
}