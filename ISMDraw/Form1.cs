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
        public Drawing()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox.CreateGraphics();
            shapes = new List<Shape>();
            SetColor(out Color color);
            for (int i = 0; i < trackBar.Value; i++)
            {
                int shape = rnd.Next(0, 5);
                ShapesList(shape, color);
            }
            pictureBox.Refresh();
        }

        private void ShapesList(int shape, Color color)
        {
            byte size = 6;
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
            pictureBox.Image = null;
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

        private void ComboBoxShape_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void ButtonMoov_Click(object sender, EventArgs e)
        {
            
                shapes[shapes.Count - 1].Moov((float)numericUpDownX.Value, (float)numericUpDownY.Value);
                pictureBox.Refresh();
 
        }

        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //do something here
            }
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int x = 0, y = 0, x1 = 100, y1 = 100;
            if (e.Button == MouseButtons.Right)
            {
                x = Cursor.Position.X;
                y = Cursor.Position.Y;
            }
            shapes.Add(new Line(x, y, Color.Red, 8, x1, y1));
            pictureBox.Refresh();
        }
    }
}