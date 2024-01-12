using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public class Library
    {
        private List<IBook> booksInLibrary = new List<IBook>();
        private List<IBook> rentedBooks = new List<IBook>();

        public void AddBook(IBook book)
        {
            booksInLibrary.Add(book);
        }

        public void RentBook(LibraryUser user, IBook book)
        {
            if (booksInLibrary.Contains(book))
            {
                Console.WriteLine($"{user.Name} rented {book.Display()}");
                rentedBooks.Add(book);
                booksInLibrary.Remove(book);
            }
            else
            {
                Console.WriteLine($"{book.Display()} is not available for rent.");
            }
        }

        public void ReturnBook(LibraryUser user, IBook book)
        {
            if (rentedBooks.Contains(book))
            {
                Console.WriteLine($"{user.Name} returned {book.Display()}");
                booksInLibrary.Add(book);
                rentedBooks.Remove(book);
            }
            else
            {
                Console.WriteLine($"{book.Display()} was not rented by {user.Name} from this library.");
            }
        }
    }
}
