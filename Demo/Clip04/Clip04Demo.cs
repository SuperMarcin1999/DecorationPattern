using Demo.Common;

namespace Demo.Clip04
{
    class Clip04Demo : Common.Demo
    {
        protected override int ClipNumber { get; } = 4;
        private readonly Length mm = Length.Millimeter;

        protected override void Implementation()
        {
            var buyer = new BookHandler();
            var dispatcher = new BookHandler();

            var encyklopedia = new PrintedBook("Encyklopedia", new Size(250*mm, 300*mm, 60*mm));
            buyer.Handle(encyklopedia);

            var szesciopakEncyklopedii = new Szczesciopak(encyklopedia);
            var zapakowanaEncyklopedia = new WrappedBook(szesciopakEncyklopedii);
            dispatcher.Handle(zapakowanaEncyklopedia);
        }
    }
}
