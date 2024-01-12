using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public class ReviewsDecorator : BookDecorator
    {
        public string Reviews { get; }

        public ReviewsDecorator(IBook book, string reviews) : base(book)
        {
            Reviews = reviews;
        }

        public override string Display()
        {
            return $"{base.Display()} - Reviews: {Reviews}";
        }
    }
}
