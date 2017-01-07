using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CirclePackingAnimator
{
    public partial class Form1 : Form
    {
        private const int MAX_WIDTH = 853;
        private const int MAX_HEIGHT = 729;

        private Bitmap bm;
        private Graphics graphics;
        private List<Circle> circles;
        private Timer fpsTimer;
        private Timer newCircleTimer;
        private Random r;

        private bool randomPos;
        private bool randomCol;
        private bool fill;
        private bool clearOnChange;
        private bool allowOverlap;
        private bool usePicture;
        private bool done;
        private bool drawing;
        private bool drawBorders;
        private string imagePath;
        private int amountPerTick;
        private int width;
        private int height;

        #region Constructor
        public Form1()
        {
            InitializeComponent();

            // Create instances
            bm = new Bitmap(MAX_WIDTH, MAX_HEIGHT);
            graphics = Graphics.FromImage(bm);
            circles = new List<Circle>();
            r = new Random();

            // Default values
            clearOnChange = true;
            amountPerTick = trackBar_AmountPerTick.Value;
            width = (int)nud_Width.Value;
            height = (int)nud_Height.Value;

            // Init FPS timer
            fpsTimer = new Timer();
            fpsTimer.Interval = 1;
            fpsTimer.Tick += Timer_Tick;
            fpsTimer.Enabled = true;

            // Init new circle timer
            newCircleTimer = new Timer();
            newCircleTimer.Interval = int.Parse(tb_Speed.Text);
            newCircleTimer.Tick += NewCircle_Tick;
            newCircleTimer.Enabled = false;

            // Tooltips
            tt_Speed_TrackBar.SetToolTip(this.trackBar_Speed, "Interval between ticks in ms.");
            tt_Speed_Tb.SetToolTip(tb_Speed, "Interval between ticks in ms.");
            tt_Amount_TrackBar.SetToolTip(trackBar_AmountPerTick, "Amount of circles to generate per tick.");
            tt_Amount_Tb.SetToolTip(tb_AmountPerTick, "Amount of circles to generate per tick.");
            tt_ShowBorders.SetToolTip(cb_ShowBorders, "Toggels the outline of the borders. Does not trigger 'Clear On Change'.");
        }
        #endregion

        #region Timers
        // Main timer
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check collisions
            if (!allowOverlap)
            foreach (Circle c1 in circles)
                foreach (Circle c2 in circles)
                    c1.IsCollision(c2);

            // Grow circles
            foreach (Circle c in circles)
                c.Grow();

            // Update the display
            drawingSurface.Invalidate();
        }

        // Create circle timer
        private void NewCircle_Tick(object sender, EventArgs e)
        {
            // If we have not passed the attempts limit yet
            if (!done)  
            {
                // If we are not already busy drawing a previous loop
                if (!drawing)   
                {
                    drawing = true;
                    int attempts = 0;

                    for (int i = 0; i < amountPerTick; i++)
                    {
                        // If we're stuck in the loop
                        if (attempts > 10000)
                        {
                            Console.WriteLine("Done");
                            done = true;
                            drawing = false;
                            return;
                        }

                        // Create a random circle
                        Circle circle = new Circle(randomPos ? r.Next(width) : width / 2,
                            randomPos ? r.Next(height) : height / 2,
                            randomCol ? Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)) : Color.White,
                            fill, width, height);

                        // Check collision
                        bool noCollision = true;
                        if (!allowOverlap)
                        {
                            foreach (Circle c2 in circles)
                            {
                                if (circle.IsCollision(c2))
                                {
                                    noCollision = false;
                                    i--;
                                    attempts++;
                                }
                            }
                        }

                        if (noCollision)
                            circles.Add(circle);
                    }
                    drawing = false;
                }
            }
        }
        #endregion

        #region Draw
        // Draw event
        private void drawingSurface_Paint(object sender, PaintEventArgs e)
        {
            // Draw the canvas
            e.Graphics.DrawImage(bm, 0, 0);

            // Draw all circles
            foreach (Circle c in circles)
                c.Render(e.Graphics);

            // Draw the outline
            if (drawBorders)
                e.Graphics.DrawRectangle(Pens.White, 0, 0, width, height);
        }

        // Clear the screen
        private void ClearScreen()
        {
            circles.Clear();
            drawingSurface.Invalidate();
            done = false;
        }
        #endregion

        #region Update variables
        // Update speed in trackbar
        private void trackBar_Speed_ValueChanged(object sender, EventArgs e)
        {
            tb_Speed.Text = (trackBar_Speed.Value).ToString();
        }

        // Update speed in textbox
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

        // Toggle randomPos
        private void cb_RandomPos_CheckedChanged(object sender, EventArgs e)
        {
            randomPos = cb_RandomPos.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Toggle randomCol
        private void cb_RandomColour_CheckedChanged(object sender, EventArgs e)
        {
            randomCol = cb_RandomColour.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Toggle clearOnChecked
        private void cb_ClearOnChange_CheckedChanged(object sender, EventArgs e)
        {
            clearOnChange = cb_ClearOnChange.Checked;
        }

        // Update fill
        private void cb_Fill_CheckedChanged(object sender, EventArgs e)
        {
            fill = cb_Fill.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Update allow overlap
        private void cb_Overlap_CheckedChanged(object sender, EventArgs e)
        {
            allowOverlap = cb_Overlap.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        // Open file dialog
        private void tb_Path_Click(object sender, MouseEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | " +
                "*.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imagePath = openFileDialog.FileName;
                tb_Path.Text = imagePath;
            }
        }

        // Update custom picture
        private void cb_Picture_CheckedChanged(object sender, EventArgs e)
        {
            usePicture = cb_CustomPicture.Checked;

            if (clearOnChange)
                ClearScreen();
        }

        private void trackBar_AmountPerTick_ValueChanged(object sender, EventArgs e)
        {
            tb_AmountPerTick.Text = (trackBar_AmountPerTick.Value).ToString();
        }

        private void tb_AmountPerTick_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tb_AmountPerTick.Text, @"^(\d+)$"))
            {
                trackBar_AmountPerTick.Value = int.Parse(tb_AmountPerTick.Text);
                amountPerTick = trackBar_AmountPerTick.Value;

                if (clearOnChange)
                    ClearScreen();
            }
            else
                MessageBox.Show("Value not valid!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void nud_Width_ValueChanged(object sender, EventArgs e)
        {
            width = (int)nud_Width.Value;

            if (clearOnChange)
                ClearScreen();
        }

        private void nud_Height_ValueChanged(object sender, EventArgs e)
        {
            height = (int)nud_Height.Value;

            if (clearOnChange)
                ClearScreen();
        }

        private void cb_ShowBorders_CheckedChanged(object sender, EventArgs e)
        {
            drawBorders = cb_ShowBorders.Checked;
        }
        #endregion
    }
}
