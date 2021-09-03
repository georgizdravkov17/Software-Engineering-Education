using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookIComperator
{
   public class Book : IComparable<Book>
    {
        public Book(string title, int year, List<string> authors )
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

        public string Title { get; set; }
        
        public int Year { get; set; }

        public List<string> Authors { get; set; }

        

        public BookComperator CompareTo(Book other)
        {
           var comperator =  new BookComperator();

            return comperator;
        }
    }
}
