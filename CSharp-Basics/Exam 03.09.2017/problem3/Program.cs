using System;

namespace problem3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberPhotos = int.Parse(Console.ReadLine());
            string typePhoto = Console.ReadLine().ToUpper();
            string typeOrder = Console.ReadLine().ToLower();
            decimal pricePhoto = 0.0m;
            switch (typePhoto)
            {
                case "9X13":
                    pricePhoto = 0.16m;
                    pricePhoto = pricePhoto * numberPhotos;
                    if (numberPhotos >= 50)
                        pricePhoto = pricePhoto * 0.95m;
                    break;
                case "10X15":
                    pricePhoto = 0.16m;
                    pricePhoto = pricePhoto * numberPhotos;
                    if (numberPhotos >= 80)
                        pricePhoto = pricePhoto * 0.97m;
                    break;
                case "13X18":
                    pricePhoto = 0.38m;
                    pricePhoto = pricePhoto * numberPhotos;
                    if (numberPhotos >= 50 && numberPhotos <= 100)
                        pricePhoto = pricePhoto * 0.97m;
                    else if (numberPhotos > 100)
                        pricePhoto = pricePhoto * 0.95m;
                    break;
                case "20X30":
                    pricePhoto = 2.90m;
                    pricePhoto = pricePhoto * numberPhotos;
                    if (numberPhotos >= 10 && numberPhotos <= 50)
                        pricePhoto = pricePhoto * 0.93m;
                    else if (numberPhotos > 50)
                        pricePhoto = pricePhoto * 0.91m;
                    break;
            }

            if (typeOrder == "online")
                pricePhoto = pricePhoto * 0.98m;
            Console.WriteLine($"{pricePhoto:f2}BGN");
        }
    }
}