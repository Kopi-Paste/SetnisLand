using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawing.Shapes
{
   abstract class Shape
    {
        public Shape(int horizontalPosition, int verticalPosition, int scaleX, int scaleY)
        {
            if (horizontalPosition < 0 || verticalPosition < 0)
                throw new ArgumentException("Incorrect position!");
            if (scaleX <= 0 || scaleY <= 0)
                throw new ArgumentException("Incorrect scale!");

            this.Position.HorizontalPosition = horizontalPosition;
            this.Position.VerticalPosition = verticalPosition;
            this.Scale.ScaleX = scaleX;
            this.Scale.ScaleY = scaleY;
        }

        public Position Position { get; private set; }

        public Scale Scale { get; private set; }


        protected Shape PartOf { get; set; } = null;
    }
}
