namespace SmartBalanceBoard
{
    partial class frmLabPhoto
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imgCameraBox = new Emgu.CV.UI.ImageBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCameraSetup = new System.Windows.Forms.GroupBox();
            this.btnCloseDev = new System.Windows.Forms.Button();
            this.btnOpenDev = new System.Windows.Forms.Button();
            this.lblDevice = new System.Windows.Forms.Label();
            this.numDev = new System.Windows.Forms.NumericUpDown();
            this.grpGridSetup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trbDilate = new System.Windows.Forms.TrackBar();
            this.trbErode = new System.Windows.Forms.TrackBar();
            this.chkAutoRect = new System.Windows.Forms.CheckBox();
            this.radBoard = new System.Windows.Forms.RadioButton();
            this.radWall = new System.Windows.Forms.RadioButton();
            this.radOriginal = new System.Windows.Forms.RadioButton();
            this.lblGrayMax = new System.Windows.Forms.Label();
            this.lblGrayMin = new System.Windows.Forms.Label();
            this.trbBoardMax = new System.Windows.Forms.TrackBar();
            this.trbBoardMin = new System.Windows.Forms.TrackBar();
            this.lblBrightness = new System.Windows.Forms.Label();
            this.barBrighteness = new System.Windows.Forms.TrackBar();
            this.chkShowGrid = new System.Windows.Forms.CheckBox();
            this.lblColumns = new System.Windows.Forms.Label();
            this.lblRows = new System.Windows.Forms.Label();
            this.lblGridHeight = new System.Windows.Forms.Label();
            this.lblGridWidth = new System.Windows.Forms.Label();
            this.lblyoffset = new System.Windows.Forms.Label();
            this.lblxoffset = new System.Windows.Forms.Label();
            this.btnDefaults = new System.Windows.Forms.Button();
            this.btnDrawBox = new System.Windows.Forms.Button();
            this.numColumns = new System.Windows.Forms.NumericUpDown();
            this.numRows = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numY = new System.Windows.Forms.NumericUpDown();
            this.numX = new System.Windows.Forms.NumericUpDown();
            this.grpNextStep = new System.Windows.Forms.GroupBox();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.btnUseThis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpCameraSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDev)).BeginInit();
            this.grpGridSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBoardMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBoardMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBrighteness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).BeginInit();
            this.grpNextStep.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel1.Controls.Add(this.imgCameraBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(850, 663);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // imgCameraBox
            // 
            this.imgCameraBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgCameraBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.imgCameraBox.Location = new System.Drawing.Point(3, 3);
            this.imgCameraBox.Name = "imgCameraBox";
            this.imgCameraBox.Size = new System.Drawing.Size(597, 657);
            this.imgCameraBox.TabIndex = 6;
            this.imgCameraBox.TabStop = false;
            this.imgCameraBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.imgCameraBox_MouseClick);
            this.imgCameraBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgCameraBox_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.grpCameraSetup, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpGridSetup, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.grpNextStep, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(606, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 475F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(241, 657);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // grpCameraSetup
            // 
            this.grpCameraSetup.Controls.Add(this.btnCloseDev);
            this.grpCameraSetup.Controls.Add(this.btnOpenDev);
            this.grpCameraSetup.Controls.Add(this.lblDevice);
            this.grpCameraSetup.Controls.Add(this.numDev);
            this.grpCameraSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCameraSetup.Location = new System.Drawing.Point(3, 3);
            this.grpCameraSetup.Name = "grpCameraSetup";
            this.grpCameraSetup.Size = new System.Drawing.Size(235, 104);
            this.grpCameraSetup.TabIndex = 0;
            this.grpCameraSetup.TabStop = false;
            this.grpCameraSetup.Text = "Camera Setup";
            // 
            // btnCloseDev
            // 
            this.btnCloseDev.Enabled = false;
            this.btnCloseDev.Location = new System.Drawing.Point(92, 60);
            this.btnCloseDev.Name = "btnCloseDev";
            this.btnCloseDev.Size = new System.Drawing.Size(84, 23);
            this.btnCloseDev.TabIndex = 3;
            this.btnCloseDev.Text = "Close Device";
            this.btnCloseDev.UseVisualStyleBackColor = true;
            this.btnCloseDev.Click += new System.EventHandler(this.btnCloseDev_Click);
            // 
            // btnOpenDev
            // 
            this.btnOpenDev.Location = new System.Drawing.Point(6, 60);
            this.btnOpenDev.Name = "btnOpenDev";
            this.btnOpenDev.Size = new System.Drawing.Size(80, 23);
            this.btnOpenDev.TabIndex = 2;
            this.btnOpenDev.Text = "Open Device";
            this.btnOpenDev.UseVisualStyleBackColor = true;
            this.btnOpenDev.Click += new System.EventHandler(this.btnOpenDev_Click);
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(6, 25);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(80, 13);
            this.lblDevice.TabIndex = 1;
            this.lblDevice.Text = "Camera Device";
            // 
            // numDev
            // 
            this.numDev.Location = new System.Drawing.Point(92, 23);
            this.numDev.Name = "numDev";
            this.numDev.Size = new System.Drawing.Size(64, 20);
            this.numDev.TabIndex = 0;
            // 
            // grpGridSetup
            // 
            this.grpGridSetup.Controls.Add(this.label2);
            this.grpGridSetup.Controls.Add(this.label1);
            this.grpGridSetup.Controls.Add(this.trbDilate);
            this.grpGridSetup.Controls.Add(this.trbErode);
            this.grpGridSetup.Controls.Add(this.chkAutoRect);
            this.grpGridSetup.Controls.Add(this.radBoard);
            this.grpGridSetup.Controls.Add(this.radWall);
            this.grpGridSetup.Controls.Add(this.radOriginal);
            this.grpGridSetup.Controls.Add(this.lblGrayMax);
            this.grpGridSetup.Controls.Add(this.lblGrayMin);
            this.grpGridSetup.Controls.Add(this.trbBoardMax);
            this.grpGridSetup.Controls.Add(this.trbBoardMin);
            this.grpGridSetup.Controls.Add(this.lblBrightness);
            this.grpGridSetup.Controls.Add(this.barBrighteness);
            this.grpGridSetup.Controls.Add(this.chkShowGrid);
            this.grpGridSetup.Controls.Add(this.lblColumns);
            this.grpGridSetup.Controls.Add(this.lblRows);
            this.grpGridSetup.Controls.Add(this.lblGridHeight);
            this.grpGridSetup.Controls.Add(this.lblGridWidth);
            this.grpGridSetup.Controls.Add(this.lblyoffset);
            this.grpGridSetup.Controls.Add(this.lblxoffset);
            this.grpGridSetup.Controls.Add(this.btnDefaults);
            this.grpGridSetup.Controls.Add(this.btnDrawBox);
            this.grpGridSetup.Controls.Add(this.numColumns);
            this.grpGridSetup.Controls.Add(this.numRows);
            this.grpGridSetup.Controls.Add(this.numHeight);
            this.grpGridSetup.Controls.Add(this.numWidth);
            this.grpGridSetup.Controls.Add(this.numY);
            this.grpGridSetup.Controls.Add(this.numX);
            this.grpGridSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGridSetup.Enabled = false;
            this.grpGridSetup.Location = new System.Drawing.Point(3, 113);
            this.grpGridSetup.Name = "grpGridSetup";
            this.grpGridSetup.Size = new System.Drawing.Size(235, 469);
            this.grpGridSetup.TabIndex = 1;
            this.grpGridSetup.TabStop = false;
            this.grpGridSetup.Text = "Grid Setup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Dilate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Erode";
            // 
            // trbDilate
            // 
            this.trbDilate.Location = new System.Drawing.Point(148, 387);
            this.trbDilate.Maximum = 50;
            this.trbDilate.Name = "trbDilate";
            this.trbDilate.Size = new System.Drawing.Size(74, 45);
            this.trbDilate.TabIndex = 27;
            this.trbDilate.Value = 30;
            this.trbDilate.Scroll += new System.EventHandler(this.nums_ValueChanged);
            // 
            // trbErode
            // 
            this.trbErode.Location = new System.Drawing.Point(68, 387);
            this.trbErode.Maximum = 50;
            this.trbErode.Name = "trbErode";
            this.trbErode.Size = new System.Drawing.Size(74, 45);
            this.trbErode.TabIndex = 26;
            this.trbErode.Scroll += new System.EventHandler(this.nums_ValueChanged);
            // 
            // chkAutoRect
            // 
            this.chkAutoRect.AutoSize = true;
            this.chkAutoRect.Location = new System.Drawing.Point(9, 263);
            this.chkAutoRect.Name = "chkAutoRect";
            this.chkAutoRect.Size = new System.Drawing.Size(73, 17);
            this.chkAutoRect.TabIndex = 25;
            this.chkAutoRect.Text = "Automatic";
            this.chkAutoRect.UseVisualStyleBackColor = true;
            this.chkAutoRect.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // radBoard
            // 
            this.radBoard.AutoSize = true;
            this.radBoard.Location = new System.Drawing.Point(107, 275);
            this.radBoard.Name = "radBoard";
            this.radBoard.Size = new System.Drawing.Size(83, 17);
            this.radBoard.TabIndex = 24;
            this.radBoard.TabStop = true;
            this.radBoard.Text = "Board Thres";
            this.radBoard.UseVisualStyleBackColor = true;
            this.radBoard.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // radWall
            // 
            this.radWall.AutoSize = true;
            this.radWall.Location = new System.Drawing.Point(107, 251);
            this.radWall.Name = "radWall";
            this.radWall.Size = new System.Drawing.Size(76, 17);
            this.radWall.TabIndex = 23;
            this.radWall.TabStop = true;
            this.radWall.Text = "Wall Thres";
            this.radWall.UseVisualStyleBackColor = true;
            this.radWall.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // radOriginal
            // 
            this.radOriginal.AutoSize = true;
            this.radOriginal.Checked = true;
            this.radOriginal.Location = new System.Drawing.Point(107, 228);
            this.radOriginal.Name = "radOriginal";
            this.radOriginal.Size = new System.Drawing.Size(60, 17);
            this.radOriginal.TabIndex = 22;
            this.radOriginal.TabStop = true;
            this.radOriginal.Text = "Original";
            this.radOriginal.UseVisualStyleBackColor = true;
            this.radOriginal.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // lblGrayMax
            // 
            this.lblGrayMax.AutoSize = true;
            this.lblGrayMax.Location = new System.Drawing.Point(11, 336);
            this.lblGrayMax.Name = "lblGrayMax";
            this.lblGrayMax.Size = new System.Drawing.Size(58, 13);
            this.lblGrayMax.TabIndex = 21;
            this.lblGrayMax.Text = "Board Max";
            // 
            // lblGrayMin
            // 
            this.lblGrayMin.AutoSize = true;
            this.lblGrayMin.Location = new System.Drawing.Point(11, 298);
            this.lblGrayMin.Name = "lblGrayMin";
            this.lblGrayMin.Size = new System.Drawing.Size(55, 13);
            this.lblGrayMin.TabIndex = 20;
            this.lblGrayMin.Text = "Board Min";
            // 
            // trbBoardMax
            // 
            this.trbBoardMax.Location = new System.Drawing.Point(68, 336);
            this.trbBoardMax.Maximum = 500;
            this.trbBoardMax.Name = "trbBoardMax";
            this.trbBoardMax.Size = new System.Drawing.Size(162, 45);
            this.trbBoardMax.TabIndex = 19;
            this.trbBoardMax.Value = 200;
            this.trbBoardMax.Scroll += new System.EventHandler(this.nums_ValueChanged);
            // 
            // trbBoardMin
            // 
            this.trbBoardMin.Location = new System.Drawing.Point(68, 298);
            this.trbBoardMin.Maximum = 500;
            this.trbBoardMin.Name = "trbBoardMin";
            this.trbBoardMin.Size = new System.Drawing.Size(162, 45);
            this.trbBoardMin.TabIndex = 18;
            this.trbBoardMin.Value = 100;
            this.trbBoardMin.Scroll += new System.EventHandler(this.nums_ValueChanged);
            // 
            // lblBrightness
            // 
            this.lblBrightness.AutoSize = true;
            this.lblBrightness.Location = new System.Drawing.Point(6, 201);
            this.lblBrightness.Name = "lblBrightness";
            this.lblBrightness.Size = new System.Drawing.Size(56, 13);
            this.lblBrightness.TabIndex = 17;
            this.lblBrightness.Text = "Brightness";
            // 
            // barBrighteness
            // 
            this.barBrighteness.Location = new System.Drawing.Point(68, 183);
            this.barBrighteness.Maximum = 255;
            this.barBrighteness.Name = "barBrighteness";
            this.barBrighteness.Size = new System.Drawing.Size(162, 45);
            this.barBrighteness.TabIndex = 16;
            this.barBrighteness.Value = 128;
            this.barBrighteness.Scroll += new System.EventHandler(this.barBightness_Scroll);
            // 
            // chkShowGrid
            // 
            this.chkShowGrid.AutoSize = true;
            this.chkShowGrid.Checked = true;
            this.chkShowGrid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowGrid.Location = new System.Drawing.Point(9, 229);
            this.chkShowGrid.Name = "chkShowGrid";
            this.chkShowGrid.Size = new System.Drawing.Size(75, 17);
            this.chkShowGrid.TabIndex = 14;
            this.chkShowGrid.Text = "Show Grid";
            this.chkShowGrid.UseVisualStyleBackColor = true;
            this.chkShowGrid.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // lblColumns
            // 
            this.lblColumns.AutoSize = true;
            this.lblColumns.Location = new System.Drawing.Point(6, 164);
            this.lblColumns.Name = "lblColumns";
            this.lblColumns.Size = new System.Drawing.Size(47, 13);
            this.lblColumns.TabIndex = 13;
            this.lblColumns.Text = "Columns";
            // 
            // lblRows
            // 
            this.lblRows.AutoSize = true;
            this.lblRows.Location = new System.Drawing.Point(4, 138);
            this.lblRows.Name = "lblRows";
            this.lblRows.Size = new System.Drawing.Size(34, 13);
            this.lblRows.TabIndex = 12;
            this.lblRows.Text = "Rows";
            // 
            // lblGridHeight
            // 
            this.lblGridHeight.AutoSize = true;
            this.lblGridHeight.Location = new System.Drawing.Point(4, 112);
            this.lblGridHeight.Name = "lblGridHeight";
            this.lblGridHeight.Size = new System.Drawing.Size(60, 13);
            this.lblGridHeight.TabIndex = 11;
            this.lblGridHeight.Text = "Grid Height";
            // 
            // lblGridWidth
            // 
            this.lblGridWidth.AutoSize = true;
            this.lblGridWidth.Location = new System.Drawing.Point(4, 86);
            this.lblGridWidth.Name = "lblGridWidth";
            this.lblGridWidth.Size = new System.Drawing.Size(57, 13);
            this.lblGridWidth.TabIndex = 10;
            this.lblGridWidth.Text = "Grid Width";
            // 
            // lblyoffset
            // 
            this.lblyoffset.AutoSize = true;
            this.lblyoffset.Location = new System.Drawing.Point(6, 59);
            this.lblyoffset.Name = "lblyoffset";
            this.lblyoffset.Size = new System.Drawing.Size(45, 13);
            this.lblyoffset.TabIndex = 9;
            this.lblyoffset.Text = "Y Offset";
            // 
            // lblxoffset
            // 
            this.lblxoffset.AutoSize = true;
            this.lblxoffset.Location = new System.Drawing.Point(6, 30);
            this.lblxoffset.Name = "lblxoffset";
            this.lblxoffset.Size = new System.Drawing.Size(45, 13);
            this.lblxoffset.TabIndex = 8;
            this.lblxoffset.Text = "X Offset";
            // 
            // btnDefaults
            // 
            this.btnDefaults.Location = new System.Drawing.Point(115, 438);
            this.btnDefaults.Name = "btnDefaults";
            this.btnDefaults.Size = new System.Drawing.Size(75, 23);
            this.btnDefaults.TabIndex = 7;
            this.btnDefaults.Text = "Defaults";
            this.btnDefaults.UseVisualStyleBackColor = true;
            this.btnDefaults.Click += new System.EventHandler(this.btnDefaults_Click);
            // 
            // btnDrawBox
            // 
            this.btnDrawBox.Location = new System.Drawing.Point(14, 438);
            this.btnDrawBox.Name = "btnDrawBox";
            this.btnDrawBox.Size = new System.Drawing.Size(75, 23);
            this.btnDrawBox.TabIndex = 6;
            this.btnDrawBox.Text = "Draw Box";
            this.btnDrawBox.UseVisualStyleBackColor = true;
            this.btnDrawBox.Click += new System.EventHandler(this.btnDrawBox_Click);
            // 
            // numColumns
            // 
            this.numColumns.Location = new System.Drawing.Point(92, 157);
            this.numColumns.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numColumns.Name = "numColumns";
            this.numColumns.Size = new System.Drawing.Size(73, 20);
            this.numColumns.TabIndex = 5;
            this.numColumns.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numColumns.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // numRows
            // 
            this.numRows.Location = new System.Drawing.Point(92, 131);
            this.numRows.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numRows.Name = "numRows";
            this.numRows.Size = new System.Drawing.Size(73, 20);
            this.numRows.TabIndex = 4;
            this.numRows.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numRows.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(92, 105);
            this.numHeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(73, 20);
            this.numHeight.TabIndex = 3;
            this.numHeight.Value = new decimal(new int[] {
            407,
            0,
            0,
            0});
            this.numHeight.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(92, 77);
            this.numWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(73, 20);
            this.numWidth.TabIndex = 2;
            this.numWidth.Value = new decimal(new int[] {
            413,
            0,
            0,
            0});
            this.numWidth.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // numY
            // 
            this.numY.Location = new System.Drawing.Point(92, 51);
            this.numY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numY.Name = "numY";
            this.numY.Size = new System.Drawing.Size(73, 20);
            this.numY.TabIndex = 1;
            this.numY.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numY.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // numX
            // 
            this.numX.Location = new System.Drawing.Point(92, 25);
            this.numX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numX.Name = "numX";
            this.numX.Size = new System.Drawing.Size(73, 20);
            this.numX.TabIndex = 0;
            this.numX.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numX.ValueChanged += new System.EventHandler(this.nums_ValueChanged);
            // 
            // grpNextStep
            // 
            this.grpNextStep.Controls.Add(this.btnIgnore);
            this.grpNextStep.Controls.Add(this.btnUseThis);
            this.grpNextStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpNextStep.Location = new System.Drawing.Point(3, 588);
            this.grpNextStep.Name = "grpNextStep";
            this.grpNextStep.Size = new System.Drawing.Size(235, 150);
            this.grpNextStep.TabIndex = 2;
            this.grpNextStep.TabStop = false;
            this.grpNextStep.Text = "Next Step";
            // 
            // btnIgnore
            // 
            this.btnIgnore.Enabled = false;
            this.btnIgnore.Location = new System.Drawing.Point(11, 16);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 35);
            this.btnIgnore.TabIndex = 1;
            this.btnIgnore.Text = "Ignore this Step";
            this.btnIgnore.UseVisualStyleBackColor = true;
            this.btnIgnore.Click += new System.EventHandler(this.btnIgnore_Click);
            // 
            // btnUseThis
            // 
            this.btnUseThis.Enabled = false;
            this.btnUseThis.Location = new System.Drawing.Point(117, 16);
            this.btnUseThis.Name = "btnUseThis";
            this.btnUseThis.Size = new System.Drawing.Size(75, 35);
            this.btnUseThis.TabIndex = 0;
            this.btnUseThis.Text = "Use this photo";
            this.btnUseThis.UseVisualStyleBackColor = true;
            this.btnUseThis.Click += new System.EventHandler(this.btnUseThis_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmLabPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 663);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLabPhoto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Smart Balance Board Setup Image";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgCameraBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpCameraSetup.ResumeLayout(false);
            this.grpCameraSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDev)).EndInit();
            this.grpGridSetup.ResumeLayout(false);
            this.grpGridSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbDilate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbErode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBoardMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbBoardMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBrighteness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numX)).EndInit();
            this.grpNextStep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Emgu.CV.UI.ImageBox imgCameraBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpCameraSetup;
        private System.Windows.Forms.Button btnCloseDev;
        private System.Windows.Forms.Button btnOpenDev;
        private System.Windows.Forms.Label lblDevice;
        private System.Windows.Forms.NumericUpDown numDev;
        private System.Windows.Forms.GroupBox grpGridSetup;
        private System.Windows.Forms.Label lblColumns;
        private System.Windows.Forms.Label lblRows;
        private System.Windows.Forms.Label lblGridHeight;
        private System.Windows.Forms.Label lblGridWidth;
        private System.Windows.Forms.Label lblyoffset;
        private System.Windows.Forms.Label lblxoffset;
        private System.Windows.Forms.Button btnDefaults;
        private System.Windows.Forms.Button btnDrawBox;
        private System.Windows.Forms.NumericUpDown numColumns;
        private System.Windows.Forms.NumericUpDown numRows;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numY;
        private System.Windows.Forms.NumericUpDown numX;
        private System.Windows.Forms.CheckBox chkShowGrid;
        private System.Windows.Forms.Label lblBrightness;
        private System.Windows.Forms.TrackBar barBrighteness;
        private System.Windows.Forms.GroupBox grpNextStep;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button btnUseThis;
        private System.Windows.Forms.RadioButton radBoard;
        private System.Windows.Forms.RadioButton radWall;
        private System.Windows.Forms.RadioButton radOriginal;
        private System.Windows.Forms.Label lblGrayMax;
        private System.Windows.Forms.Label lblGrayMin;
        private System.Windows.Forms.TrackBar trbBoardMax;
        private System.Windows.Forms.TrackBar trbBoardMin;
        private System.Windows.Forms.CheckBox chkAutoRect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trbDilate;
        private System.Windows.Forms.TrackBar trbErode;
        private System.Windows.Forms.Timer timer1;
    }
}

