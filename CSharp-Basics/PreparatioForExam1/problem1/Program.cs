using System;

namespace problem1
{ // PriceOfAppartament
    internal class Program
    {
        private static void Main(string[] args)
        {
            double areaSmalestRoom = double.Parse(Console.ReadLine());
            double areaKitchen = double.Parse(Console.ReadLine());
            double pricePerSqMeter = double.Parse(Console.ReadLine());
            double areaBathroom = areaSmalestRoom / 2;
            double secondRoomArea = areaSmalestRoom + areaSmalestRoom * 0.1;
            double thirdRoomArea = secondRoomArea + secondRoomArea * 0.1;
            double allArea = areaSmalestRoom + areaKitchen + secondRoomArea + thirdRoomArea + areaBathroom;
            allArea = allArea + allArea * 0.05;
            double price = allArea * pricePerSqMeter;
            Console.WriteLine($"{price:f2}");
        }
    }
}