using csharp.Visitors;

namespace csharp.Items
{
    public class DecreasingQualityItem : Item
    {
        public override void Update(IVisitorStrategy visitor)
        {
            visitor.Visit(this);
        }
    }
}