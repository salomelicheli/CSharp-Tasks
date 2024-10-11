using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    internal class Library
    {
        public List<Book> books { get; set; } = new List<Book>();

        public void addBook(Book book)
        {
            books.Add(book);
        }

        public void removeBook(string Title)
        {
            for(int i = 0; i < books.Count; i++)
            {
                if(books[i].Title == Title)
                {
                    books.RemoveAt(i);
                    break;
                }
            }
        }

        public void displayAllTheBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book.getBookInfo());
            }
        }

        public List<Book> findBooksByAuthor(string author)
        {
            List<Book> booksBySpecificAuthor = new List<Book>();
            foreach(Book book in books)
            {
                if(book.Author == author)
                {
                    booksBySpecificAuthor.Add(book);
                }
            }
            return booksBySpecificAuthor;
        }

        public List<Book> searchBooksByWord(string word)
        {
            List<Book> booksBySpecificAuthor = new List<Book>();
            word = word.ToLower();  
            foreach(Book book in books)
            {
                if(book.Author.ToLower().Contains(word) || book.Title.ToLower().Contains(word))
                {
                    booksBySpecificAuthor.Add(book);
                } 
                //else if(book.Title.Contains(word))
                //{

                //}
                
                //for(int i = 0;i < book.Author.Length - word.Length;i++)
                //{
                //    if (book.Author.Substring(i, word.Length) == word) 
                //    { 
                //        booksBySpecificAuthor.Add(book);
                //        break; }
                //}
                //for (int i = 0; i < book.Title.Length- word.Length; i++)
                //{
                //    if (book.Title.Substring(i, word.Length) == word) 
                //    { booksBySpecificAuthor.Add(book); 
                //        break; }
                //}
            }
            return booksBySpecificAuthor;
        }

        public List<Book> GetSortedBooksByPublicationYear()
        {
            books.Sort();
            return books;
        }
    }
}
