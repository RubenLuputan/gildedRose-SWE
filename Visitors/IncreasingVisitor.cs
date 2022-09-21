using csharp.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Visitors
{
    public class IncreasingVisitor : IVisitorStrategy
    {
        public void Visit(Item item)
        {
            item.SellIn--;
            item.Quality++;
        }
    }
}
