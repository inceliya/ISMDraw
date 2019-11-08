using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Elipse: Circle
    {
        protected float Width;
        public Elipse() : base()
        {
            Width = 0;
        }
        public Elipse(Elipse elipse) : base(elipse)
        {
            Width = elipse.Width;
        }
        public Elipse(float x, float y, Color color, byte size, float rad, float width) : base(x,y, color, size, rad)
        {
            SetWidth(width);
        }
        public void SetWidth(float width)
        {
            Width = width;
        }
        public float GetWidth()
        {
            return Width;
        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, Size);
            graphics.DrawEllipse(pen, X-Width/2, Y-Rad/2, Width, Rad);
        }
        public override void Moov(float dx, float dy)
        {
            base.Moov(dx, dy);
        }
    }
}
