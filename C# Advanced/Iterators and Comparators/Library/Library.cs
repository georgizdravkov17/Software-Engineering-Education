using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library 
{
   public class Library : IEnumerable
    {
        private Book book;

        public Library()
        {
            this.books = new List<Book>();
        }

        public Library(List<Book> books):this()
        {
            
        }

        public int Count
        {
            get
            {
                return this.books.Count;
            }
        }

        public List<Book> books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            for (int i = 0; i < this.books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void AddBook(Book book)
        {
            this.books.Add(this.book);
        }
    }
}
