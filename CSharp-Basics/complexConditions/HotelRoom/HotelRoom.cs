using System;

namespace HotelRoom
{
    class HotelRoom
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int numberOfSleepings = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double appartamentPrice = 0;
            int appartamentPriceChecked = 0;
            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    appartamentPrice = 65;
                    break;
                case "june":
                case "september":
                    studioPrice = 75.20;
                    appartamentPrice = 68.70;
                    break;
                case "july":
                case "august":
                    studioPrice = 76;
                    appartamentPrice = 77;
                    break;
            }
            if (numberOfSleepings > 14 && (month == "june" || month == "september"))
            {
                appartamentPrice = appartamentPrice - (appartamentPrice * 0.1);
                appartamentPriceChecked = 1;
                studioPrice = studioPrice - (studioPrice * 0.2);
            }
            else if (numberOfSleepings > 14 && (month == "may" || month == "october"))
            {
                appartamentPrice = appartamentPrice - (appartamentPrice * 0.1);
                appartamentPriceChecked = 1;
                studioPrice = studioPrice - (studioPrice * 0.3);
            }
            else if ((numberOfSleepings > 7 && numberOfSleepings <= 14) && (month == "may" || month == "october"))
            {
                studioPrice = studioPrice - (studioPrice * 0.05);
            }
            if (numberOfSleepings > 14)
            {
                if (appartamentPriceChecked == 1)
                {
                    Console.WriteLine($"Apartment: {appartamentPrice * numberOfSleepings:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice * numberOfSleepings:f2} lv.");
                }
                else
                {
                    appartamentPrice = appartamentPrice - (appartamentPrice * 0.1);
                    Console.WriteLine($"Apartment: {appartamentPrice * numberOfSleepings:f2} lv.");
                    Console.WriteLine($"Studio: {studioPrice * numberOfSleepings:f2} lv.");
                }
            }
            else if (numberOfSleepings <= 14)
            {
                Console.WriteLine($"Apartment: {appartamentPrice * numberOfSleepings:f2} lv.");
                Console.WriteLine($"Studio: {studioPrice * numberOfSleepings:f2} lv.");
            }

        }
    }
}









//if ((numberOfSleepings > 7 && numberOfSleepings <= 14) && (month == "may") || (month == "october"))
//{
//    studioPrice = studioPrice - (studioPrice * 0.05);
//    Console.WriteLine($"Apartment: {appartamentPrice*numberOfSleepings:f2} lv.");
//    Console.WriteLine($"Studio: {studioPrice*numberOfSleepings:f2} lv.");
//}
//else if (numberOfSleepings > 14 && (month == "may" || month == "october"))
//{
//    studioPrice=studioPrice-(studioPrice*0.30);
//}
//else if (numberOfSleepings>14 && (month == "june" || month == "september"))
//{
//    studioPrice = studioPrice - (studioPrice * 0.20);
//}
//
//if (numberOfSleepings>14)
//{
//    appartamentPrice=appartamentPrice-(appartamentPrice*0.10);
//    Console.WriteLine($"Apartment: {appartamentPrice * numberOfSleepings:f2} lv.");
//    Console.WriteLine($"Studio: {studioPrice * numberOfSleepings:f2} lv.");
//}
//else if (numberOfSleepings <= 14)
//{
//    Console.WriteLine($"Apartment: {appartamentPrice * numberOfSleepings:f2} lv.");
//    Console.WriteLine($"Studio: {studioPrice * numberOfSleepings:f2} lv.");
//}
