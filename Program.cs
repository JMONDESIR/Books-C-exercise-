using System;
using System.Collections.Generic;
using Books;

namespace Books
{
    class Book
    {
        // this is a constructor
        public Book()
        {
            Title = "";
            SubTitle = "";
            Author = "";
            ReleaseDate = DateTime.Now;
            Price = double.MaxValue;
        }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public double Price { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"SubTitle: {SubTitle}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Release Date: {ReleaseDate}");
            Console.WriteLine($"Price: ${Price}");
        }

        public void DisplayDetails(string header)
        {
            Console.WriteLine(header);
            DisplayDetails();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Author = "Joel Mondesir";
            book1.Title = "Life According To Joel";
            book1.SubTitle = "Live Your Best Life";
            book1.ReleaseDate = new DateTime(2019, 01, 05);
            book1.Price = 9.99;

            Book book2 = new Book()
            {
                Title = "How To Win At Life",
                Author = "Howard Dare",
                ReleaseDate = new DateTime(2020, 11, 1),
                Price = 23.99
            };
            Book book3 = new Book()
            {
                Title = "On The Right Side",
                Author = "Janet Lewis",
                ReleaseDate = new DateTime(2019, 06, 1),
                Price = 45.99
            };

            List<Book> shelf = new List<Book>() {
                book1, book2, book3
        };

            double sum = 0;
            foreach (Book book in shelf)
            {
                sum += book.Price;
            };
            foreach (Book book in shelf)
            {
                // Console.WriteLine($"Title: {book.Title}");
                // Console.WriteLine($"SubTitle: {book.SubTitle}");
                // Console.WriteLine($"Author: {book.Author}");
                // Console.WriteLine($"Release Date: {book.ReleaseDate}");
                // Console.WriteLine($"Price: ${book.Price}");

                book.DisplayDetails("A random BOOK header");
                Console.WriteLine($"---------------------------------------------------------");
            }
            // Dictionary<string, string> book1 = new Dictionary<string, string>() {
            //     {"title", "The Thinking Man"},
            //     {"author", "Roland Deschain"},
            //     {"releaseDate", "02/01/2018"},
            //     {"price", "29.99"},
            // };
            // Dictionary<string, string> book2 = new Dictionary<string, string>() {
            //     {"title", "West Of Westeros"},
            //     {"author", "George R.R. Martin"},
            //     {"releaseDate", "01/01/2019"},
            //     {"price", "99.99"},
            // };
            // Dictionary<string, string> book3 = new Dictionary<string, string>() {
            //     {"title", "We Have The Technology"},
            //     {"author", "John Schmidt"},
            //     {"releaseDate", "06/18/1980"},
            //     {"price", "5.99"},
            // };
        }
    }
}