namespace KinematiX
{
    partial class frmKXMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKXMain));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.grpCamComm = new System.Windows.Forms.GroupBox();
            this.lblCamstatus = new System.Windows.Forms.Label();
            this.btnConnectCam = new System.Windows.Forms.Button();
            this.numCamCom = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCam = new System.Windows.Forms.Label();
            this.grpJoyComm = new System.Windows.Forms.GroupBox();
            this.lblJoyStatus = new System.Windows.Forms.Label();
            this.btnConnectJoy = new System.Windows.Forms.Button();
            this.btnRefreshJoy = new System.Windows.Forms.Button();
            this.lblnumJoy = new System.Windows.Forms.Label();
            this.numJoy = new System.Windows.Forms.NumericUpDown();
            this.grpSerialCom = new System.Windows.Forms.GroupBox();
            this.lblRobotStatus = new System.Windows.Forms.Label();
            this.lblRunMode = new System.Windows.Forms.Label();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.cboxMoveMode = new System.Windows.Forms.ComboBox();
            this.txtBaud = new System.Windows.Forms.TextBox();
            this.lblSerialStatus = new System.Windows.Forms.Label();
            this.lblSerialPort = new System.Windows.Forms.Label();
            this.btnConnectCom = new System.Windows.Forms.Button();
            this.btnRefreshCom = new System.Windows.Forms.Button();
            this.cboxPorts = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.grpJoyStick = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.chkUseJoy = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpSym = new System.Windows.Forms.GroupBox();
            this.lblJogA1 = new System.Windows.Forms.Label();
            this.lblJogA4 = new System.Windows.Forms.Label();
            this.lblGripper = new System.Windows.Forms.Label();
            this.lblJogA3 = new System.Windows.Forms.Label();
            this.lblJogA2 = new System.Windows.Forms.Label();
            this.grpJogManual = new System.Windows.Forms.GroupBox();
            this.btnHome = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSavePosition = new System.Windows.Forms.Button();
            this.chkGripper = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJogA1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJogA3 = new System.Windows.Forms.TextBox();
            this.txtJogA2 = new System.Windows.Forms.TextBox();
            this.txtJogA4 = new System.Windows.Forms.TextBox();
            this.SendNewPos = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cPosNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMoveType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cA2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cA3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cA4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGripper = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.grpSeqManager = new System.Windows.Forms.GroupBox();
            this.btnClearSeq = new System.Windows.Forms.Button();
            this.btnLoadSeq = new System.Windows.Forms.Button();
            this.btnDuplicatePos = new System.Windows.Forms.Button();
            this.btnDeletePos = new System.Windows.Forms.Button();
            this.btnSaveSeq = new System.Windows.Forms.Button();
            this.grpPosControl = new System.Windows.Forms.GroupBox();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.btnMovePosition = new System.Windows.Forms.Button();
            this.grpSeqControl = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grpCamSetup = new System.Windows.Forms.GroupBox();
            this.chkObjShow = new System.Windows.Forms.CheckBox();
            this.chkViewSpectra = new System.Windows.Forms.CheckBox();
            this.numValMax = new System.Windows.Forms.NumericUpDown();
            this.numSatMax = new System.Windows.Forms.NumericUpDown();
            this.numHueMax = new System.Windows.Forms.NumericUpDown();
            this.numValMin = new System.Windows.Forms.NumericUpDown();
            this.numSatMin = new System.Windows.Forms.NumericUpDown();
            this.numHueMin = new System.Windows.Forms.NumericUpDown();
            this.imageBox = new Emgu.CV.UI.ImageBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tmrJogUpdater = new System.Windows.Forms.Timer(this.components);
            this.tmrStatusUpdater = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.grpCamComm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamCom)).BeginInit();
            this.grpJoyComm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoy)).BeginInit();
            this.grpSerialCom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpJoyStick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpSym.SuspendLayout();
            this.grpJogManual.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.grpSeqManager.SuspendLayout();
            this.grpPosControl.SuspendLayout();
            this.grpSeqControl.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.grpCamSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(953, 648);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.19687F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.06264F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.62864F));
            this.tableLayoutPanel2.Controls.Add(this.grpCamComm, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpJoyComm, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.grpSerialCom, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(947, 108);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // grpCamComm
            // 
            this.grpCamComm.Controls.Add(this.lblCamstatus);
            this.grpCamComm.Controls.Add(this.btnConnectCam);
            this.grpCamComm.Controls.Add(this.numCamCom);
            this.grpCamComm.Controls.Add(this.button2);
            this.grpCamComm.Controls.Add(this.lblCam);
            this.grpCamComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpCamComm.Location = new System.Drawing.Point(687, 3);
            this.grpCamComm.Name = "grpCamComm";
            this.grpCamComm.Size = new System.Drawing.Size(257, 102);
            this.grpCamComm.TabIndex = 2;
            this.grpCamComm.TabStop = false;
            this.grpCamComm.Text = "Camera Communication";
            // 
            // lblCamstatus
            // 
            this.lblCamstatus.AutoSize = true;
            this.lblCamstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamstatus.ForeColor = System.Drawing.Color.Red;
            this.lblCamstatus.Location = new System.Drawing.Point(151, 19);
            this.lblCamstatus.Name = "lblCamstatus";
            this.lblCamstatus.Size = new System.Drawing.Size(55, 20);
            this.lblCamstatus.TabIndex = 10;
            this.lblCamstatus.Text = "Offline";
            // 
            // btnConnectCam
            // 
            this.btnConnectCam.Location = new System.Drawing.Point(118, 47);
            this.btnConnectCam.Name = "btnConnectCam";
            this.btnConnectCam.Size = new System.Drawing.Size(75, 23);
            this.btnConnectCam.TabIndex = 9;
            this.btnConnectCam.Text = "Connect";
            this.btnConnectCam.UseVisualStyleBackColor = true;
            this.btnConnectCam.Click += new System.EventHandler(this.btnConnectCam_Click);
            // 
            // numCamCom
            // 
            this.numCamCom.Location = new System.Drawing.Point(68, 21);
            this.numCamCom.Name = "numCamCom";
            this.numCamCom.Size = new System.Drawing.Size(77, 20);
            this.numCamCom.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 47);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblCam
            // 
            this.lblCam.AutoSize = true;
            this.lblCam.Location = new System.Drawing.Point(12, 23);
            this.lblCam.Name = "lblCam";
            this.lblCam.Size = new System.Drawing.Size(43, 13);
            this.lblCam.TabIndex = 7;
            this.lblCam.Text = "Camera";
            // 
            // grpJoyComm
            // 
            this.grpJoyComm.Controls.Add(this.lblJoyStatus);
            this.grpJoyComm.Controls.Add(this.btnConnectJoy);
            this.grpJoyComm.Controls.Add(this.btnRefreshJoy);
            this.grpJoyComm.Controls.Add(this.lblnumJoy);
            this.grpJoyComm.Controls.Add(this.numJoy);
            this.grpJoyComm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpJoyComm.Location = new System.Drawing.Point(440, 3);
            this.grpJoyComm.Name = "grpJoyComm";
            this.grpJoyComm.Size = new System.Drawing.Size(241, 102);
            this.grpJoyComm.TabIndex = 1;
            this.grpJoyComm.TabStop = false;
            this.grpJoyComm.Text = "Joystick Communicacion";
            // 
            // lblJoyStatus
            // 
            this.lblJoyStatus.AutoSize = true;
            this.lblJoyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJoyStatus.ForeColor = System.Drawing.Color.Red;
            this.lblJoyStatus.Location = new System.Drawing.Point(157, 19);
            this.lblJoyStatus.Name = "lblJoyStatus";
            this.lblJoyStatus.Size = new System.Drawing.Size(55, 20);
            this.lblJoyStatus.TabIndex = 5;
            this.lblJoyStatus.Text = "Offline";
            // 
            // btnConnectJoy
            // 
            this.btnConnectJoy.Location = new System.Drawing.Point(124, 47);
            this.btnConnectJoy.Name = "btnConnectJoy";
            this.btnConnectJoy.Size = new System.Drawing.Size(75, 23);
            this.btnConnectJoy.TabIndex = 3;
            this.btnConnectJoy.Text = "Connect";
            this.btnConnectJoy.UseVisualStyleBackColor = true;
            this.btnConnectJoy.Click += new System.EventHandler(this.btnConnectJoy_Click);
            // 
            // btnRefreshJoy
            // 
            this.btnRefreshJoy.Location = new System.Drawing.Point(43, 47);
            this.btnRefreshJoy.Name = "btnRefreshJoy";
            this.btnRefreshJoy.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshJoy.TabIndex = 2;
            this.btnRefreshJoy.Text = "Refresh";
            this.btnRefreshJoy.UseVisualStyleBackColor = true;
            this.btnRefreshJoy.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblnumJoy
            // 
            this.lblnumJoy.AutoSize = true;
            this.lblnumJoy.Location = new System.Drawing.Point(18, 23);
            this.lblnumJoy.Name = "lblnumJoy";
            this.lblnumJoy.Size = new System.Drawing.Size(40, 13);
            this.lblnumJoy.TabIndex = 1;
            this.lblnumJoy.Text = "Joytick";
            // 
            // numJoy
            // 
            this.numJoy.Location = new System.Drawing.Point(74, 21);
            this.numJoy.Name = "numJoy";
            this.numJoy.Size = new System.Drawing.Size(77, 20);
            this.numJoy.TabIndex = 0;
            // 
            // grpSerialCom
            // 
            this.grpSerialCom.Controls.Add(this.lblRobotStatus);
            this.grpSerialCom.Controls.Add(this.lblRunMode);
            this.grpSerialCom.Controls.Add(this.btnChangeMode);
            this.grpSerialCom.Controls.Add(this.cboxMoveMode);
            this.grpSerialCom.Controls.Add(this.txtBaud);
            this.grpSerialCom.Controls.Add(this.lblSerialStatus);
            this.grpSerialCom.Controls.Add(this.lblSerialPort);
            this.grpSerialCom.Controls.Add(this.btnConnectCom);
            this.grpSerialCom.Controls.Add(this.btnRefreshCom);
            this.grpSerialCom.Controls.Add(this.cboxPorts);
            this.grpSerialCom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSerialCom.Location = new System.Drawing.Point(3, 3);
            this.grpSerialCom.Name = "grpSerialCom";
            this.grpSerialCom.Size = new System.Drawing.Size(431, 102);
            this.grpSerialCom.TabIndex = 0;
            this.grpSerialCom.TabStop = false;
            this.grpSerialCom.Text = "Serial Communication";
            // 
            // lblRobotStatus
            // 
            this.lblRobotStatus.AutoSize = true;
            this.lblRobotStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobotStatus.Location = new System.Drawing.Point(189, 73);
            this.lblRobotStatus.Name = "lblRobotStatus";
            this.lblRobotStatus.Size = new System.Drawing.Size(94, 17);
            this.lblRobotStatus.TabIndex = 9;
            this.lblRobotStatus.Text = "Disconnected";
            // 
            // lblRunMode
            // 
            this.lblRunMode.AutoSize = true;
            this.lblRunMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunMode.Location = new System.Drawing.Point(189, 47);
            this.lblRunMode.Name = "lblRunMode";
            this.lblRunMode.Size = new System.Drawing.Size(30, 17);
            this.lblRunMode.TabIndex = 8;
            this.lblRunMode.Text = "Idle";
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Enabled = false;
            this.btnChangeMode.Location = new System.Drawing.Point(315, 47);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(75, 23);
            this.btnChangeMode.TabIndex = 7;
            this.btnChangeMode.Text = "Change Mode";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // cboxMoveMode
            // 
            this.cboxMoveMode.Enabled = false;
            this.cboxMoveMode.FormattingEnabled = true;
            this.cboxMoveMode.Items.AddRange(new object[] {
            "Idle",
            "Jog Mode",
            "Sequence Mode",
            "Externel Run (DemoApp)"});
            this.cboxMoveMode.Location = new System.Drawing.Point(250, 17);
            this.cboxMoveMode.Name = "cboxMoveMode";
            this.cboxMoveMode.Size = new System.Drawing.Size(140, 21);
            this.cboxMoveMode.TabIndex = 6;
            // 
            // txtBaud
            // 
            this.txtBaud.Location = new System.Drawing.Point(124, 20);
            this.txtBaud.Name = "txtBaud";
            this.txtBaud.Size = new System.Drawing.Size(58, 20);
            this.txtBaud.TabIndex = 5;
            this.txtBaud.Text = "115200";
            // 
            // lblSerialStatus
            // 
            this.lblSerialStatus.AutoSize = true;
            this.lblSerialStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialStatus.ForeColor = System.Drawing.Color.Red;
            this.lblSerialStatus.Location = new System.Drawing.Point(188, 16);
            this.lblSerialStatus.Name = "lblSerialStatus";
            this.lblSerialStatus.Size = new System.Drawing.Size(55, 20);
            this.lblSerialStatus.TabIndex = 4;
            this.lblSerialStatus.Text = "Offline";
            // 
            // lblSerialPort
            // 
            this.lblSerialPort.AutoSize = true;
            this.lblSerialPort.Location = new System.Drawing.Point(16, 23);
            this.lblSerialPort.Name = "lblSerialPort";
            this.lblSerialPort.Size = new System.Drawing.Size(26, 13);
            this.lblSerialPort.TabIndex = 3;
            this.lblSerialPort.Text = "Port";
            // 
            // btnConnectCom
            // 
            this.btnConnectCom.Location = new System.Drawing.Point(100, 47);
            this.btnConnectCom.Name = "btnConnectCom";
            this.btnConnectCom.Size = new System.Drawing.Size(75, 23);
            this.btnConnectCom.TabIndex = 2;
            this.btnConnectCom.Text = "Connect";
            this.btnConnectCom.UseVisualStyleBackColor = true;
            this.btnConnectCom.Click += new System.EventHandler(this.btnConnectCom_Click);
            // 
            // btnRefreshCom
            // 
            this.btnRefreshCom.Location = new System.Drawing.Point(19, 47);
            this.btnRefreshCom.Name = "btnRefreshCom";
            this.btnRefreshCom.Size = new System.Drawing.Size(75, 23);
            this.btnRefreshCom.TabIndex = 1;
            this.btnRefreshCom.Text = "Refresh";
            this.btnRefreshCom.UseVisualStyleBackColor = true;
            this.btnRefreshCom.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboxPorts
            // 
            this.cboxPorts.FormattingEnabled = true;
            this.cboxPorts.Location = new System.Drawing.Point(48, 19);
            this.cboxPorts.Name = "cboxPorts";
            this.cboxPorts.Size = new System.Drawing.Size(69, 21);
            this.cboxPorts.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 117);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 528);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Robot Jog";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.txtConsole);
            this.panel1.Controls.Add(this.grpJoyStick);
            this.panel1.Controls.Add(this.grpSym);
            this.panel1.Controls.Add(this.grpJogManual);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 496);
            this.panel1.TabIndex = 0;
            // 
            // txtConsole
            // 
            this.txtConsole.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsole.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtConsole.Location = new System.Drawing.Point(309, 313);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(508, 190);
            this.txtConsole.TabIndex = 13;
            // 
            // grpJoyStick
            // 
            this.grpJoyStick.Controls.Add(this.label1);
            this.grpJoyStick.Controls.Add(this.trackBar1);
            this.grpJoyStick.Controls.Add(this.chkUseJoy);
            this.grpJoyStick.Controls.Add(this.pictureBox1);
            this.grpJoyStick.Enabled = false;
            this.grpJoyStick.Location = new System.Drawing.Point(15, 230);
            this.grpJoyStick.Name = "grpJoyStick";
            this.grpJoyStick.Size = new System.Drawing.Size(288, 224);
            this.grpJoyStick.TabIndex = 7;
            this.grpJoyStick.TabStop = false;
            this.grpJoyStick.Text = "Joy Stick";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sensibility";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(96, 49);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(167, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.Value = 25;
            // 
            // chkUseJoy
            // 
            this.chkUseJoy.AutoSize = true;
            this.chkUseJoy.Enabled = false;
            this.chkUseJoy.Location = new System.Drawing.Point(29, 20);
            this.chkUseJoy.Name = "chkUseJoy";
            this.chkUseJoy.Size = new System.Drawing.Size(88, 17);
            this.chkUseJoy.TabIndex = 1;
            this.chkUseJoy.Text = "Use JoyStick";
            this.chkUseJoy.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // grpSym
            // 
            this.grpSym.Controls.Add(this.lblJogA1);
            this.grpSym.Controls.Add(this.lblJogA4);
            this.grpSym.Controls.Add(this.lblGripper);
            this.grpSym.Controls.Add(this.lblJogA3);
            this.grpSym.Controls.Add(this.lblJogA2);
            this.grpSym.Location = new System.Drawing.Point(309, 16);
            this.grpSym.Name = "grpSym";
            this.grpSym.Size = new System.Drawing.Size(508, 291);
            this.grpSym.TabIndex = 7;
            this.grpSym.TabStop = false;
            this.grpSym.Text = "Simulation";
            // 
            // lblJogA1
            // 
            this.lblJogA1.AutoSize = true;
            this.lblJogA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogA1.Location = new System.Drawing.Point(18, 27);
            this.lblJogA1.Name = "lblJogA1";
            this.lblJogA1.Size = new System.Drawing.Size(33, 24);
            this.lblJogA1.TabIndex = 0;
            this.lblJogA1.Text = "A1";
            // 
            // lblJogA4
            // 
            this.lblJogA4.AutoSize = true;
            this.lblJogA4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogA4.Location = new System.Drawing.Point(18, 99);
            this.lblJogA4.Name = "lblJogA4";
            this.lblJogA4.Size = new System.Drawing.Size(33, 24);
            this.lblJogA4.TabIndex = 3;
            this.lblJogA4.Text = "A4";
            // 
            // lblGripper
            // 
            this.lblGripper.AutoSize = true;
            this.lblGripper.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGripper.Location = new System.Drawing.Point(21, 126);
            this.lblGripper.Name = "lblGripper";
            this.lblGripper.Size = new System.Drawing.Size(25, 24);
            this.lblGripper.TabIndex = 11;
            this.lblGripper.Text = "...";
            // 
            // lblJogA3
            // 
            this.lblJogA3.AutoSize = true;
            this.lblJogA3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogA3.Location = new System.Drawing.Point(18, 76);
            this.lblJogA3.Name = "lblJogA3";
            this.lblJogA3.Size = new System.Drawing.Size(33, 24);
            this.lblJogA3.TabIndex = 2;
            this.lblJogA3.Text = "A3";
            // 
            // lblJogA2
            // 
            this.lblJogA2.AutoSize = true;
            this.lblJogA2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJogA2.Location = new System.Drawing.Point(18, 53);
            this.lblJogA2.Name = "lblJogA2";
            this.lblJogA2.Size = new System.Drawing.Size(33, 24);
            this.lblJogA2.TabIndex = 1;
            this.lblJogA2.Text = "A2";
            // 
            // grpJogManual
            // 
            this.grpJogManual.Controls.Add(this.btnHome);
            this.grpJogManual.Controls.Add(this.label2);
            this.grpJogManual.Controls.Add(this.label3);
            this.grpJogManual.Controls.Add(this.btnSavePosition);
            this.grpJogManual.Controls.Add(this.chkGripper);
            this.grpJogManual.Controls.Add(this.label5);
            this.grpJogManual.Controls.Add(this.txtJogA1);
            this.grpJogManual.Controls.Add(this.label6);
            this.grpJogManual.Controls.Add(this.txtJogA3);
            this.grpJogManual.Controls.Add(this.txtJogA2);
            this.grpJogManual.Controls.Add(this.txtJogA4);
            this.grpJogManual.Controls.Add(this.SendNewPos);
            this.grpJogManual.Enabled = false;
            this.grpJogManual.Location = new System.Drawing.Point(15, 16);
            this.grpJogManual.Name = "grpJogManual";
            this.grpJogManual.Size = new System.Drawing.Size(288, 199);
            this.grpJogManual.TabIndex = 6;
            this.grpJogManual.TabStop = false;
            this.grpJogManual.Text = "Jog Manual";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(140, 150);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(107, 23);
            this.btnHome.TabIndex = 16;
            this.btnHome.Text = "Save Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "A1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "A4";
            // 
            // btnSavePosition
            // 
            this.btnSavePosition.Location = new System.Drawing.Point(29, 150);
            this.btnSavePosition.Name = "btnSavePosition";
            this.btnSavePosition.Size = new System.Drawing.Size(107, 23);
            this.btnSavePosition.TabIndex = 12;
            this.btnSavePosition.Text = "Save Position";
            this.btnSavePosition.UseVisualStyleBackColor = true;
            this.btnSavePosition.Click += new System.EventHandler(this.btnSavePosition_Click);
            // 
            // chkGripper
            // 
            this.chkGripper.AutoSize = true;
            this.chkGripper.Location = new System.Drawing.Point(196, 68);
            this.chkGripper.Name = "chkGripper";
            this.chkGripper.Size = new System.Drawing.Size(60, 17);
            this.chkGripper.TabIndex = 4;
            this.chkGripper.Text = "Gripper";
            this.chkGripper.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "A3";
            // 
            // txtJogA1
            // 
            this.txtJogA1.Location = new System.Drawing.Point(62, 32);
            this.txtJogA1.Name = "txtJogA1";
            this.txtJogA1.Size = new System.Drawing.Size(127, 20);
            this.txtJogA1.TabIndex = 9;
            this.txtJogA1.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "A2";
            // 
            // txtJogA3
            // 
            this.txtJogA3.Location = new System.Drawing.Point(62, 84);
            this.txtJogA3.Name = "txtJogA3";
            this.txtJogA3.Size = new System.Drawing.Size(127, 20);
            this.txtJogA3.TabIndex = 8;
            this.txtJogA3.Text = "300";
            // 
            // txtJogA2
            // 
            this.txtJogA2.Location = new System.Drawing.Point(62, 58);
            this.txtJogA2.Name = "txtJogA2";
            this.txtJogA2.Size = new System.Drawing.Size(127, 20);
            this.txtJogA2.TabIndex = 7;
            this.txtJogA2.Text = "200";
            // 
            // txtJogA4
            // 
            this.txtJogA4.Location = new System.Drawing.Point(62, 111);
            this.txtJogA4.Name = "txtJogA4";
            this.txtJogA4.Size = new System.Drawing.Size(127, 20);
            this.txtJogA4.TabIndex = 6;
            this.txtJogA4.Text = "400";
            // 
            // SendNewPos
            // 
            this.SendNewPos.Location = new System.Drawing.Point(195, 39);
            this.SendNewPos.Name = "SendNewPos";
            this.SendNewPos.Size = new System.Drawing.Size(75, 23);
            this.SendNewPos.TabIndex = 5;
            this.SendNewPos.Text = "Move";
            this.SendNewPos.UseVisualStyleBackColor = true;
            this.SendNewPos.Click += new System.EventHandler(this.SendMove_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Position Table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(933, 496);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPosNum,
            this.cMoveType,
            this.cA1,
            this.cA2,
            this.cA3,
            this.cA4,
            this.cGripper});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(927, 377);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // cPosNum
            // 
            this.cPosNum.HeaderText = "Position";
            this.cPosNum.Name = "cPosNum";
            this.cPosNum.ReadOnly = true;
            // 
            // cMoveType
            // 
            this.cMoveType.HeaderText = "Move Type";
            this.cMoveType.Items.AddRange(new object[] {
            "Absolute",
            "Relative",
            "Rel Last Commanded",
            "Home"});
            this.cMoveType.Name = "cMoveType";
            // 
            // cA1
            // 
            this.cA1.HeaderText = "A1";
            this.cA1.Name = "cA1";
            // 
            // cA2
            // 
            this.cA2.HeaderText = "A2";
            this.cA2.Name = "cA2";
            // 
            // cA3
            // 
            this.cA3.HeaderText = "A3";
            this.cA3.Name = "cA3";
            // 
            // cA4
            // 
            this.cA4.HeaderText = "A4";
            this.cA4.Name = "cA4";
            // 
            // cGripper
            // 
            this.cGripper.HeaderText = "Gripper";
            this.cGripper.Name = "cGripper";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.89644F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.06472F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.93096F));
            this.tableLayoutPanel4.Controls.Add(this.grpSeqManager, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.grpPosControl, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.grpSeqControl, 2, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 386);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(927, 107);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // grpSeqManager
            // 
            this.grpSeqManager.Controls.Add(this.btnClearSeq);
            this.grpSeqManager.Controls.Add(this.btnLoadSeq);
            this.grpSeqManager.Controls.Add(this.btnDuplicatePos);
            this.grpSeqManager.Controls.Add(this.btnDeletePos);
            this.grpSeqManager.Controls.Add(this.btnSaveSeq);
            this.grpSeqManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSeqManager.Location = new System.Drawing.Point(3, 3);
            this.grpSeqManager.Name = "grpSeqManager";
            this.grpSeqManager.Size = new System.Drawing.Size(438, 101);
            this.grpSeqManager.TabIndex = 6;
            this.grpSeqManager.TabStop = false;
            this.grpSeqManager.Text = "Sequence Manager";
            // 
            // btnClearSeq
            // 
            this.btnClearSeq.Location = new System.Drawing.Point(183, 37);
            this.btnClearSeq.Name = "btnClearSeq";
            this.btnClearSeq.Size = new System.Drawing.Size(75, 35);
            this.btnClearSeq.TabIndex = 2;
            this.btnClearSeq.Text = "Clear Sequence";
            this.btnClearSeq.UseVisualStyleBackColor = true;
            this.btnClearSeq.Click += new System.EventHandler(this.btnClearSeq_Click);
            // 
            // btnLoadSeq
            // 
            this.btnLoadSeq.Location = new System.Drawing.Point(102, 37);
            this.btnLoadSeq.Name = "btnLoadSeq";
            this.btnLoadSeq.Size = new System.Drawing.Size(75, 35);
            this.btnLoadSeq.TabIndex = 1;
            this.btnLoadSeq.Text = "Load Sequence";
            this.btnLoadSeq.UseVisualStyleBackColor = true;
            this.btnLoadSeq.Click += new System.EventHandler(this.btnLoadSeq_Click);
            // 
            // btnDuplicatePos
            // 
            this.btnDuplicatePos.Location = new System.Drawing.Point(346, 37);
            this.btnDuplicatePos.Name = "btnDuplicatePos";
            this.btnDuplicatePos.Size = new System.Drawing.Size(75, 35);
            this.btnDuplicatePos.TabIndex = 5;
            this.btnDuplicatePos.Text = "Duplicate Position";
            this.btnDuplicatePos.UseVisualStyleBackColor = true;
            this.btnDuplicatePos.Click += new System.EventHandler(this.btnDuplicatePos_Click);
            // 
            // btnDeletePos
            // 
            this.btnDeletePos.Location = new System.Drawing.Point(265, 37);
            this.btnDeletePos.Name = "btnDeletePos";
            this.btnDeletePos.Size = new System.Drawing.Size(75, 35);
            this.btnDeletePos.TabIndex = 4;
            this.btnDeletePos.Text = "Delete Position";
            this.btnDeletePos.UseVisualStyleBackColor = true;
            this.btnDeletePos.Click += new System.EventHandler(this.btnDeletePos_Click);
            // 
            // btnSaveSeq
            // 
            this.btnSaveSeq.Location = new System.Drawing.Point(21, 37);
            this.btnSaveSeq.Name = "btnSaveSeq";
            this.btnSaveSeq.Size = new System.Drawing.Size(75, 35);
            this.btnSaveSeq.TabIndex = 0;
            this.btnSaveSeq.Text = "Save Sequence";
            this.btnSaveSeq.UseVisualStyleBackColor = true;
            this.btnSaveSeq.Click += new System.EventHandler(this.btnSaveSeq_Click);
            // 
            // grpPosControl
            // 
            this.grpPosControl.Controls.Add(this.btnGoHome);
            this.grpPosControl.Controls.Add(this.btnMovePosition);
            this.grpPosControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPosControl.Enabled = false;
            this.grpPosControl.Location = new System.Drawing.Point(447, 3);
            this.grpPosControl.Name = "grpPosControl";
            this.grpPosControl.Size = new System.Drawing.Size(180, 101);
            this.grpPosControl.TabIndex = 3;
            this.grpPosControl.TabStop = false;
            this.grpPosControl.Text = "Position Control";
            // 
            // btnGoHome
            // 
            this.btnGoHome.Location = new System.Drawing.Point(90, 37);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(75, 35);
            this.btnGoHome.TabIndex = 6;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // btnMovePosition
            // 
            this.btnMovePosition.Location = new System.Drawing.Point(9, 37);
            this.btnMovePosition.Name = "btnMovePosition";
            this.btnMovePosition.Size = new System.Drawing.Size(75, 35);
            this.btnMovePosition.TabIndex = 3;
            this.btnMovePosition.Text = "Move Position";
            this.btnMovePosition.UseVisualStyleBackColor = true;
            this.btnMovePosition.Click += new System.EventHandler(this.btnMovePosition_Click);
            // 
            // grpSeqControl
            // 
            this.grpSeqControl.Controls.Add(this.button9);
            this.grpSeqControl.Controls.Add(this.button8);
            this.grpSeqControl.Controls.Add(this.button4);
            this.grpSeqControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpSeqControl.Enabled = false;
            this.grpSeqControl.Location = new System.Drawing.Point(633, 3);
            this.grpSeqControl.Name = "grpSeqControl";
            this.grpSeqControl.Size = new System.Drawing.Size(291, 101);
            this.grpSeqControl.TabIndex = 7;
            this.grpSeqControl.TabStop = false;
            this.grpSeqControl.Text = "Sequence Control";
            // 
            // button9
            // 
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(197, 20);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 68);
            this.button9.TabIndex = 7;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(105, 20);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 68);
            this.button8.TabIndex = 6;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(14, 20);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 68);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(939, 502);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Objects Recognitions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.grpCamSetup);
            this.panel2.Controls.Add(this.imageBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 502);
            this.panel2.TabIndex = 0;
            // 
            // grpCamSetup
            // 
            this.grpCamSetup.Controls.Add(this.chkObjShow);
            this.grpCamSetup.Controls.Add(this.chkViewSpectra);
            this.grpCamSetup.Controls.Add(this.numValMax);
            this.grpCamSetup.Controls.Add(this.numSatMax);
            this.grpCamSetup.Controls.Add(this.numHueMax);
            this.grpCamSetup.Controls.Add(this.numValMin);
            this.grpCamSetup.Controls.Add(this.numSatMin);
            this.grpCamSetup.Controls.Add(this.numHueMin);
            this.grpCamSetup.Location = new System.Drawing.Point(645, 16);
            this.grpCamSetup.Name = "grpCamSetup";
            this.grpCamSetup.Size = new System.Drawing.Size(275, 461);
            this.grpCamSetup.TabIndex = 3;
            this.grpCamSetup.TabStop = false;
            this.grpCamSetup.Text = "groupBox1";
            // 
            // chkObjShow
            // 
            this.chkObjShow.AutoSize = true;
            this.chkObjShow.Location = new System.Drawing.Point(87, 246);
            this.chkObjShow.Name = "chkObjShow";
            this.chkObjShow.Size = new System.Drawing.Size(87, 17);
            this.chkObjShow.TabIndex = 7;
            this.chkObjShow.Text = "Show Object";
            this.chkObjShow.UseVisualStyleBackColor = true;
            this.chkObjShow.CheckedChanged += new System.EventHandler(this.chkViewSpectra_CheckedChanged);
            // 
            // chkViewSpectra
            // 
            this.chkViewSpectra.AutoSize = true;
            this.chkViewSpectra.Location = new System.Drawing.Point(87, 269);
            this.chkViewSpectra.Name = "chkViewSpectra";
            this.chkViewSpectra.Size = new System.Drawing.Size(63, 17);
            this.chkViewSpectra.TabIndex = 6;
            this.chkViewSpectra.Text = "Spectra";
            this.chkViewSpectra.UseVisualStyleBackColor = true;
            this.chkViewSpectra.CheckedChanged += new System.EventHandler(this.chkViewSpectra_CheckedChanged);
            // 
            // numValMax
            // 
            this.numValMax.Location = new System.Drawing.Point(106, 191);
            this.numValMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax.Name = "numValMax";
            this.numValMax.Size = new System.Drawing.Size(57, 20);
            this.numValMax.TabIndex = 5;
            this.numValMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // numSatMax
            // 
            this.numSatMax.Location = new System.Drawing.Point(106, 165);
            this.numSatMax.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax.Name = "numSatMax";
            this.numSatMax.Size = new System.Drawing.Size(57, 20);
            this.numSatMax.TabIndex = 4;
            this.numSatMax.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // numHueMax
            // 
            this.numHueMax.Location = new System.Drawing.Point(106, 139);
            this.numHueMax.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numHueMax.Name = "numHueMax";
            this.numHueMax.Size = new System.Drawing.Size(57, 20);
            this.numHueMax.TabIndex = 3;
            this.numHueMax.Value = new decimal(new int[] {
            74,
            0,
            0,
            0});
            this.numHueMax.ValueChanged += new System.EventHandler(this.numMax_ValueChanged);
            // 
            // numValMin
            // 
            this.numValMin.Location = new System.Drawing.Point(106, 83);
            this.numValMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numValMin.Name = "numValMin";
            this.numValMin.Size = new System.Drawing.Size(57, 20);
            this.numValMin.TabIndex = 2;
            this.numValMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numValMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // numSatMin
            // 
            this.numSatMin.Location = new System.Drawing.Point(106, 57);
            this.numSatMin.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numSatMin.Name = "numSatMin";
            this.numSatMin.Size = new System.Drawing.Size(57, 20);
            this.numSatMin.TabIndex = 1;
            this.numSatMin.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            this.numSatMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // numHueMin
            // 
            this.numHueMin.Location = new System.Drawing.Point(106, 31);
            this.numHueMin.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.numHueMin.Name = "numHueMin";
            this.numHueMin.Size = new System.Drawing.Size(57, 20);
            this.numHueMin.TabIndex = 0;
            this.numHueMin.Value = new decimal(new int[] {
            42,
            0,
            0,
            0});
            this.numHueMin.ValueChanged += new System.EventHandler(this.numMin_ValueChanged);
            // 
            // imageBox
            // 
            this.imageBox.Location = new System.Drawing.Point(18, 16);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(617, 461);
            this.imageBox.TabIndex = 2;
            this.imageBox.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(939, 502);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Demo Application Run";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tmrJogUpdater
            // 
            this.tmrJogUpdater.Interval = 50;
            this.tmrJogUpdater.Tick += new System.EventHandler(this.tmrJogUpdater_Tick);
            // 
            // tmrStatusUpdater
            // 
            this.tmrStatusUpdater.Enabled = true;
            this.tmrStatusUpdater.Interval = 20;
            this.tmrStatusUpdater.Tick += new System.EventHandler(this.tmrStatusUpdater_Tick);
            // 
            // frmKXMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 648);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKXMain";
            this.Text = "KinematiX Position Commander";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.grpCamComm.ResumeLayout(false);
            this.grpCamComm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCamCom)).EndInit();
            this.grpJoyComm.ResumeLayout(false);
            this.grpJoyComm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJoy)).EndInit();
            this.grpSerialCom.ResumeLayout(false);
            this.grpSerialCom.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpJoyStick.ResumeLayout(false);
            this.grpJoyStick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpSym.ResumeLayout(false);
            this.grpSym.PerformLayout();
            this.grpJogManual.ResumeLayout(false);
            this.grpJogManual.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.grpSeqManager.ResumeLayout(false);
            this.grpPosControl.ResumeLayout(false);
            this.grpSeqControl.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.grpCamSetup.ResumeLayout(false);
            this.grpCamSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numValMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numValMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSatMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox grpCamComm;
        private System.Windows.Forms.GroupBox grpJoyComm;
        private System.Windows.Forms.GroupBox grpSerialCom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblSerialStatus;
        private System.Windows.Forms.Label lblSerialPort;
        private System.Windows.Forms.Button btnConnectCom;
        private System.Windows.Forms.Button btnRefreshCom;
        private System.Windows.Forms.ComboBox cboxPorts;
        private System.Windows.Forms.Timer tmrJogUpdater;
        private System.Windows.Forms.Label lblJoyStatus;
        private System.Windows.Forms.Button btnConnectJoy;
        private System.Windows.Forms.Button btnRefreshJoy;
        private System.Windows.Forms.Label lblnumJoy;
        private System.Windows.Forms.NumericUpDown numJoy;
        private System.Windows.Forms.Label lblCamstatus;
        private System.Windows.Forms.Button btnConnectCam;
        private System.Windows.Forms.NumericUpDown numCamCom;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCam;
        private System.Windows.Forms.TextBox txtBaud;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblJogA4;
        private System.Windows.Forms.Label lblJogA3;
        private System.Windows.Forms.Label lblJogA2;
        private System.Windows.Forms.Label lblJogA1;
        private System.Windows.Forms.Button SendNewPos;
        private System.Windows.Forms.GroupBox grpJoyStick;
        private System.Windows.Forms.GroupBox grpSym;
        private System.Windows.Forms.GroupBox grpJogManual;
        private System.Windows.Forms.TextBox txtJogA1;
        private System.Windows.Forms.TextBox txtJogA3;
        private System.Windows.Forms.TextBox txtJogA2;
        private System.Windows.Forms.TextBox txtJogA4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkUseJoy;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosNum;
        private System.Windows.Forms.DataGridViewComboBoxColumn cMoveType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cA2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cA3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cA4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cGripper;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox grpPosControl;
        private System.Windows.Forms.Button btnMovePosition;
        private System.Windows.Forms.Button btnDeletePos;
        private System.Windows.Forms.Button btnDuplicatePos;
        private System.Windows.Forms.GroupBox grpSeqManager;
        private System.Windows.Forms.Button btnLoadSeq;
        private System.Windows.Forms.Button btnSaveSeq;
        private System.Windows.Forms.GroupBox grpSeqControl;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lblGripper;
        private System.Windows.Forms.CheckBox chkGripper;
        private System.Windows.Forms.Button btnSavePosition;
        private System.Windows.Forms.Button btnClearSeq;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboxMoveMode;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.Label lblRunMode;
        private System.Windows.Forms.Label lblRobotStatus;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Timer tmrStatusUpdater;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grpCamSetup;
        private Emgu.CV.UI.ImageBox imageBox;
        private System.Windows.Forms.CheckBox chkViewSpectra;
        private System.Windows.Forms.NumericUpDown numValMax;
        private System.Windows.Forms.NumericUpDown numSatMax;
        private System.Windows.Forms.NumericUpDown numHueMax;
        private System.Windows.Forms.NumericUpDown numValMin;
        private System.Windows.Forms.NumericUpDown numSatMin;
        private System.Windows.Forms.NumericUpDown numHueMin;
        private System.Windows.Forms.CheckBox chkObjShow;
    }
}

