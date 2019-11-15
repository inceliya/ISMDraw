using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeLibrary;

namespace Peint
{
    public partial class Form1 : Form
    {

        int X, Y, X1, Y1, Rad, Width;
        protected List<Shape> shapes;
        protected Mode Mode;
        protected byte size = 4;
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBox.Refresh();
        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
           if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog1.Color;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            shapes = new List<Shape>();
            Mode = Mode.DrawPoint;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach(Shape sh in shapes)
            {
                sh.Draw(e.Graphics);
            }
            switch (Mode)
            {
                case Mode.DrawLine:
                    Line line = new Line(X, Y, Color.Black, 2, X1, Y1);
                    line.Draw(e.Graphics);
                    //e.Graphics.DrawLine(new Pen(buttonColor.BackColor, 2), X, Y, X1, Y1);
                    break;
                case Mode.DrawCircle:
                    Circle circle = new Circle(X, Y, Color.Black, 2, Rad);
                    circle.Draw(e.Graphics);
                    //e.Graphics.DrawEllipse(new Pen(buttonColor.BackColor, 2), X - Rad/2, Y - Rad/2, Rad, Rad);
                    break;
                case Mode.DrawRectangle:
                    ShapeLibrary.Rectangle rectangle = new ShapeLibrary.Rectangle(X, Y, Color.Black, 2, X1, Y1);
                    rectangle.Draw(e.Graphics);
                    break;
                case Mode.DrawEllipse:
                    ShapeLibrary.Elipse elipse = new ShapeLibrary.Elipse(X, Y, Color.Black, 2, Rad, Width);
                    elipse.Draw(e.Graphics);
                    break;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
                for(int i = 0; i<listBoxShapes.Items.Count; i++)
                {
                    if (listBoxShapes.GetSelected(i))
                    {
                        DeleteShape(i);
                        i--;
                        listBoxShapes.SelectedIndex = i;
                    }
                }
        }

        public void DeleteShape(int number)
        {
            shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBox.Refresh();
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics gr = pictureBox.CreateGraphics();
            if (e.Button == MouseButtons.Left)
            {
                switch (Mode)
                {
                    case Mode.DrawLine:
                        X1 = e.X;
                        Y1 = e.Y;
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawCircle:
                        Rad = Math.Abs(X - e.X);
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawRectangle:
                        X1 = e.X;
                        Y1 = e.Y;
                        pictureBox.Refresh();
                        break;
                    case Mode.DrawEllipse:
                        Rad = Math.Abs(Y-e.Y); Width = Math.Abs(X-e.X);
                        pictureBox.Refresh();
                        break;
                }
            }
            
        }

        private void ButtonRectangle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }

        private void ButtonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    Line line = new Line(X, Y, buttonColor.BackColor, size, X1, Y1);
                    AddShape(line);
                    X = 0; Y = 0; X1 = 0; Y1 = 0;
                    pictureBox.Refresh();
                    break;
                case Mode.DrawCircle:
                    Circle circle = new Circle(X, Y, buttonColor.BackColor, size, Rad);
                    AddShape(circle);
                    X = 0; Y = 0; Rad = 0;
                    pictureBox.Refresh();
                    break;
                case Mode.DrawRectangle:
                    ShapeLibrary.Rectangle rectangle = new ShapeLibrary.Rectangle(X, Y, buttonColor.BackColor, size, X1, Y1);
                    AddShape(rectangle);
                    X = 0; Y = 0; X1 = 0; Y1 = 0;
                    pictureBox.Refresh();
                    break;
                case Mode.DrawEllipse:
                    ShapeLibrary.Elipse elipse = new Elipse(X, Y, buttonColor.BackColor, size, Rad, Width);
                    AddShape(elipse);
                    X = 0; Y = 0; Rad = 0; Width = 0;
                    pictureBox.Refresh();
                    break;
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            switch(Mode)
            {
                case Mode.DrawPoint:
                    ShapeLibrary.Point point = new ShapeLibrary.Point(e.X, e.Y, buttonColor.BackColor, size);
                    AddShape(point);
                    break;
                case Mode.DrawLine:
                    X = e.X; Y = e.Y; X1 = e.X; Y1 = e.Y;
                    break;
                case Mode.DrawCircle:
                    X = e.X; Y = e.Y; Rad = 2;
                    break;
                case Mode.DrawRectangle:
                    X = e.X; Y = e.Y; X1 = e.X; Y1 = e.Y;
                    break;
                case Mode.DrawEllipse:
                    X = e.X; Y = e.Y; Rad = 2; Width = 2;
                    break;
            }
        }

        private void ButtonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void ButtonCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }
    }
}
