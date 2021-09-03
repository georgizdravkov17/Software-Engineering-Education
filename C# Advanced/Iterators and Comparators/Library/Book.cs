using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public Book(string title, int year, List<string> authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = new List<string>();
        }

        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }
    }
}
