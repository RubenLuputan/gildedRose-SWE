using csharp.Items;

namespace csharp.Visitors
{
    public class PassVisitor : IVisitorStrategy
    {
        public void Visit(Item item)
        {
            item.SellIn--;

            if (item.SellIn <= 0)
            {
                if (item.Quality == 0)
                    return;

                item.Quality = 0;
                return;
            }

            item.Quality = Helper.ClampValue(++item.Quality);

            if (item.SellIn <= 10)
                item.Quality = Helper.ClampValue(++item.Quality);

            if (item.SellIn <= 5)
                item.Quality = Helper.ClampValue(++item.Quality);
        }
    }
}
