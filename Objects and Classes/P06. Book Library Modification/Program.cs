using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06.Book_Library_Modification
{
    class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        class BookLibrary
        {
            static void Main(string[] args)
            {
                Library myLibrary = new Library();
                myLibrary.Books = new List<Book>();
                myLibrary.Name = "";
                int numberOfBooks = int.Parse(Console.ReadLine());
                for (int book = 0; book < numberOfBooks; book++)
                {
                    string[] data = Console.ReadLine().Split().ToArray();
                    string title = data[0];
                    string author = data[1];
                    string publisher = data[2];
                    DateTime releaseDate = DateTime.ParseExact(data[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string isbn = data[4];
                    decimal price = decimal.Parse(data[5]);
                    Book myBook = new Book();
                    myBook.Title = title;
                    myBook.Author = author;
                    myBook.Publisher = publisher;
                    myBook.ReleaseDate = releaseDate;
                    myBook.ISBN = isbn;
                    myBook.Price = price;
                    myLibrary.Books.Add(myBook);
                }
                DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

                Dictionary<string, DateTime> filteredBooks = new Dictionary<string, DateTime>();
                for (int book = 0; book < myLibrary.Books.Count; book++)
                {
                    if (!filteredBooks.ContainsKey(myLibrary.Books[book].Title))
                    {
                        filteredBooks.Add(myLibrary.Books[book].Title, myLibrary.Books[book].ReleaseDate);
                    }
                    else filteredBooks[myLibrary.Books[book].Title] = myLibrary.Books[book].ReleaseDate;
                }


                foreach (var book in filteredBooks.Where(x => x.Value > startDate).OrderBy(x => x.Value).ThenBy(x => x.Key))
                {
                    string date = book.Value.ToString("dd.MM.yyyy");
                    Console.WriteLine("{0:f2} -> {1:f2}", book.Key, date);
                }

            }
        }
    }
}