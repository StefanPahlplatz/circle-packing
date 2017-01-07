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
            this.components = new System.ComponentModel.Container();
            this.drawingSurface = new System.Windows.Forms.PictureBox();
            this.grpBox_Settings = new System.Windows.Forms.GroupBox();
            this.cb_ShowBorders = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_Height = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_Width = new System.Windows.Forms.NumericUpDown();
            this.cb_Overlap = new System.Windows.Forms.CheckBox();
            this.cb_Fill = new System.Windows.Forms.CheckBox();
            this.cb_ClearOnChange = new System.Windows.Forms.CheckBox();
            this.cb_CreateCircles = new System.Windows.Forms.CheckBox();
            this.cb_RandomColour = new System.Windows.Forms.CheckBox();
            this.cb_RandomPos = new System.Windows.Forms.CheckBox();
            this.tb_AmountPerTick = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar_AmountPerTick = new System.Windows.Forms.TrackBar();
            this.tb_Speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_Speed = new System.Windows.Forms.TrackBar();
            this.grpBox_Picture = new System.Windows.Forms.GroupBox();
            this.tb_Path = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_CustomPicture = new System.Windows.Forms.CheckBox();
            this.tt_Speed_TrackBar = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Speed_Tb = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Amount_TrackBar = new System.Windows.Forms.ToolTip(this.components);
            this.tt_Amount_Tb = new System.Windows.Forms.ToolTip(this.components);
            this.grpBox_Timers = new System.Windows.Forms.GroupBox();
            this.tb_GrowSpeed = new System.Windows.Forms.TextBox();
            this.trackBar_GrowSpeed = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.tt_ShowBorders = new System.Windows.Forms.ToolTip(this.components);
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.drawingSurface)).BeginInit();
            this.grpBox_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AmountPerTick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).BeginInit();
            this.grpBox_Picture.SuspendLayout();
            this.grpBox_Timers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GrowSpeed)).BeginInit();
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
            // grpBox_Settings
            // 
            this.grpBox_Settings.Controls.Add(this.cb_ShowBorders);
            this.grpBox_Settings.Controls.Add(this.label5);
            this.grpBox_Settings.Controls.Add(this.nud_Height);
            this.grpBox_Settings.Controls.Add(this.label4);
            this.grpBox_Settings.Controls.Add(this.nud_Width);
            this.grpBox_Settings.Controls.Add(this.cb_Overlap);
            this.grpBox_Settings.Controls.Add(this.cb_Fill);
            this.grpBox_Settings.Controls.Add(this.cb_ClearOnChange);
            this.grpBox_Settings.Controls.Add(this.cb_CreateCircles);
            this.grpBox_Settings.Controls.Add(this.cb_RandomColour);
            this.grpBox_Settings.Controls.Add(this.cb_RandomPos);
            this.grpBox_Settings.Location = new System.Drawing.Point(859, 12);
            this.grpBox_Settings.Name = "grpBox_Settings";
            this.grpBox_Settings.Size = new System.Drawing.Size(137, 233);
            this.grpBox_Settings.TabIndex = 3;
            this.grpBox_Settings.TabStop = false;
            this.grpBox_Settings.Text = "Settings";
            // 
            // cb_ShowBorders
            // 
            this.cb_ShowBorders.AutoSize = true;
            this.cb_ShowBorders.Location = new System.Drawing.Point(6, 157);
            this.cb_ShowBorders.Name = "cb_ShowBorders";
            this.cb_ShowBorders.Size = new System.Drawing.Size(91, 17);
            this.cb_ShowBorders.TabIndex = 16;
            this.cb_ShowBorders.Text = "Show borders";
            this.cb_ShowBorders.UseVisualStyleBackColor = true;
            this.cb_ShowBorders.CheckedChanged += new System.EventHandler(this.cb_ShowBorders_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Height:";
            // 
            // nud_Height
            // 
            this.nud_Height.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Height.Location = new System.Drawing.Point(50, 206);
            this.nud_Height.Maximum = new decimal(new int[] {
            729,
            0,
            0,
            0});
            this.nud_Height.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Height.Name = "nud_Height";
            this.nud_Height.Size = new System.Drawing.Size(81, 20);
            this.nud_Height.TabIndex = 14;
            this.nud_Height.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Height.ValueChanged += new System.EventHandler(this.nud_Height_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Width:";
            // 
            // nud_Width
            // 
            this.nud_Width.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_Width.Location = new System.Drawing.Point(50, 180);
            this.nud_Width.Maximum = new decimal(new int[] {
            853,
            0,
            0,
            0});
            this.nud_Width.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_Width.Name = "nud_Width";
            this.nud_Width.Size = new System.Drawing.Size(81, 20);
            this.nud_Width.TabIndex = 12;
            this.nud_Width.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_Width.ValueChanged += new System.EventHandler(this.nud_Width_ValueChanged);
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
            // tb_AmountPerTick
            // 
            this.tb_AmountPerTick.Location = new System.Drawing.Point(93, 65);
            this.tb_AmountPerTick.Name = "tb_AmountPerTick";
            this.tb_AmountPerTick.Size = new System.Drawing.Size(38, 20);
            this.tb_AmountPerTick.TabIndex = 11;
            this.tb_AmountPerTick.Text = "1";
            this.tb_AmountPerTick.TextChanged += new System.EventHandler(this.tb_AmountPerTick_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Amount per tick:";
            // 
            // trackBar_AmountPerTick
            // 
            this.trackBar_AmountPerTick.AutoSize = false;
            this.trackBar_AmountPerTick.Location = new System.Drawing.Point(12, 91);
            this.trackBar_AmountPerTick.Maximum = 100;
            this.trackBar_AmountPerTick.Minimum = 1;
            this.trackBar_AmountPerTick.Name = "trackBar_AmountPerTick";
            this.trackBar_AmountPerTick.Size = new System.Drawing.Size(104, 24);
            this.trackBar_AmountPerTick.TabIndex = 9;
            this.trackBar_AmountPerTick.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_AmountPerTick.Value = 1;
            this.trackBar_AmountPerTick.ValueChanged += new System.EventHandler(this.trackBar_AmountPerTick_ValueChanged);
            // 
            // tb_Speed
            // 
            this.tb_Speed.Location = new System.Drawing.Point(93, 14);
            this.tb_Speed.Name = "tb_Speed";
            this.tb_Speed.Size = new System.Drawing.Size(38, 20);
            this.tb_Speed.TabIndex = 4;
            this.tb_Speed.Text = "16";
            this.tb_Speed.TextChanged += new System.EventHandler(this.tb_Speed_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interval ticks:";
            // 
            // trackBar_Speed
            // 
            this.trackBar_Speed.AutoSize = false;
            this.trackBar_Speed.Location = new System.Drawing.Point(12, 39);
            this.trackBar_Speed.Maximum = 1000;
            this.trackBar_Speed.Minimum = 1;
            this.trackBar_Speed.Name = "trackBar_Speed";
            this.trackBar_Speed.Size = new System.Drawing.Size(104, 26);
            this.trackBar_Speed.TabIndex = 2;
            this.trackBar_Speed.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar_Speed.Value = 500;
            this.trackBar_Speed.ValueChanged += new System.EventHandler(this.trackBar_Speed_ValueChanged);
            // 
            // grpBox_Picture
            // 
            this.grpBox_Picture.Controls.Add(this.tb_Path);
            this.grpBox_Picture.Controls.Add(this.label3);
            this.grpBox_Picture.Controls.Add(this.cb_CustomPicture);
            this.grpBox_Picture.Location = new System.Drawing.Point(859, 442);
            this.grpBox_Picture.Name = "grpBox_Picture";
            this.grpBox_Picture.Size = new System.Drawing.Size(137, 66);
            this.grpBox_Picture.TabIndex = 4;
            this.grpBox_Picture.TabStop = false;
            this.grpBox_Picture.Text = "Custom picture";
            // 
            // tb_Path
            // 
            this.tb_Path.Location = new System.Drawing.Point(44, 36);
            this.tb_Path.Name = "tb_Path";
            this.tb_Path.ReadOnly = true;
            this.tb_Path.Size = new System.Drawing.Size(87, 20);
            this.tb_Path.TabIndex = 14;
            this.tb_Path.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tb_Path_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Path:";
            // 
            // cb_CustomPicture
            // 
            this.cb_CustomPicture.AutoSize = true;
            this.cb_CustomPicture.Location = new System.Drawing.Point(6, 19);
            this.cb_CustomPicture.Name = "cb_CustomPicture";
            this.cb_CustomPicture.Size = new System.Drawing.Size(96, 17);
            this.cb_CustomPicture.TabIndex = 12;
            this.cb_CustomPicture.Text = "Custom picture";
            this.cb_CustomPicture.UseVisualStyleBackColor = true;
            this.cb_CustomPicture.CheckedChanged += new System.EventHandler(this.cb_Picture_CheckedChanged);
            // 
            // grpBox_Timers
            // 
            this.grpBox_Timers.Controls.Add(this.tb_GrowSpeed);
            this.grpBox_Timers.Controls.Add(this.trackBar_GrowSpeed);
            this.grpBox_Timers.Controls.Add(this.label6);
            this.grpBox_Timers.Controls.Add(this.trackBar_Speed);
            this.grpBox_Timers.Controls.Add(this.label1);
            this.grpBox_Timers.Controls.Add(this.tb_Speed);
            this.grpBox_Timers.Controls.Add(this.trackBar_AmountPerTick);
            this.grpBox_Timers.Controls.Add(this.tb_AmountPerTick);
            this.grpBox_Timers.Controls.Add(this.label2);
            this.grpBox_Timers.Location = new System.Drawing.Point(859, 251);
            this.grpBox_Timers.Name = "grpBox_Timers";
            this.grpBox_Timers.Size = new System.Drawing.Size(137, 185);
            this.grpBox_Timers.TabIndex = 5;
            this.grpBox_Timers.TabStop = false;
            this.grpBox_Timers.Text = "Timers";
            // 
            // tb_GrowSpeed
            // 
            this.tb_GrowSpeed.Location = new System.Drawing.Point(93, 117);
            this.tb_GrowSpeed.Name = "tb_GrowSpeed";
            this.tb_GrowSpeed.ReadOnly = true;
            this.tb_GrowSpeed.Size = new System.Drawing.Size(38, 20);
            this.tb_GrowSpeed.TabIndex = 14;
            this.tb_GrowSpeed.Text = "1";
            // 
            // trackBar_GrowSpeed
            // 
            this.trackBar_GrowSpeed.AutoSize = false;
            this.trackBar_GrowSpeed.Location = new System.Drawing.Point(12, 143);
            this.trackBar_GrowSpeed.Name = "trackBar_GrowSpeed";
            this.trackBar_GrowSpeed.Size = new System.Drawing.Size(104, 31);
            this.trackBar_GrowSpeed.TabIndex = 12;
            this.trackBar_GrowSpeed.Value = 1;
            this.trackBar_GrowSpeed.Scroll += new System.EventHandler(this.trackBar_GrowSpeed_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Grow speed:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(859, 514);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(137, 23);
            this.btn_Save.TabIndex = 6;
            this.btn_Save.Text = "Save image";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.grpBox_Timers);
            this.Controls.Add(this.grpBox_Picture);
            this.Controls.Add(this.grpBox_Settings);
            this.Controls.Add(this.drawingSurface);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Circle Packing";
            ((System.ComponentModel.ISupportInitialize)(this.drawingSurface)).EndInit();
            this.grpBox_Settings.ResumeLayout(false);
            this.grpBox_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_AmountPerTick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Speed)).EndInit();
            this.grpBox_Picture.ResumeLayout(false);
            this.grpBox_Picture.PerformLayout();
            this.grpBox_Timers.ResumeLayout(false);
            this.grpBox_Timers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_GrowSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox drawingSurface;
        private System.Windows.Forms.GroupBox grpBox_Settings;
        private System.Windows.Forms.CheckBox cb_RandomPos;
        private System.Windows.Forms.CheckBox cb_RandomColour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_Speed;
        private System.Windows.Forms.TextBox tb_Speed;
        private System.Windows.Forms.CheckBox cb_CreateCircles;
        private System.Windows.Forms.CheckBox cb_ClearOnChange;
        private System.Windows.Forms.CheckBox cb_Fill;
        private System.Windows.Forms.CheckBox cb_Overlap;
        private System.Windows.Forms.TextBox tb_AmountPerTick;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar_AmountPerTick;
        private System.Windows.Forms.GroupBox grpBox_Picture;
        private System.Windows.Forms.CheckBox cb_CustomPicture;
        private System.Windows.Forms.TextBox tb_Path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip tt_Speed_TrackBar;
        private System.Windows.Forms.ToolTip tt_Speed_Tb;
        private System.Windows.Forms.ToolTip tt_Amount_TrackBar;
        private System.Windows.Forms.ToolTip tt_Amount_Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_Height;
        private System.Windows.Forms.GroupBox grpBox_Timers;
        private System.Windows.Forms.CheckBox cb_ShowBorders;
        private System.Windows.Forms.ToolTip tt_ShowBorders;
        private System.Windows.Forms.TextBox tb_GrowSpeed;
        private System.Windows.Forms.TrackBar trackBar_GrowSpeed;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Save;
    }
}

