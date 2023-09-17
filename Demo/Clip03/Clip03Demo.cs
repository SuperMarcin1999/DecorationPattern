using Demo.Common;

namespace Demo.Clip03
{
    class Clip03Demo : Common.Demo
    {
        protected override int ClipNumber => 3;
        protected override void Implementation()
        {
            Book product = new Book(
                "Design Patterns", 
                new Size(188 * Length.Millimeter, 239 * Length.Millimeter, 28 * Length.Millimeter));
            var twoPackBook = new TwoPack(product);
            Book wrappedProduct = new WrappedBook(product);
            
            BookHandler bookHandler = new BookHandler();
            
            bookHandler.Handle(product);
            bookHandler.Handle(twoPackBook);
            bookHandler.Handle(wrappedProduct);
            
            
            // Przypadek inny
            // Teoretycznie powinna wysokosc byc: 2.8 x 2 = 5.6, dodajemy 0.5 w handlerze = 6.1
            // Nastepnie opakujemy to w wraperze: 6.1 + 0,7 = 6.8
            var twoPackBook2 = new TwoPack(product); 
            var wrappedBook2 = new WrappedBook(twoPackBook2);
            
            bookHandler.Handle(wrappedBook2);
            
            // Jednak wynik jaki otrzymujemy to:
            // Dealing with WrappedBook of size 19,5 x 24,6 x 4 cm, tak jakby była dalej 1 książka
            
            // Dlatego podejscie z dziedziczeniem nie jest najlepszym sposobem, poniewaz
            // potrafimy skorzystac z implementacji metody dziedziczącej, nie koniecznie tej
            // którą byśmy chcieli
        }
    }
}
