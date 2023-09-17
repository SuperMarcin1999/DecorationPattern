using Demo.Common;

namespace Demo.Clip01
{
    class Clip01Demo : Common.Demo
    {
        protected override int ClipNumber { get; } = 1;
        private readonly Length mm = Length.Millimeter;

        protected override void Implementation()
        {
            Book product = new Book("Design patterns" ,
                new Size(188 * mm,239 * mm,28 * mm));
            
            var buyer = new BookHandler();
            buyer.Handle(product);

            var wrappedProduct = new WrappedBook(product);
            var dispatcher = new BookHandler();
            dispatcher.Handle(wrappedProduct);
        }
    }
}
