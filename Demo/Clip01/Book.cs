using Demo.Common;

namespace Demo.Clip01
{
    class Book
    {
        public string Title { get; }
        public virtual Size Dimensions { get; } // virtual zeby dalo sie override zrobic

        public Book(string title, Size dimensions)
        {
            this.Title = title;
            this.Dimensions = dimensions;
        }

        // konsktruktor "kopiujacy", robi sie po to zeby miec miec dostep do tych Title, Dimension, bo gdyby
        // byly one np prywatne, z zewnatrz nie dalo by sie ich podac zeby skopiowac
        protected Book(Book other) : this(other.Title, other.Dimensions)
        {
            
        }

        public override string ToString() =>
            $"{this.Title} - {this.Dimensions}";
    }
}
