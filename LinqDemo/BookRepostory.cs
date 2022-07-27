using System;
using System.Collections.Generic;

namespace LinqDemo
{
    public class BookRepostory
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "ADO.NET Basics", Price = 5},
                new Book() {Title = "C# Advanced Topics", Price = 9.99f},
                new Book() {Title = "JavaScript for Beginners", Price = 12},
                new Book() {Title = "Clean Code", Price = 7},
                new Book() {Title = "Windows PowerShell", Price = 8}
            };
        }
    }
}
