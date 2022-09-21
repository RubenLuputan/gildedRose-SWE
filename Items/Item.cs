using csharp.Visitors;

namespace csharp.Items
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }

        private int _quality;
        public int Quality
        {
            get => _quality;
            set => _quality = (value < 0) ? 0 : (value > 50) ? 50 : value;
        }

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
