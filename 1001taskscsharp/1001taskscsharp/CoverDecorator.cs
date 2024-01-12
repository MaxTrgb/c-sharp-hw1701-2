using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public class CoverDecorator : BookDecorator
    {
        public string Cover { get; }

        public CoverDecorator(IBook book, string cover) : base(book)
        {
            Cover = cover;
        }

        public override string Display()
        {
            return $"{base.Display()} - Cover: {Cover}";
        }
    }
}
