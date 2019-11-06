using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public class Rectangle: Line
    {
        public Rectangle(): base()
        {

        }
        public Rectangle(Rectangle rectangle) : base(rectangle)
        {

        }
        public Rectangle(float x, float y, Color color, byte size, float x1, float y1) : base(x,y,color,size,x1,y1)
        {

        }
        public override void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color, Size);
            float Width, Height;
            if(X > X1)
            {
                X = X + X1;
                X1 = X - X1;
                X = X - X1;
            }
            if (Y > Y1)
            {
                Y = Y + Y1;
                Y1 = Y - Y1;
                Y = Y - Y1;
            }
            Width = X1 - X;
            Height = Y1 - Y;

            graphics.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
