using System;
using Demo.Common;

namespace Demo.Clip01
{
    class BookHandler
    {
        public void Handle(Book product)
        {
            Size bookSize = product.Dimensions;
            Console.WriteLine($"Dealing with book \"{product.Title}\" of size {bookSize}");
        }
    }
}
