using System;

namespace _19_Thea_The_Photographer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int timeToFilter = int.Parse(Console.ReadLine());
            int percentOfGoodPictures = int.Parse(Console.ReadLine());
            int timeToUpload = int.Parse(Console.ReadLine());

            double usefulPictures = Math.Ceiling(numberOfPictures * (percentOfGoodPictures / 100.0));
            double totallPictureFilteringTime = numberOfPictures * timeToFilter;
            double filteredPictureUploadTime = usefulPictures * timeToUpload;
            double totallTime = totallPictureFilteringTime + filteredPictureUploadTime;
            double day = Math.Ceiling(totallTime / 86400.0);
            double hours = totallTime / 3600;
            double minutes = totallTime / 60;
            double seconds = totallTime % 60;

            Console.WriteLine($"{day}:{hours:00}:{minutes:00}:{seconds:00}");

            //TimeSpan totalTimeInDateTime = TimeSpan.FromSeconds(totallTime);
            //Console.WriteLine($"{totalTimeInDateTime.Days}:{totalTimeInDateTime.Hours:00}:" +
            //                  $"{totalTimeInDateTime.Minutes:00}:{totalTimeInDateTime.Seconds:00}");
        }
    }
}