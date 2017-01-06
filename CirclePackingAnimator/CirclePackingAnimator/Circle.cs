using System;
using System.Drawing;
using GraphicsLibrary;

namespace CirclePackingAnimator
{
    public class Circle
    {
        private static float DEFAULT_RADIUS = 2;
        private static float INCREASE_SIZE = 0.5f;
        private static int WIDTH = 853;
        private static int HEIGHT = 729;

        private float x;
        private float y;
        private float r;
        private Color c;
        private bool growing;
        private bool fill;

        private Circle()
        {
            r = DEFAULT_RADIUS;
            growing = true;
        }

        public Circle(float x, float y, Color c, bool fill) : this()
        {
            this.x = x;
            this.y = y;
            this.c = c;
            this.fill = fill;
        }

        // Draw the circel
        public void Render(Graphics g)
        {
            if (fill)
                Draw.FillCircle(g, new SolidBrush(c), x, y, r);
            else
                Draw.Circle(g, new Pen(c), x, y, r);
        }

        // Increase the radius
        public void Grow()
        {
            if (growing)
            {
                if (AtEdge())
                    growing = false;
                else
                    r += INCREASE_SIZE;
            }
        }

        // Checks if the circel is hitting the edge
        private bool AtEdge()
        {
            return x + r > WIDTH - 1|| x - r < 0 || y + r > HEIGHT - 1|| y - r < 0;
        }
    }
}
