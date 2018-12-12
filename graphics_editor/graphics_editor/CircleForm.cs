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
    public partial class CircleForm : AbstractHolst
    {
        Bitmap bmp;
        static Color CurrentColor = Color.Black;
        Graphics g;
        public static int size = 7;
        int x = -1;
        int y = -1;
        bool moving = false;
        CirclePen circlePen;
        Pen pen;

        public CircleForm()
        {
            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, 400, 400);
            Region region = new Region(path);
            pictureBox1.Region = region;
            pen = new Pen(CurrentColor,size);
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            circlePen = new CirclePen();
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(pictureBox1.Image);
            g.SetClip(region, System.Drawing.Drawing2D.CombineMode.Replace);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);
        }

        private void touch(MouseEventArgs e)
        {
            SolidBrush solidBrush = new SolidBrush(CurrentColor);
            g.FillEllipse(solidBrush, e.X, e.Y, size, size);
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
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void размерПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SizePen("circle").ShowDialog();
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
                g.DrawImage(bmp, new Rectangle(-400, 400, 2 * 400, 2 * 400), new Rectangle(-400, -400, 2 * 400, 2 * 400), GraphicsUnit.Pixel);
                try
                {
                    
                    bmp.Save(sfd.FileName);
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
            SolidBrush solidBrush = new SolidBrush(CurrentColor);
            g.FillEllipse(solidBrush, e.X, e.Y, size, size);
            x = e.X;
            y = e.Y;
            pictureBox1.Invalidate();
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
