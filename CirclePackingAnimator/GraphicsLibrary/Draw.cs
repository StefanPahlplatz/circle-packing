using System.Drawing;
using System.Windows.Forms;

namespace GraphicsLibrary
{
    public static class Draw
    {
        public static void Circle(this Graphics g, Pen pen, float x, float y, float r)
        {
            g.DrawEllipse(pen, Rect(x, y, r));
        }

        public static void FillCircle(this Graphics g, Brush b, float x, float y, float r)
        {
            g.FillEllipse(b, Rect(x, y, r));
        }

        private static RectangleF Rect(float x, float y, float r)
        {
            return new RectangleF(x - r, y - r, r * 2, r * 2);
        }
    }
}
