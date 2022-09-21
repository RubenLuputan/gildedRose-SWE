using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            item.Quality++;

            if (item.SellIn <= 10)
                item.Quality++;

            if (item.SellIn <= 5)
                item.Quality++;
        }
    }
}
