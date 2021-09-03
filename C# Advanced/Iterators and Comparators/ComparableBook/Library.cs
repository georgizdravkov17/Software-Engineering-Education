using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparableBook
{
   public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library()
        {

        }

        public Library(List<Book> books)
        {
            this.Books = books;
        }

        public List<Book> Books
        {
            get
            {
                return this.books;
            }

            set
            {
                this.books = value;
            }
        }

        public int Count
        {
            get
            {
                return this.books.Count;
            }

        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (var book in books)
            {
                yield return book;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
