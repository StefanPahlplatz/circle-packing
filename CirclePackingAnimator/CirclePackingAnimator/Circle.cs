using System;
using System.Drawing;
using GraphicsLibrary;

namespace CirclePackingAnimator
{
    public class Circle
    {
        private static float DEFAULT_RADIUS = 2;
        private static float INCREASE_SIZE = 0.5f;

        private readonly float x;
        private readonly float y;
        private float r;
        private readonly Color c;
        private bool growing;
        private readonly bool fill;
        private readonly int width;
        private readonly int height;

        private Circle()
        {
            r = DEFAULT_RADIUS;
            growing = true;
        }

        public Circle(float x, float y, Color c, bool fill, int max_width, int max_height) : this()
        {
            this.x = x;
            this.y = y;
            this.c = c;
            this.fill = fill;
            width = max_width;
            height = max_height;
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

        public bool IsCollision(Circle other)
        {
            if (other != this)
            {
                float deltaX = Math.Abs(this.x - other.x);
                float deltaY = Math.Abs(this.y - other.y);
                double dist = Math.Sqrt(Math.Pow(deltaX, 2) + Math.Pow(deltaY, 2));

                if (dist - 1 < this.r + other.r)
                {
                    this.growing = false;
                    return true;
                }
            }
            return false;
        }

        // Checks if the circel is hitting the edge
        private bool AtEdge()
        {
            return x + r > width - 1|| x - r < 0 || y + r > height - 1|| y - r < 0;
        }
    }
}
