using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CirclePackingAnimator
{
    public partial class Form1 : Form
    {
        private const int WIDTH = 853;
        private const int HEIGHT = 729;

        private Bitmap bm;
        private Graphics graphics;
        private List<Circle> circles;
        private Timer fpsTimer;
        private Timer newCircleTimer;
        private Random r;

        private bool randomPos;
        private bool randomCol;
        private bool clearOnChange = true;
        private bool fill;

        public Form1()
        {
            InitializeComponent();

            bm = new Bitmap(WIDTH, HEIGHT);
            graphics = Graphics.FromImage(bm);
            circles = new List<Circle>();
            r = new Random();

            fpsTimer = new Timer();
            fpsTimer.Interval = 1;
            fpsTimer.Tick += Timer_Tick;
            fpsTimer.Enabled = true;

            newCircleTimer = new Timer();
            newCircleTimer.Interval = int.Parse(tb_Speed.Text);
            newCircleTimer.Tick += NewCircle_Tick;
            newCircleTimer.Enabled = false;
        }

        // Main timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Grow circles
            foreach (Circle c in circles)
                c.Grow();

            // Update the display
            drawingSurface.Invalidate();
        }

        // Create circle timer
        private void NewCircle_Tick(object sender, EventArgs e)
        {
            circles.Add(new Circle(randomPos ? r.Next(WIDTH) : WIDTH / 2, 
                randomPos ? r.Next(HEIGHT) : HEIGHT / 2, 
                randomCol ? Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)) : Color.White, 
                fill));
        }

        // Draw event
        private void drawingSurface_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bm, 0, 0);

            foreach (Circle c in circles)
            {
                c.Render(e.Graphics);
            }
        }

        // Adjust speed in trackbar
        private void trackBar_Speed_ValueChanged(object sender, EventArgs e)
        {
            tb_Speed.Text = (trackBar_Speed.Value).ToString();
        }

        // Adjust speed in textbox
        private void tb_Speed_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_Speed.Text, @"^(\d+)$"))
            {
                trackBar_Speed.Value = int.Parse(tb_Speed.Text);
                newCircleTimer.Interval = trackBar_Speed.Value;

                if (clearOnChange)
                    ClearScreen();
            }
            else
                MessageBox.Show("Value not valid!", "Error", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
        }

        // Toggle the generation of circles
        private void cb_CreateCircles_CheckedChanged(object sender, EventArgs e)
        {
            newCircleTimer.Enabled = cb_CreateCircles.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Update randomPos
        private void cb_RandomPos_CheckedChanged(object sender, EventArgs e)
        {
            randomPos = cb_RandomPos.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Update randomCol
        private void cb_RandomColour_CheckedChanged(object sender, EventArgs e)
        {
            randomCol = cb_RandomColour.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Update clearOnChecked
        private void cb_ClearOnChange_CheckedChanged(object sender, EventArgs e)
        {
            clearOnChange = cb_ClearOnChange.Checked;
        }

        // Clear the screen
        private void ClearScreen()
        {
            circles.Clear();
            drawingSurface.Invalidate();
        }

        // Update fill
        private void cb_Fill_CheckedChanged(object sender, EventArgs e)
        {
            fill = cb_Fill.Checked;
        }
    }
}
