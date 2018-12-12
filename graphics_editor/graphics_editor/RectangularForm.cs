using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_editor
{
    public partial class RectangularForm : AbstractHolst
    {
        private Bitmap bmp;
        static Color CurrentColor = Color.Black;
        public static int size = 5;
        private Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        RectangularPen rectangularPen;
        Pen pen;

        public RectangularForm()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            rectangularPen = new RectangularPen();
            pen = new Pen(CurrentColor, size);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
        }

        private void touch(MouseEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(CurrentColor);
            g.FillRectangle(solidBrush, e.X, e.Y, size, size);
            pictureBox1.Invalidate();
        }

        private void цветПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
            pen = new Pen(CurrentColor, size);
        }

        private void размерПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SizePen("rectangle").ShowDialog();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Invalidate();
        }

        private void сохранитьРисунокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Сохранить как...";
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            sfd.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.PNG)|*.PNG";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image.Save(sfd.FileName);
                }
                catch
                {
                    MessageBox.Show("Невозможно сохранить изображение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            touch(e);
            x = e.X;
            y = e.Y;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                touch(e);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = e.X;
            y = e.Y;
        }

        private void text_button_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.BorderStyle = BorderStyle.None;
            tb.Multiline = true;
            tb.Text = "text";

            Adapter textBox = new Adapter();
            textBox.text = tb;
            textBox.text.MouseMove += textBox1_MouseMove;
            textBox.text.MouseDown += textBox1_MouseDown;
            textBox.text.TextChanged += textBox.TextChange;


            Point pos = new Point(200, 100);
            tb.Location = pos;
            this.Controls.Add(tb);
            tb.BringToFront();
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // или любую другую, какая удобнее
            {
                Point pos = new Point();
                pos = new Point(Cursor.Position.X - x, Cursor.Position.Y - y);
                ((TextBox)sender).Location = PointToClient(pos);
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
        }
    }
}

