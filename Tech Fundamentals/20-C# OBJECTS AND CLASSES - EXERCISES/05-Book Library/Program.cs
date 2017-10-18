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
            List<Book> book=new List<Book>();
            for (int i = 0; i < lines; i++)
            {
                book.Add(ReadBook(Console.ReadLine()));
            }
            Library library = new Library() {Name = "Library",Books = book};

            PrintBooksByAuthorAndTotalPrice(library);

        }
        public static void PrintBooksByAuthorAndTotalPrice(Library library)
        {
            
            // group books in library by author, then order them descending, by their total price (using .Sum())
            // and finaly order them by author’s name lexicographically
            foreach (var book in library.Books
                .GroupBy(b => b.Autor)
                .OrderByDescending(x => x.Sum(p => p.Price))
                .ThenBy(k => k.Key))
            {
                Console.WriteLine($"{book.Key} -> {book.Sum(p => p.Price):f2}");
            }
        }


        private static Book ReadBook(string readLine)
        {
            string[] inputLine = readLine.Split();
            var title = inputLine[0];
            var autor = inputLine[1];
            var pub = inputLine[2];
            DateTime relDate = DateTime.ParseExact(inputLine[3], "dd.MM.yyyy",CultureInfo.InvariantCulture);
            var isbn = inputLine[4];
            var price = double.Parse(inputLine[5]);

            return new Book { Title = title,Autor = autor,Publisher = pub,ReleaseDate = relDate,ISBN = isbn,Price = price};
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
