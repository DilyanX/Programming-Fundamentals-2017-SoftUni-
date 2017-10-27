using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05.Book_Library
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
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
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Library library = new Library();
            List<Book> books = new List<Book>();
            for (int i = 0; i < input; i++)
            {
                Book book = ReadBook();
                books.Add(book);
            }
            library.Books = books;
            PrintBooks(library);
        }

        private static void PrintBooks(Library library)
        {
            var ordered = library.Books.GroupBy(x => x.Author)
                                        .Select(g => new
                                        {
                                            Author = g.Key,
                                            Prices = g.Sum(s => s.Price)
                                        })
                                        .OrderByDescending(x => x.Prices)
                                        .ThenBy(x => x.Author).ToList();

            foreach (var author in ordered)
            {
                Console.WriteLine("{0} -> {1:F2}", author.Author, author.Prices);
            }
        }

        private static Book ReadBook()
        {
            Book book = new Book();
            string[] bookInfo = Console.ReadLine().Split().ToArray();
            book.Title = bookInfo[0];
            book.Author = bookInfo[1];
            book.Publisher = bookInfo[2];
            book.ReleaseDate = DateTime.ParseExact(bookInfo[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = bookInfo[4];
            book.Price = double.Parse(bookInfo[5], CultureInfo.InvariantCulture);
            return book;
        }
    }
}


