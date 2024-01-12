using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public abstract class BookDecorator : IBook
    {
        protected IBook Book;

        public BookDecorator(IBook book)
        {
            Book = book;
        }

        public virtual string Title => Book.Title;
        public virtual string Author => Book.Author;  
        public virtual decimal Price => Book.Price;

        public virtual string Display()
        {
            return $"{Title} by {Author} - ${Price}";
        }
    }

}
