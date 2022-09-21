using csharp.Items;

namespace csharp.Visitors
{
    public class IncreasingVisitor : IVisitorStrategy
    {
        public void Visit(Item item)
        {
            item.SellIn--;
            item.Quality = Helper.ClampValue(++item.Quality);
        }
    }
}
