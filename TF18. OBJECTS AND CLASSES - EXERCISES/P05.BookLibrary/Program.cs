using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> bookList = new Dictionary<string, decimal>();

            for (int i = 0; i < input; i++)
            {
                List<string> bookData = Console.ReadLine()
                    .Split()
                    .ToList();

                Book book = GetBookData(bookData);

                if (!bookList.ContainsKey(book.Autor))
                {
                    bookList.Add(book.Autor, book.Price);
                }
                else
                {
                    bookList[book.Autor] += book.Price;
                }
            }

            foreach (var autor in bookList.OrderByDescending(p => p.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{autor.Key} -> {autor.Value:f2}");
            }
        }

        public static Book GetBookData(List<string> bookData)
        {
            return new Book
            {
                Autor = bookData[1],
                Price = decimal.Parse(bookData[5])
            };
        }
    }

    public class Book
    {
        public string Autor { get; set; }
        public decimal Price { get; set; }
    }
}
