using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graphics_editor
{
    abstract class AbstractFactory
    {
        public abstract AbstractHolst CreateHolst();
        public abstract AbstractPen CreatePen();
    }

    class ConcreteFactoryCircle : AbstractFactory
    {
        public override AbstractHolst CreateHolst()
        {
            return new CircleForm();
        }

        public override AbstractPen CreatePen()
        {
            return new CirclePen();
        }
    }
    class ConcreteFactoryRectangular : AbstractFactory
    {
        public override AbstractHolst CreateHolst()
        {
            return new RectangularForm();
        }


        public override AbstractPen CreatePen()
        {
            return new RectangularPen();
        }
    }

    public class AbstractHolst: Form
    {
    }

    abstract class AbstractPen
    {
        public Pen p;
        public abstract Pen CreatePen();
    }

    class CirclePen : AbstractPen
    {
        static Color currentColor;
        static int size;
        public override Pen CreatePen()
        {
            currentColor = Color.Black;
            size = 7;
            p = new Pen(currentColor, size);
            return p;
        }
    }

    class RectangularPen : AbstractPen
    {
        static Color currentColor;
        static int size;
        public override Pen CreatePen()
        {
            currentColor = Color.Black;
            size = 5;
            p = new Pen(currentColor, size);
            return p;
        }
    }


}

