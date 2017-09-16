using System;

namespace Problem4_Photo_Gallery
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int rezWidth = int.Parse(Console.ReadLine());
            int rezHeight = int.Parse(Console.ReadLine());
            string readableSize = null;
            string orientation;
            if (sizeInBytes < 1000)
                readableSize = $"{sizeInBytes}" + "B";
            else if (sizeInBytes >= 1000 && sizeInBytes < 1000000)
                readableSize = $"{sizeInBytes / 1000.0}" + "KB";
            else if (sizeInBytes >= 1000000)
                readableSize = $"{sizeInBytes / 1000000.0}" + "MB";

            if (rezWidth > rezHeight)
                orientation = "landscape";
            else if (rezWidth < rezHeight)
                orientation = "portrait";
            else
                orientation = "square";
            Console.WriteLine($"Name: DSC_{photoNumber:0000}.jpg\n" +
                              $"Date Taken: {day:00}/{month:00}/{year} {hour:00}:{minutes:00}\n" +
                              $"Size: {readableSize}\n" +
                              $"Resolution: {rezWidth}x{rezHeight} ({orientation})");
        }
    }
}