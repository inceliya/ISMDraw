using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ShapeLibrary
{
    public abstract class Shape
    {
        protected float X;
        protected float Y;
        protected Color Color = new Color();
        protected byte Size;
        protected Random rnd = new Random();

        public Shape()
        {
            X = 0;
            Y = 0;
            Color = Color.Red;
            Size = 3;
        }

        public Shape(Shape shape)
        {
            X = shape.X;
            Y = shape.Y;
            Color = shape.Color;
            Size = shape.Size;
        }
        public Shape(float x, float y, Color color, byte size)
        {
            SetX(x);
            SetY(y);
            SetColor(color);
            SetSize(size);
        }
        public void SetX(float x)
        {
            X = x;
        }
        public void SetY(float y)
        {
            Y = y;
        }
        public void SetColor(Color color)
        {
            Color = color;
        }
        public void SetSize(byte size)
        {
            Size = size;
        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public Color GetColor()
        {
            return Color;
        }
        public byte GetSize()
        {
            return Size;
        }
        public abstract void Draw(Graphics graphics);
    }
}
