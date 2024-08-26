using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace oopRepeat
{
    public class Book  : IComparable<Book>
    {
        public string Title { get; set; }
        public DateTime PublishDate { get; set; }
        public decimal Cost { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public enum BookType 
        {
            
            Fiction,
            Tech,
            NonFiction
            
        }

        public BookType Genre = BookType.Fiction;






        public int CompareTo(Book other)
        {
            // sorting books from oldest to newest 
            return this.PublishDate.CompareTo(other.PublishDate);
        }



    }
}
