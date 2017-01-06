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

        // Default constructor
        private Circle()
        {
            r = DEFAULT_RADIUS;
            growing = true;
        }

        public Circle(float x, float y, Color c) : this()
        {
            this.x = x;
            this.y = y;
            this.c = c;
        }

        public void Render(Graphics g)
        {
            Draw.Circle(g, new Pen(c), x, y, r);
        }

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

        private bool AtEdge()
        {
            return x + r > WIDTH - 1|| x - r < 0 || y + r > HEIGHT - 1|| y - r < 0;
        }
    }
}
