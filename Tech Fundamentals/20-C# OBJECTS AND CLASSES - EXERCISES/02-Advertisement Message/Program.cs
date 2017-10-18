using System;
using System.Dynamic;

namespace _02_Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] autors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random rand = new Random();
            int inputNum =int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNum; i++)
            {
                int phrasesIndex=GetRandomIndex(phrases,rand);
                int eventIndex= GetRandomIndex(events, rand);
                int autorIndex= GetRandomIndex(autors, rand);
                int citiesIndex= GetRandomIndex(cities, rand);
                GeneratePhrase(phrases, phrasesIndex,events, eventIndex,autors, autorIndex,cities, citiesIndex);
            }
        }

        private static void GeneratePhrase(string[] phrases, int phrasesIndex, string[] events, int eventIndex, string[] autors, int autorIndex, string[] cities, int citiesIndex)
        {
            string currPhrase = phrases[phrasesIndex];
            string currEvenet = events[eventIndex];
            string currAutor = autors[autorIndex];
            string currCitiy = cities[citiesIndex];
            Console.WriteLine($"{currPhrase} {currEvenet} {currAutor} – {currCitiy}");
        }

        private static int GetRandomIndex(string[] array, Random rand)
        {
            int randomIndex=rand.Next(0, array.Length);
            return randomIndex;
        }
    }
}
