using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace P06.BookLibraryModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int booksCount = int.Parse(Console.ReadLine());
            Library libraryOfBooks = GetLibraryOfBooks(booksCount);

            string dateFormat = "d.M.yyyy";
            string dateString = Console.ReadLine();
            DateTime targetDate = DateTime.ParseExact(dateString, dateFormat, CultureInfo.InvariantCulture);

            Dictionary<string, DateTime> booksReleasedAfterDate = GetbooksReleasedAfterDate(libraryOfBooks, targetDate);

            PrintTotalBooksPriveByAuthor(booksReleasedAfterDate);
        }

        static void PrintTotalBooksPriveByAuthor(Dictionary<string, DateTime> booksReleasedAfterDate)
        {
            foreach (var date in booksReleasedAfterDate.OrderBy(d => d.Value).ThenBy(t => t.Key))
            {
                Console.WriteLine($"{date.Key} -> {date.Value:dd.MM.yyyy}");
            }
        }

        private static Dictionary<string, DateTime> GetbooksReleasedAfterDate(Library libraryOfBooks, DateTime targetDate)
        {
            Dictionary<string, DateTime> totalBooksPriveByAuthor = new Dictionary<string, DateTime>();

            foreach (var book in libraryOfBooks.Books)
            {
                if (targetDate < book.ReleaseDate)
                {
                    totalBooksPriveByAuthor[book.Title] = book.ReleaseDate;
                }
            }

            return totalBooksPriveByAuthor;
        }

        static Library GetLibraryOfBooks(int booksCount)
        {
            Library libratyOfBooks = new Library();

            List<Book> booksList = new List<Book>();

            for (int i = 0; i < booksCount; i++)
            {
                libratyOfBooks.Books.Add(GetBook());
            }

            return libratyOfBooks;
        }

        private static Book GetBook()
        {
            string dateFormat = "d.M.yyyy";
            string[] bookInfo = Console.ReadLine()
                .Split()
                .ToArray();
            return new Book
            {
                Title = bookInfo.First(),
                ReleaseDate = DateTime.ParseExact(
                    bookInfo.Skip(3).First(),
                    dateFormat,
                    CultureInfo.InvariantCulture),
            };
        }
    }

    class Library
    {
        public List<Book> Books = new List<Book>();
    }

    class Book
    {
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
