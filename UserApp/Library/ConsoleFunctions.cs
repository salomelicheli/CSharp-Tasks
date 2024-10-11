using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Project2
{
    internal static class ConsoleFunctions
    {
       static Library library = new Library();

        public static void StartLibrary()
        {
            
            while (true)
            {
                Console.WriteLine("0. Exit program\n1. Add new book\n2. Delete book\n3. See all books\n4. Find book by author\n5. Search\n6. Get sorted list of the books");
                string UserChoice = Console.ReadLine();
                switch (UserChoice)
                {
                    case "0":
                        return;
                    case "1":
                        addBook();
                        break;
                    case "2":
                        removeBook();
                        break;
                    case "3":
                        displayAllTheBooks();
                        break;
                    case "4":
                        findBooksByAuthor();
                        break;
                    case "5":
                        searchBooksByWord();
                        break;
                    case "6":
                        sortBooksByPublicationYear();
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void addBook()
        {
            Console.Write("input a book title: ");
            String title = Console.ReadLine();
            Console.Write("input an author: ");
            String Author = Console.ReadLine();
            Console.Write("input publishing year: ");
            int publishYear = int.Parse(Console.ReadLine());
            library.addBook(new Book(title, Author, publishYear));
            Console.WriteLine("book has been added successfully");
        }

        private static void removeBook()
        {
            Console.Write("input a book title: ");
            string title = Console.ReadLine();
            library.removeBook(title);
            Console.WriteLine("book has been removed successfully");
        }
        private static void displayAllTheBooks()
        {
            Console.WriteLine("Get all the books");
            library.displayAllTheBooks();
        }
        private static void findBooksByAuthor()
        {
            Console.Write("input author name: ");
            string author = Console.ReadLine();
            List<Book> books = library.findBooksByAuthor(author);

            Console.WriteLine($"{books.Count} books found by the following author: ");
            foreach (Book book in books)
            {
                book.getBookInfo();
            }
        }
        private static void searchBooksByWord()
        {
            Console.Write("Search: ");
            string randomWord = Console.ReadLine();
            List<Book> books = library.searchBooksByWord(randomWord);
            Thread.Sleep(1000);
            Console.WriteLine($"{books.Count} results found for your search");
            foreach(Book book in books)
            {
                Console.WriteLine(book.getBookInfo());
            }
        }

        private static void sortBooksByPublicationYear()
        {
            List<Book> books = library.GetSortedBooksByPublicationYear();
            foreach(Book book in books)
            {
                Console.WriteLine(book.getBookInfo());
            }
        }
    }
}
