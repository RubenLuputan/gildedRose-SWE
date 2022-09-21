using System.Collections.Generic;
using csharp.Items;
using csharp.Visitors;

namespace csharp
{
    public class GildedRose
    {
        IList<Item> Items;
        DecreasingVisitor decVisitor = new DecreasingVisitor();
        IncreasingVisitor incVisitor = new IncreasingVisitor();
        PassVisitor passVisitor = new PassVisitor();

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        //reduce nesting, decouple stuff, auslagern, erweiterbar machen, etc.

        public void UpdateQuality()
        {
            foreach (var item in Items)
            {
                if (item is LegendaryItem)
                    continue;
                
                if (item is IncreasingQualityItem)
                {
                    item.Update(incVisitor);
                    continue;
                }
                else if (item is DecreasingQualityItem)
                {
                    item.Update(decVisitor);
                    continue;
                }

                item.Update(passVisitor);
            }
        }
    }
}
