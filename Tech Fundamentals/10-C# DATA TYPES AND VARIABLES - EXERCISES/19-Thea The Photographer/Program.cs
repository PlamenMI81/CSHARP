using System;

namespace _19_Thea_The_Photographer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            long numberOfPictures = long.Parse(Console.ReadLine());
            long timeToFilter = long.Parse(Console.ReadLine());
            long percentOfGoodPictures = long.Parse(Console.ReadLine());
            long timeToUpload = long.Parse(Console.ReadLine());

            double usefulPictures = Math.Ceiling(numberOfPictures * (percentOfGoodPictures / 100.0));
            double totallPictureFilteringTime = numberOfPictures * timeToFilter;
            double filteredPictureUploadTime = usefulPictures * timeToUpload;
            double totallTimeInSeconds = totallPictureFilteringTime + filteredPictureUploadTime;
           
            TimeSpan time = TimeSpan.FromSeconds(totallTimeInSeconds);
            string str = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(str);
        }
    }
}