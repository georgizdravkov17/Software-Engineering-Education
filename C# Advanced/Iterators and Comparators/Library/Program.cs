using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBook = new Book("Amazon", 1922, new List<string> { "Pesho" });

            var secondBook = new Book("Pod igoto", 1899, new List<string> { "Ivan Vazov", "Dimitar Ivanov" });

            var thirdBook = new Book("Pod zaleza", 2002, new List<string> { "Mitko Ivanov", "Mitko Popov" });

            var library = new Library(new List<Book>()
            {
                firstBook,
                secondBook,
                thirdBook
            });
           

            foreach (var book in library)
            {
                Console.WriteLine($"{book.Title}");
            }

            var secondLibrary = new Library();
            secondLibrary.AddBook(firstBook);
            secondLibrary.AddBook(secondBook);
            secondLibrary.AddBook(thirdBook);
            secondLibrary.AddBook(new Book("MitioMitio", 2009, new List<string> { "Mitko Ivanov", "Mitko Georgiev" }));

            Console.WriteLine(secondLibrary.Count);
            Console.WriteLine(library.Count);

            foreach (var book in secondLibrary)
            {
                Console.WriteLine(book.Title);
            }

        }
    }
}
