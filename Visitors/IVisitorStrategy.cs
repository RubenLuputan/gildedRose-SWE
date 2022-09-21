using csharp.Items;

namespace csharp.Visitors
{
    public interface IVisitorStrategy
    {
        void Visit(Item item);
    }
}
