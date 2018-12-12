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
    public partial class SizePen : Form
    {
        private string str;
        public static int size;
        public SizePen(string s)
        {
            InitializeComponent();
            str = s;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            size = Convert.ToInt32(textBox1.Text);

            if (str == "circle")
            {
                if (size < 7 || size > 36)
                {
                    MessageBox.Show("Попробуйте другой размер :)", "Упс");
                }
                else CircleForm.size = size;
            }

            if (str == "rectangle")
            {
                if (size < 5 || size > 36)
                {
                    MessageBox.Show("Попробуйте другой размер :)", "Упс");
                }
                else RectangularForm.size = size;
            }
            this.Close();
        }
    }
}
