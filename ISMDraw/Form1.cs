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
        List <Shape> shapes = new List<Shape>();
        Random rnd = new Random();
        Color color;
        Graphics graphics;
        int DrawX;
        int DrawY;
        int DrawX1;
        int DrawY1;
        bool MClick = false;

        public Drawing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            graphics = pictureBox.CreateGraphics();
            shapes = new List<Shape>();
            SetColor(out Color color);
            for (int i = 0; i < trackBar.Value; i++)
            {
                int shape = rnd.Next(0, 5);
                ShapesList(shape, color);
            }
            pictureBox.Refresh();
        }

        byte size = 6;
        private void ShapesList(int shape, Color color)
        {
                int x = rnd.Next(0, pictureBox.Width);
                int y = rnd.Next(0, pictureBox.Height);
            switch (shape)
                {
                    case 0:
                        {
                            shapes.Add(new ShapeLibrary.Point(x, y, color, size));
                        }
                        break;
                    case 1:
                        {
                            shapes.Add(new Line(x, y, color, size, rnd.Next(0, pictureBox.Width), rnd.Next(0, pictureBox.Height)));
                        }
                        break;
                    case 2:
                        {
                            shapes.Add(new ShapeLibrary.Rectangle(x, y, color, size, rnd.Next(0, pictureBox.Width), rnd.Next(0, pictureBox.Height)));
                        }
                        break;
                    case 3:
                        {
                            shapes.Add(new Circle(x, y, color, size, rnd.Next(0, pictureBox.Width) / 5));
                        }
                        break;
                    case 4:
                        {
                            shapes.Add(new Elipse(x, y, color, size, rnd.Next(0, pictureBox.Width) / 5, rnd.Next(0, pictureBox.Width) / 5));
                        }
                        break;
                }
            
        }

        private void ButtonClean_Click(object sender, EventArgs e)
        {
            shapes.Clear();
            pictureBox.Refresh();
        }

        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (shapes != null)
            {
                for (int i = 0; i < shapes.Count; i++)
                     shapes[i].Draw(e.Graphics);
            }

        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if(shapes.Count>0)
            shapes.RemoveAt(shapes.Count-1);
            pictureBox.Refresh();
        }

        private void SetColor(out Color color)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            else color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxShape.SelectedItem == null) {
                MessageBox.Show("Выберите фигуру", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                    }
            SetColor(out Color color);
            ShapesList(comboBoxShape.SelectedIndex, color);
            pictureBox.Refresh();
        }

        private void ButtonMoov_Click(object sender, EventArgs e)
        {
            
                shapes[shapes.Count - 1].Moov((float)numericUpDownX.Value, (float)numericUpDownY.Value);
                pictureBox.Refresh();
 
        }

        private void Drawing_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void Drawing_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void Drawing_MouseUp(object sender, MouseEventArgs e)
        {
           
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MClick = true;
            DrawX1 = e.X;
            DrawY1 = e.Y;

        }

        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MClick = false;
            //SetColor(out Color color);
            //shapes.Add(new Line(DrawX, DrawY, color, size, DrawX1, DrawY1));
            pictureBox.Refresh();
            label1.Text = Convert.ToString(shapes.Count);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (MClick)
            {
                DrawX = DrawX1;
                DrawY = DrawY1;
                DrawX1 = e.X;
                DrawY1 = e.Y;
                shapes.Add(new Line(DrawX, DrawY, color, size, DrawX1, DrawY1));
                pictureBox.Refresh();
                //shapes.RemoveAt(shapes.Count - 1);
            }

        }

        private void ButtonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog1.Color;
            }
            else color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
        }
    }
}