using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }  
        public int PublicationYear { get; set; }

        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        public string getBookInfo()
        {
            return $"Title of the book - {Title}, author - {Author}, year of publication {PublicationYear}";
        }

        public int CompareTo(Book? other)
        {
            return PublicationYear.CompareTo(other.PublicationYear);
        }
    }
}
