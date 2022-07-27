using System;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepostory().GetBooks();
            var cheapBooks = books.Where(b => b.Price < 10);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title + " " + book.Price);
            }
        }
    }
}
