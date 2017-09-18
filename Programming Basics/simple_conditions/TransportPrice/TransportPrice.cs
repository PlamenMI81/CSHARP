using System;

namespace TransportPrice
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine().ToLower();
            decimal price = 0;

            if (n >= 100)
            {
                price = n * 0.06m;
            }
            else if (n <100 && n>=20)
            {
                price = n * 0.09m;
            }
            else
            {
                if (dayOrNight=="day")
                {
                    price = n * 0.79m + 0.7m;
                }
                else
                {
                    price = n * 0.9m + 0.7m;
                }
            }
            Console.WriteLine($"{price:f2}");
       }
    }
}
