using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    public interface IBook
    {
        string Title { get; }
        string Author { get; }
        decimal Price { get; }
        string Display();
    }
}
