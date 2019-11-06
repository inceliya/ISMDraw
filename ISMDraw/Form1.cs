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


namespace ISMDraw
{
    public partial class Drawing : Form
    {
        Bitmap canvas;
        public Drawing()
        {
            InitializeComponent();
            canvas = new Bitmap(pictureBox.Width,
                                     pictureBox.Height);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Graphics graphics = pictureBox.CreateGraphics();
            Shape[] shapes = new Shape[trackBar.Value];
            byte size = 6;
            for(int i = 0; i<shapes.Length; i++)
            {
                int x = rnd.Next(0, pictureBox.Width);
                int y = rnd.Next(0, pictureBox.Height);
                Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
                int shape = rnd.Next(0, 5);
                switch(shape)
                {
                    case 0:
                        {
                            shapes[i] = new ShapeLibrary.Point(x, y, color, size);
                        }break;
                    case 1:
                        {
                            shapes[i] = new Line(x, y, color, size, rnd.Next(0, pictureBox.Width), rnd.Next(0, pictureBox.Height));
                        }break;
                    case 2:
                        {
                            shapes[i] = new ShapeLibrary.Rectangle(x, y, color, size, rnd.Next(0, pictureBox.Width), rnd.Next(0, pictureBox.Height));
                        }break;
                    case 3:
                        {
                            shapes[i] = new Circle(x, y, color, size, rnd.Next(0, pictureBox.Width) / 5);
                        }break;
                    case 4:
                        {
                            shapes[i] = new Elipse(x, y, color, size, rnd.Next(0, pictureBox.Width) / 5, rnd.Next(0, pictureBox.Width) / 5);
                        }break;
                }
            }
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].Draw(graphics);
            }
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
