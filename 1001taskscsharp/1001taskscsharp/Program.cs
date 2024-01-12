using _1001taskscsharp;
using System.ComponentModel;

namespace MySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            IBook book = new Book("Hobbit", "J. Tolkien", 12);
            book = new CoverDecorator(book, "Hardcover");
            book = new ReviewsDecorator(book, "Highly recommended!");

            Library library = new Library();
            library.AddBook(book);

            LibraryUser user = new LibraryUser("Petro Petrovych");

            library.RentBook(user, book);
            library.ReturnBook(user, book);
        }
    }
}