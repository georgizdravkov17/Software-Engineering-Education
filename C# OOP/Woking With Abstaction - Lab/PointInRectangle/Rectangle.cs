using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point firstPoint, Point secondPoint)
        {
            this.FirstPoint = firstPoint;
            this.SecondPoint = secondPoint;
        }

        public Point FirstPoint { get; private set; }

        public Point SecondPoint { get; private set; }
    }
}
