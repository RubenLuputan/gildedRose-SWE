using csharp.Visitors;

namespace csharp.Items
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public virtual void Update(IVisitorStrategy visitor)
        {
            visitor.Visit(this);
        }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }
    }
}
