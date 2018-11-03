using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    class Rectangle
    {
        private Point topLeft;
        private Point bottomRight;

        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.bottomRight = bottomRight;
        }

        public Point TopLeft
        {
            get { return this.topLeft; }
            set { this.topLeft = value; }
        }

        public Point BottomRight
        {
            get { return this.bottomRight; }
            set { this.bottomRight = value; }
        }

        public bool Contains(Point point)
        {
            bool isInHorizontal = this.TopLeft.X <= point.X && this.BottomRight.X >= point.X;

            bool isInVertical = this.TopLeft.Y <= point.Y && this.BottomRight.Y >= point.Y;

            bool isInRectangle = isInHorizontal && isInVertical;

            return isInRectangle;
        }
    }
}
