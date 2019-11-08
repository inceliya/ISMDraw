using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Point : Shape
    {
        public Point() : base()
        {

        }
        public Point(Point point) :base(point)
        {

        }
        public Point(float x, float y, Color color, byte size) :base(x, y, color, size)
        {

        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, Size);
            graphics.DrawEllipse(pen, X-1, Y-1, 2, 2);
        }
        public override void Moov(float dx, float dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
