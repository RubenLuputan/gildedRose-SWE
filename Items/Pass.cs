using csharp.Visitors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Items
{
    public class Pass : Item
    {
        public override void Update(IVisitorStrategy visitor)
        {
            visitor.Visit(this);
        }
    }
}
