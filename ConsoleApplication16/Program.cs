using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApplication16
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Book> books = new List<Book>()
            {
                new Book() {Name ="book1",Year=1952, AuthorID=1},
                new Book() {Name="book1Linq",Year=1984, AuthorID=1 },
                new Book {Name="book3Linq",Year=1980 , AuthorID=3}
            };

            List<Author> authors = new List<Author>()
            {
                new Author {Name ="Author1", AuthorID=1},
                new Author {Name="Author2", AuthorID=2 },
                new Author {Name="Author3", AuthorID=3 }
            };
            ////////////task1

            Console.WriteLine(string.Join(" ", books.Where(x => x.Name.Contains("Linq") && (x.Year % 4 == 0) && !(x.Year % 100 == 0) || x.Year % 400 == 0).Select(x => x.Name).ToList()));

            ////////////task2

            Console.WriteLine(string.Join(" ", authors.GroupJoin(books, p => p.AuthorID, c => c.AuthorID, (p, c) => new { Name = p.Name, Books = c.Count() })));

            ////////////task3

            int[] arr = new int[] { 14, 33, 23, 20, 13, 32 };
            Console.WriteLine(arr.OrderBy(t=>

        }
    }
}
