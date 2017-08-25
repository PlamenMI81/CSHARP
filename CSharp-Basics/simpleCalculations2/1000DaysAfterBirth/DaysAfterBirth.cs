using System;
using System.Globalization;


namespace DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string date = Console.ReadLine();
            DateTime birthDate = DateTime.ParseExact(date, "dd-MM-yyyy", CultureInfo.InvariantCulture); //CurrentCulture, null
            birthDate = birthDate.AddDays(999);
            Console.WriteLine(birthDate.ToString("dd-MM-yyyy"));


            //string date = Console.ReadLine();
            //DateTime birthDate = DateTime.Parse(date);
            //birthDate = birthDate.AddDays(999);
            //Console.WriteLine(birthDate.ToString("dd-MM-yyyy"));
        }
    }
}
