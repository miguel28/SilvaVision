namespace ServoControlTest
{
    partial class frmTest
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radInclination = new System.Windows.Forms.RadioButton();
            this.radSinglejog = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radEast = new System.Windows.Forms.RadioButton();
            this.radWest = new System.Windows.Forms.RadioButton();
            this.radSouth = new System.Windows.Forms.RadioButton();
            this.radNorth = new System.Windows.Forms.RadioButton();
            this.trcInclination = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radJoy = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcInclination)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(62, 36);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(250, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 90;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motor1";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(319, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown6);
            this.groupBox1.Controls.Add(this.trackBar6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown5);
            this.groupBox1.Controls.Add(this.trackBar5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numericUpDown4);
            this.groupBox1.Controls.Add(this.trackBar4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numericUpDown3);
            this.groupBox1.Controls.Add(this.trackBar3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown2);
            this.groupBox1.Controls.Add(this.trackBar2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 300);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Move Separatelly";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Motor6";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Location = new System.Drawing.Point(319, 251);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown6.TabIndex = 17;
            // 
            // trackBar6
            // 
            this.trackBar6.Location = new System.Drawing.Point(62, 246);
            this.trackBar6.Maximum = 180;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(250, 45);
            this.trackBar6.TabIndex = 15;
            this.trackBar6.Value = 90;
            this.trackBar6.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Motor5";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.Location = new System.Drawing.Point(319, 207);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown5.TabIndex = 14;
            // 
            // trackBar5
            // 
            this.trackBar5.Location = new System.Drawing.Point(62, 202);
            this.trackBar5.Maximum = 180;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.Size = new System.Drawing.Size(250, 45);
            this.trackBar5.TabIndex = 12;
            this.trackBar5.Value = 90;
            this.trackBar5.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Motor4";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Location = new System.Drawing.Point(319, 164);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown4.TabIndex = 11;
            // 
            // trackBar4
            // 
            this.trackBar4.Location = new System.Drawing.Point(62, 159);
            this.trackBar4.Maximum = 180;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(250, 45);
            this.trackBar4.TabIndex = 9;
            this.trackBar4.Value = 90;
            this.trackBar4.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Motor3";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(319, 124);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown3.TabIndex = 8;
            // 
            // trackBar3
            // 
            this.trackBar3.Location = new System.Drawing.Point(62, 119);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.Size = new System.Drawing.Size(250, 45);
            this.trackBar3.TabIndex = 6;
            this.trackBar3.Value = 90;
            this.trackBar3.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motor2";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(319, 82);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown2.TabIndex = 5;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(62, 77);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(250, 45);
            this.trackBar2.TabIndex = 3;
            this.trackBar2.Value = 90;
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radJoy);
            this.groupBox2.Controls.Add(this.radInclination);
            this.groupBox2.Controls.Add(this.radSinglejog);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 318);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 113);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Jog Mode";
            // 
            // radInclination
            // 
            this.radInclination.AutoSize = true;
            this.radInclination.Location = new System.Drawing.Point(7, 43);
            this.radInclination.Name = "radInclination";
            this.radInclination.Size = new System.Drawing.Size(73, 17);
            this.radInclination.TabIndex = 20;
            this.radInclination.Text = "Inclination";
            this.radInclination.UseVisualStyleBackColor = true;
            this.radInclination.CheckedChanged += new System.EventHandler(this.JogModeChanged);
            // 
            // radSinglejog
            // 
            this.radSinglejog.AutoSize = true;
            this.radSinglejog.Checked = true;
            this.radSinglejog.Location = new System.Drawing.Point(7, 20);
            this.radSinglejog.Name = "radSinglejog";
            this.radSinglejog.Size = new System.Drawing.Size(78, 17);
            this.radSinglejog.TabIndex = 19;
            this.radSinglejog.TabStop = true;
            this.radSinglejog.Text = "Single JOG";
            this.radSinglejog.UseVisualStyleBackColor = true;
            this.radSinglejog.CheckedChanged += new System.EventHandler(this.JogModeChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radEast);
            this.groupBox3.Controls.Add(this.radWest);
            this.groupBox3.Controls.Add(this.radSouth);
            this.groupBox3.Controls.Add(this.radNorth);
            this.groupBox3.Controls.Add(this.trcInclination);
            this.groupBox3.Enabled = false;
            this.groupBox3.Location = new System.Drawing.Point(441, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(455, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inclination";
            // 
            // radEast
            // 
            this.radEast.AutoSize = true;
            this.radEast.Location = new System.Drawing.Point(43, 172);
            this.radEast.Name = "radEast";
            this.radEast.Size = new System.Drawing.Size(46, 17);
            this.radEast.TabIndex = 4;
            this.radEast.TabStop = true;
            this.radEast.Text = "East";
            this.radEast.UseVisualStyleBackColor = true;
            // 
            // radWest
            // 
            this.radWest.AutoSize = true;
            this.radWest.Location = new System.Drawing.Point(43, 149);
            this.radWest.Name = "radWest";
            this.radWest.Size = new System.Drawing.Size(50, 17);
            this.radWest.TabIndex = 3;
            this.radWest.TabStop = true;
            this.radWest.Text = "West";
            this.radWest.UseVisualStyleBackColor = true;
            // 
            // radSouth
            // 
            this.radSouth.AutoSize = true;
            this.radSouth.Location = new System.Drawing.Point(43, 126);
            this.radSouth.Name = "radSouth";
            this.radSouth.Size = new System.Drawing.Size(53, 17);
            this.radSouth.TabIndex = 2;
            this.radSouth.TabStop = true;
            this.radSouth.Text = "South";
            this.radSouth.UseVisualStyleBackColor = true;
            // 
            // radNorth
            // 
            this.radNorth.AutoSize = true;
            this.radNorth.Location = new System.Drawing.Point(43, 103);
            this.radNorth.Name = "radNorth";
            this.radNorth.Size = new System.Drawing.Size(51, 17);
            this.radNorth.TabIndex = 1;
            this.radNorth.TabStop = true;
            this.radNorth.Text = "North";
            this.radNorth.UseVisualStyleBackColor = true;
            this.radNorth.CheckedChanged += new System.EventHandler(this.InclinationChanged);
            // 
            // trcInclination
            // 
            this.trcInclination.Location = new System.Drawing.Point(20, 35);
            this.trcInclination.Maximum = 100;
            this.trcInclination.Name = "trcInclination";
            this.trcInclination.Size = new System.Drawing.Size(417, 45);
            this.trcInclination.TabIndex = 0;
            this.trcInclination.Scroll += new System.EventHandler(this.trcInclination_Scroll);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radJoy
            // 
            this.radJoy.AutoSize = true;
            this.radJoy.Location = new System.Drawing.Point(7, 67);
            this.radJoy.Name = "radJoy";
            this.radJoy.Size = new System.Drawing.Size(63, 17);
            this.radJoy.TabIndex = 21;
            this.radJoy.TabStop = true;
            this.radJoy.Text = "Joystick";
            this.radJoy.UseVisualStyleBackColor = true;
            this.radJoy.CheckedChanged += new System.EventHandler(this.JogModeChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(500, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "label7";
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 483);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTest";
            this.Text = "Single JOG";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcInclination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radInclination;
        private System.Windows.Forms.RadioButton radSinglejog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radEast;
        private System.Windows.Forms.RadioButton radWest;
        private System.Windows.Forms.RadioButton radSouth;
        private System.Windows.Forms.RadioButton radNorth;
        private System.Windows.Forms.TrackBar trcInclination;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radJoy;
        private System.Windows.Forms.Label label7;
    }
}

