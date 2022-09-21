﻿using csharp.Items;

namespace csharp.Visitors
{
    public class DecreasingVisitor : IVisitorStrategy
    {
        public void Visit(Item item)
        {
            item.SellIn--;
            item.Quality--;

            if (item.SellIn <= 0)
                item.Quality--;
        }
    }
}