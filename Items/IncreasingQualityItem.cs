using csharp.Visitors;

namespace csharp.Items
{
    public class IncreasingQualityItem : Item
    {
        public override void Update(IVisitorStrategy visitor)
        {
            visitor.Visit(this);
        }
    }
}