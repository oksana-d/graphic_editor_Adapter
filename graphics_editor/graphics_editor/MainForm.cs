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
    public partial class MainForm : Form
    {
        private CircleForm CircleHolst;
        private RectangularForm RectangularHolst;
        public MainForm()
        {
            InitializeComponent();
        }

        private void создатьКруглыйХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CircleHolst = new CircleForm();
            CircleHolst.MdiParent = this;
            CircleHolst.Show();
        }

        private void создатьПрямоугольныйХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RectangularHolst = new RectangularForm();
            RectangularHolst.MdiParent = this;
            RectangularHolst.Show();
        }
    }
}
