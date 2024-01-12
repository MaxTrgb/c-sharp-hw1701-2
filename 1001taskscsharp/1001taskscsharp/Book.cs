using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public class Book : IBook
    {
        public string Title { get; }
        public string Author { get; }
        public decimal Price { get; }

        public Book(string title, string author, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public string Display()
        {
            return $"{Title} by {Author} - ${Price}";
        }
    }

}
