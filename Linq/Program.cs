using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            //var cheapBooks = new List<Book>();
            //foreach (var book in books)
            //{
            //    if (book.Price < 10)
            //    {
            //        cheapBooks.Add(book);
            //    }
            //}


            // LINQ Extension Methods
            var cheapBooks = books
                              .Where(b => b.Price < 10)
                              .OrderBy(b => b.Title)
                              .Select(b => b.Title);
            
            //books.OrderBy(b => b.Title)

            foreach (var book in cheapBooks)
            {
                //Console.WriteLine("Book {0} is only ${1}!!", book.Title, book.Price);
                Console.WriteLine(book);
            }

            Console.WriteLine("---");
            //var oneBook = books.Single(b => b.Title == "ASP.NET MVC");
            //var oneBook = books.SingleOrDefault(b => b.Title == "ASP.NET MVC+++");
            //var oneBook = books.First(b => b.Title == "C# Advanced Topics");
            //var oneBook = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");
            //var oneBook = books.Last(b => b.Title == "C# Advanced Topics");
            var oneBook = books.LastOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(oneBook.Title + " " + oneBook.Price);
            Console.WriteLine("---");

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var book in pagedBooks)
            {
                Console.WriteLine("Book {0} is ${1}", book.Title, book.Price);
            }

            Console.WriteLine("---");
            // LINQ Query Operators
            var cheaperBooks =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b;

            foreach (var book in cheaperBooks)
            {
                Console.WriteLine("Book {0} is only ${1}!!", book.Title, book.Price);
            }
        }
    }
}
