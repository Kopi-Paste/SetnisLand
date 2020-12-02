using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Drawing.Shapes;

namespace Drawing
{
    interface IBuildable
    {
        void Add(Shape shape);
    }
}
