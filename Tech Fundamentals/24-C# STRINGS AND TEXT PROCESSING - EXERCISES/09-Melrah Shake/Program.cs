using System;

namespace _09_Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomString = Console.ReadLine();
            var patern = Console.ReadLine();
            var shakedString = "";
            while (true)
            {
                var indexFirstOccurence = randomString.IndexOf(patern);
                var indexLastOccurence = randomString.LastIndexOf(patern);

                if (indexFirstOccurence > -1 && indexLastOccurence > -1 && patern.Length > 0 && indexFirstOccurence != indexLastOccurence)
                {
                    shakedString = randomString.Remove(indexFirstOccurence, patern.Length);
                    shakedString = shakedString.Remove(indexLastOccurence - patern.Length, patern.Length);
                    Console.WriteLine("Shaked it.");

                    patern = patern.Remove(patern.Length / 2, 1);
                    randomString = shakedString;
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(randomString);
                    break;
                }

            }
        }
    }
}
