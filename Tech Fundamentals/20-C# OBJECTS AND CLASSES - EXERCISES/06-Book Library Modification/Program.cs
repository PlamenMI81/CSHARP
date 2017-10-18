using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _05_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            List<Book> book = new List<Book>();
            for (int i = 0; i < lines; i++)
            {
                book.Add(ReadBook(Console.ReadLine()));
            }
            Library library = new Library() { Name = "Library", Books = book };
            
            PrintBooksByAuthorAndTotalPrice(library);

        }
        public static void PrintBooksByAuthorAndTotalPrice(Library library)
        {

            //print all titles released after given date 
            //ordered by date and then by title lexicographically
            DateTime printAfter=DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",CultureInfo.InvariantCulture);

            foreach (var book in library.Books
                .Where(x=>x.ReleaseDate>printAfter)
                .OrderBy(x=>x.ReleaseDate)
                .ThenBy(x=>x.Title))
                
            {
                Console.WriteLine($"{book.Title} -> {book.ReleaseDate:dd.MM.yyyy}");
            }
        }


        private static Book ReadBook(string readLine)
        {
            string[] inputLine = readLine.Split();
            var title = inputLine[0];
            var autor = inputLine[1];
            var pub = inputLine[2];
            DateTime relDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            var isbn = inputLine[4];
            var price = double.Parse(inputLine[5]);

            return new Book { Title = title, Autor = autor, Publisher = pub, ReleaseDate = relDate, ISBN = isbn, Price = price };
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Autor { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
