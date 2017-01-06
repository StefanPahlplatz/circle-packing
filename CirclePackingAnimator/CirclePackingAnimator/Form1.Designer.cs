namespace CirclePackingAnimator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.drawingSurface = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ClearOnChange = new System.Windows.Forms.CheckBox();
            this.cb_CreateCircles = new System.Windows.Forms.CheckBox();
            this.tb_Speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.cb_RandomColour = new System.Windows.Forms.CheckBox();
            this.cb_RandomPos = new System.Windows.Forms.CheckBox();
            this.cb_Fill = new System.Windows.Forms.CheckBox();
            this.cb_Overlap = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSurface)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingSurface
            // 
            this.drawingSurface.BackColor = System.Drawing.Color.Black;
            this.drawingSurface.Location = new System.Drawing.Point(0, 0);
            this.drawingSurface.Name = "drawingSurface";
            this.drawingSurface.Size = new System.Drawing.Size(853, 729);
            this.drawingSurface.TabIndex = 1;
            this.drawingSurface.TabStop = false;
            this.drawingSurface.Paint += new System.Windows.Forms.PaintEventHandler(this.drawingSurface_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Overlap);
            this.groupBox1.Controls.Add(this.cb_Fill);
            this.groupBox1.Controls.Add(this.cb_ClearOnChange);
            this.groupBox1.Controls.Add(this.cb_CreateCircles);
            this.groupBox1.Controls.Add(this.tb_Speed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.trackBar_Speed);
            this.groupBox1.Controls.Add(this.cb_RandomColour);
            this.groupBox1.Controls.Add(this.cb_RandomPos);
            this.groupBox1.Location = new System.Drawing.Point(859, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 322);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // cb_ClearOnChange
            // 
            this.cb_ClearOnChange.AutoSize = true;
            this.cb_ClearOnChange.Checked = true;
            this.cb_ClearOnChange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ClearOnChange.Location = new System.Drawing.Point(6, 88);
            this.cb_ClearOnChange.Name = "cb_ClearOnChange";
            this.cb_ClearOnChange.Size = new System.Drawing.Size(104, 17);
            this.cb_ClearOnChange.TabIndex = 6;
            this.cb_ClearOnChange.Text = "Clear on change";
            this.cb_ClearOnChange.UseVisualStyleBackColor = true;
            this.cb_ClearOnChange.CheckedChanged += new System.EventHandler(this.cb_ClearOnChange_CheckedChanged);
            // 
            // cb_CreateCircles
            // 
            this.cb_CreateCircles.AutoSize = true;
            this.cb_CreateCircles.Location = new System.Drawing.Point(6, 19);
            this.cb_CreateCircles.Name = "cb_CreateCircles";
            this.cb_CreateCircles.Size = new System.Drawing.Size(90, 17);
            this.cb_CreateCircles.TabIndex = 5;
            this.cb_CreateCircles.Text = "Create circles";
            this.cb_CreateCircles.UseVisualStyleBackColor = true;
            this.cb_CreateCircles.CheckedChanged += new System.EventHandler(this.cb_CreateCircles_CheckedChanged);
            // 
            // tb_Speed
            // 
            this.tb_Speed.Location = new System.Drawing.Point(93, 189);
            this.tb_Speed.Name = "tb_Speed";
            this.tb_Speed.Size = new System.Drawing.Size(38, 20);
            this.tb_Speed.TabIndex = 4;
            this.tb_Speed.Text = "500";
            this.tb_Speed.TextChanged += new System.EventHandler(this.tb_Speed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Creation speed:";
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.Location = new System.Drawing.Point(12, 208);
            this.trackBar_Speed.Maximum = 1000;
            this.trackBar_Speed.Minimum = 1;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(104, 45);
            this.trackBar_Speed.TabIndex = 2;
            this.trackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Speed.Value = 500;
            this.trackBar_Speed.ValueChanged += new System.EventHandler(this.trackBar_Speed_ValueChanged);
            // 
            // cb_RandomColour
            // 
            this.cb_RandomColour.AutoSize = true;
            this.cb_RandomColour.Location = new System.Drawing.Point(6, 65);
            this.cb_RandomColour.Name = "cb_RandomColour";
            this.cb_RandomColour.Size = new System.Drawing.Size(98, 17);
            this.cb_RandomColour.TabIndex = 1;
            this.cb_RandomColour.Text = "Random colour";
            this.cb_RandomColour.UseVisualStyleBackColor = true;
            this.cb_RandomColour.CheckedChanged += new System.EventHandler(this.cb_RandomColour_CheckedChanged);
            // 
            // cb_RandomPos
            // 
            this.cb_RandomPos.AutoSize = true;
            this.cb_RandomPos.Location = new System.Drawing.Point(6, 42);
            this.cb_RandomPos.Name = "cb_RandomPos";
            this.cb_RandomPos.Size = new System.Drawing.Size(110, 17);
            this.cb_RandomPos.TabIndex = 0;
            this.cb_RandomPos.Text = "Random positions";
            this.cb_RandomPos.UseVisualStyleBackColor = true;
            this.cb_RandomPos.CheckedChanged += new System.EventHandler(this.cb_RandomPos_CheckedChanged);
            // 
            // cb_Fill
            // 
            this.cb_Fill.AutoSize = true;
            this.cb_Fill.Location = new System.Drawing.Point(6, 111);
            this.cb_Fill.Name = "cb_Fill";
            this.cb_Fill.Size = new System.Drawing.Size(38, 17);
            this.cb_Fill.TabIndex = 7;
            this.cb_Fill.Text = "Fill";
            this.cb_Fill.UseVisualStyleBackColor = true;
            this.cb_Fill.CheckedChanged += new System.EventHandler(this.cb_Fill_CheckedChanged);
            // 
            // cb_Overlap
            // 
            this.cb_Overlap.AutoSize = true;
            this.cb_Overlap.Location = new System.Drawing.Point(6, 134);
            this.cb_Overlap.Name = "cb_Overlap";
            this.cb_Overlap.Size = new System.Drawing.Size(89, 17);
            this.cb_Overlap.TabIndex = 8;
            this.cb_Overlap.Text = "Allow overlap";
            this.cb_Overlap.UseVisualStyleBackColor = true;
            this.cb_Overlap.CheckedChanged += new System.EventHandler(this.cb_Overlap_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.drawingSurface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Circle Packing";
            ((System.ComponentModel.ISupportInitialize)(this.drawingSurface)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox drawingSurface;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cb_RandomPos;
        private System.Windows.Forms.CheckBox cb_RandomColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.TextBox tb_Speed;
        private System.Windows.Forms.CheckBox cb_CreateCircles;
        private System.Windows.Forms.CheckBox cb_ClearOnChange;
        private System.Windows.Forms.CheckBox cb_Fill;
        private System.Windows.Forms.CheckBox cb_Overlap;
    }
}

