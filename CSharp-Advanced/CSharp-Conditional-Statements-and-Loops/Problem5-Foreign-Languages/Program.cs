using System;

namespace Problem5_Foreign_Languages
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string country = Console.ReadLine().ToLower();
            string lang;
            switch (country)
            {
                default:
                    lang = "unknown";
                    break;
                case "usa":
                case "england":
                    lang = "English";
                    break;
                case "spain":
                case "argentina":
                case "mexico":
                    lang = "Spanish";
                    break;
            }
            Console.WriteLine(lang);
        }
    }
}