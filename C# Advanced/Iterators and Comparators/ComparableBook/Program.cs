using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstBook = new Book("Pod Igoto", 1922, new List<string> { "Ivan Vazov", "Mitko Ivanov" });
            var secondBook = new Book("Bibly", 500, new List<string> {"Mitko Mitkov" });
            var thirdBook = new Book("Qazkazi", 1100, new List<string> {"Ivan Mitkov" });
            var fourthBook = new Book("Btihove", 1100, new List<string> {" Mitkov Plahovic","M.I","Hristo Botev" });

            var firstLibrary = new Library(new List<Book>
            {
                firstBook,
                secondBook,
                thirdBook,
                fourthBook
            });

            var books = new List<Book>()
            {
                firstBook,
                secondBook,
                thirdBook
                
            };

            var secondLibrary = new Library(books);

            firstLibrary.Books.Sort();

            foreach (var book in secondLibrary)
            {
                Console.WriteLine($"{book.Title} -> {book.Year}");
            }

            Console.WriteLine(secondLibrary.Count);

            foreach (var book in firstLibrary)
            {
                Console.WriteLine($"{book.Title} -> {book.Year}");
            }

            Console.WriteLine(firstLibrary.Count);

        }
    }
}
