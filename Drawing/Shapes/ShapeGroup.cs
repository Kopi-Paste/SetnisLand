using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.Shapes
{
    class ShapeGroup : Shape, IBuildable, IEnumerable<Shape>
    {
        public ShapeGroup(int horizontalPosition, int verticalPosition) : base(horizontalPosition, verticalPosition, 0, 0)
        {

        }

        List<Shape> shapesCollection = new List<Shape>();

        public void Add(Shape shape)
        {
            shapesCollection.Add(shape);
        }



        public IEnumerator<Shape> GetEnumerator()
        {
            return shapesCollection.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return shapesCollection.GetEnumerator();
        }
    }
}
