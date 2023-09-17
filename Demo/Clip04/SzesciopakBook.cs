using Demo.Common;

namespace Demo.Clip04;

class Szczesciopak : BookDecorator
{
    public Szczesciopak(IBook other) : base(other)
    {
    }

    public override string Title
    {
        get
        {
            return "Sześciopak!";
        }
    }
}