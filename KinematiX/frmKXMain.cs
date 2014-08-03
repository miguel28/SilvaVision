using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using JoytickInterop;
using KinematiXRobot;
using VisionRecognition;

namespace KinematiX
{
    public partial class frmKXMain : Form
    {
        KinematiXHandler kinematix;
        SDLJoystick joy;
        ObjectRecognizer cam;
        RobotRunMode Runmode = RobotRunMode.Idle;

        private int[] TempAngleEncoders = new int[6];
        private bool LoadingSeq = false;
        private bool AddingPos = false;
        private bool Sending = false;

        public frmKXMain()
        {
            InitializeComponent();

            joy = new SDLJoystick();
            UpdateCommunications();

            TempAngleEncoders[0] = 0;
            TempAngleEncoders[1] = 0;
            TempAngleEncoders[2] = 0;
            TempAngleEncoders[3] = 0;
            TempAngleEncoders[4] = 0;
            TempAngleEncoders[5] = 0;

        }

        private void UpdateCommunications()
        {
            /* Update Serial Ports*/
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                cboxPorts.Items.Add(port);
            //cboxPorts.SelectedIndex = 1;

            /*Update Joysticks*/
            numJoy.Maximum = SDLJoystick.NumJoysticks - 1;
            
        }
        private void UpdateGUI()
        { 
            if(kinematix != null)
            {
                if(kinematix.IsOpen)
                {
                    lblSerialStatus.Text = "Online";
                    lblSerialStatus.ForeColor = Color.Green;
                    
                    cboxMoveMode.Enabled = true;
                    cboxMoveMode.SelectedIndex = 0;

                    cboxPorts.Enabled = false;
                    btnRefreshCom.Enabled = false;
                    btnConnectCom.Enabled = false;
                    txtBaud.Enabled = false;
                    btnChangeMode.Enabled = true;

                    if (Runmode == RobotRunMode.JogMode)
                    {
                        grpJogManual.Enabled = true;
                        tmrJogUpdater.Enabled = true;
                        chkUseJoy.Enabled = true;
                    }
                    else
                    {
                        grpJogManual.Enabled = false;
                        tmrJogUpdater.Enabled = false;
                        chkUseJoy.Enabled = false;
                    }

                    if (Runmode == RobotRunMode.SequenceMode)
                    {
                        grpPosControl.Enabled = true;
                        grpSeqControl.Enabled = true;
                        grpSeqManager.Enabled = false;
                        dataGridView1.ReadOnly = true;
                        btnDeletePos.Enabled = false;
                        btnDuplicatePos.Enabled = false;
                    }
                    else
                    {
                        grpPosControl.Enabled = false;
                        grpSeqControl.Enabled = false;
                        grpSeqManager.Enabled = true;
                        dataGridView1.ReadOnly = false;
                        btnDeletePos.Enabled = true;
                        btnDuplicatePos.Enabled = true;
                    }

                }
            }
            if(joy.Open)
            {
                lblJoyStatus.Text = "Online";
                lblJoyStatus.ForeColor = Color.Green;

                grpJoyStick.Enabled = true;
                numJoy.Enabled = false;
                btnConnectJoy.Enabled = false;
                btnRefreshJoy.Enabled = false;
            }
        }
        private bool CheckAllPositions()
        {
            bool ret = false;
            if (dataGridView1.Rows.Count == 1)
                return true;

            for(int j= 0; j< dataGridView1.Rows.Count -1; j++)
            {
                int leng;
                DataGridViewRow row = dataGridView1.Rows[j];
                for (int i = 2; i <= 5; i++)
                {
                    leng = row.Cells[2].Value.ToString().Length;
                    if (leng == 0)
                    {
                        MessageBox.Show("Check The position #" + row.Index.ToString(), "Position Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ret = false;
                        return ret;
                    }

                }
            }
            return true;
        }
        private void ConvertPositions()
        {

            kinematix.Sequence.Clear(); 
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                kinematix.Sequence.Add(new RobotMove(row));
            }
        }

        #region Communications Methods
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateCommunications();
        }
        private void btnConnectCom_Click(object sender, EventArgs e)
        {
            if (cboxPorts.SelectedItem == null)
                return;

            kinematix = new KinematiXHandler(cboxPorts.SelectedItem.ToString(), Convert.ToInt32(txtBaud.Text),10000);
            kinematix.AddConsoleHandler(ref txtConsole);
            UpdateGUI();
        }
        private void tmrStatusUpdater_Tick(object sender, EventArgs e)
        {
            if (kinematix == null)
                return;

            lblRobotStatus.Text = kinematix.Status.ToString();

            if (kinematix.Status == RobotStatus.Moving)
            {
                btnGoHome.Enabled = false;
                btnMovePosition.Enabled = false;
                if (Runmode == RobotRunMode.SequenceMode)
                    grpSeqControl.Enabled = false;
            }
            else
            {
                btnGoHome.Enabled = true;
                btnMovePosition.Enabled = true;
                if (Runmode == RobotRunMode.SequenceMode)
                    grpSeqControl.Enabled = true;
            }
        }
        private void btnConnectJoy_Click(object sender, EventArgs e)
        {
            joy.InitJoystick((int)numJoy.Value, 12);

            UpdateGUI();
        }
        private void btnChangeMode_Click(object sender, EventArgs e)
        {

            switch (cboxMoveMode.SelectedIndex)
            {
                case 0:
                    Runmode = RobotRunMode.Idle;
                    cboxMoveMode.SelectedIndex = 1;
                    MessageBox.Show("Run Mode Changed to Idle", "Run mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 1:
                    Runmode = RobotRunMode.JogMode;
                    cboxMoveMode.SelectedIndex = 2;
                    MessageBox.Show("Run Mode Changed to Jog Mode", "Run mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControl1.TabIndex = 0;
                    break;
                case 2:
                    if (CheckAllPositions())
                    {
                        Runmode = RobotRunMode.SequenceMode;
                        cboxMoveMode.SelectedIndex = 2;
                        ConvertPositions();
                        MessageBox.Show("Run Mode Changed to Sequence Mode", "Run mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tabControl1.TabIndex = 1;
                    }
                    break;
                case 3:
                    Runmode = RobotRunMode.SequenceMode;
                    MessageBox.Show("Run Mode Changed to External Run Mode", "Run mode", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tabControl1.TabIndex = 3;
                    cboxMoveMode.SelectedIndex = 3;
                    break;
            }
            UpdateGUI();
            lblRunMode.Text = Runmode.ToString();
        }
        private void frmKXMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //kinematix.Close();
            Close();
        }
        private void btnConnectCam_Click(object sender, EventArgs e)
        {
            cam = new ObjectRecognizer((int)numCamCom.Value, ref imageBox);
            cam.Capture.Start();
        }
        #endregion

        #region JogMethods
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (joy.Open)
            {
                e.Graphics.Clear(Color.CornflowerBlue);

                int X = (int)(joy.GetAxis(0) * 25);
                int Y = (int)(joy.GetAxis(1) * 25);

                int Z = (int)(joy.GetAxis(2) * 25);
                int W = (int)(joy.GetAxis(3) * 25);

                Rectangle rec = new Rectangle(X + 25, Y + 25, 50, 50);
                e.Graphics.FillEllipse(Brushes.DarkGray, rec);
                e.Graphics.DrawArc(Pens.Black, rec, 0, 360);

                rec = new Rectangle(W + 150, Z + 25, 50, 50);
                e.Graphics.FillEllipse(Brushes.DarkGray, rec);
                e.Graphics.DrawArc(Pens.Black, rec, 0, 360);
            }
        }
        private void tmrJogUpdater_Tick(object sender, EventArgs e)
        {
            if (kinematix != null)
            {
                if (kinematix.IsOpen)
                {
                    lblJogA1.Text = "A1: " + kinematix.AngleEncoders[0].ToString();
                    lblJogA2.Text = "A2: " + kinematix.AngleEncoders[1].ToString();
                    lblJogA3.Text = "A3: " + kinematix.AngleEncoders[2].ToString();
                    lblJogA4.Text = "A4: " + kinematix.AngleEncoders[3].ToString();
                    lblGripper.Text = !kinematix.GripperActivated ? "Gripper Opened" : "Gripper Closed";
                    if(!chkUseJoy.Checked)
                        TempAngleEncoders = kinematix.AngleEncoders.Clone() as int[];
                }
            }

            if (joy.Open)
            {
                joy.Update();

                if (joy.ButtonNewpress(4))
                {
                    chkGripper.Checked = !chkGripper.Checked;
                }
                if (joy.ButtonNewpress(10))
                {
                    chkUseJoy.Checked = !chkUseJoy.Checked;
                }
                if (joy.ButtonNewpress(3))
                {
                    if(!Sending)
                        SendMove_Click(null,null);
                }
                if (joy.ButtonHeld(7))
                {
                    if (trackBar1.Value > 1)
                        trackBar1.Value -= 1;
                    else
                        trackBar1.Value = 0;
                }
                if(joy.ButtonHeld(8))
                {
                    if (trackBar1.Value <= 49)
                        trackBar1.Value += 1;
                    else
                        trackBar1.Value = 50;
                }

                pictureBox1.Image = new Bitmap(250, 100);

                if (chkUseJoy.Checked)
                {
                    int X = (int)(joy.GetAxis(0) * trackBar1.Value);
                    int Y = (int)(joy.GetAxis(1) * trackBar1.Value);

                    int Z = (int)(joy.GetAxis(2) * trackBar1.Value);
                    int W = (int)(joy.GetAxis(3) * trackBar1.Value);

                    TempAngleEncoders[0] += X;
                    TempAngleEncoders[1] += Y;

                    TempAngleEncoders[2] += Z;
                    TempAngleEncoders[3] += W;

                    for (int i = 0; i < 4; i++)
                    {
                        if (TempAngleEncoders[i] < 0)
                            TempAngleEncoders[i] = 0;
                        if (TempAngleEncoders[i] > 1023)
                            TempAngleEncoders[i] = 1023;
                    }

                    txtJogA1.Text = TempAngleEncoders[0].ToString();
                    txtJogA2.Text = TempAngleEncoders[1].ToString();
                    txtJogA3.Text = TempAngleEncoders[2].ToString();
                    txtJogA4.Text = TempAngleEncoders[3].ToString();
                }
            }
        }
        private void SendMove_Click(object sender, EventArgs e)
        {
            Sending = true;
            SendNewPos.Enabled = false;

            string Comm = "";
            Comm += txtJogA1.Text + ',';
            Comm += txtJogA2.Text + ',';
            Comm += txtJogA3.Text + ',';
            Comm += txtJogA4.Text + ',';
            Comm += chkGripper.Checked ? "1" : "0";
            Comm += "m";

            kinematix.Write(Comm);
            System.Threading.Thread.Sleep(500);

            SendNewPos.Enabled = true;
            Sending = false;
        }
        private void btnSavePosition_Click(object sender, EventArgs e)
        {
            AddingPos = true;
            string newrownum = dataGridView1.Rows.Count.ToString();
            string[] row = {newrownum, 
                            "Absolute",
                            kinematix.AngleEncoders[0].ToString(),
                            kinematix.AngleEncoders[1].ToString(),
                            kinematix.AngleEncoders[2].ToString(),
                            kinematix.AngleEncoders[3].ToString(),
                            kinematix.GripperActivated.ToString()
                           };

            dataGridView1.Rows.Add(row);

            AddingPos = false;
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            kinematix.SetHome(kinematix.AngleEncoders[0], 
                              kinematix.AngleEncoders[1],
                              kinematix.AngleEncoders[2],
                              kinematix.AngleEncoders[3]);

            MessageBox.Show("This position is a new home", "Homing Succesfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Sequence Methods
        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (LoadingSeq)
                return;

            if (AddingPos)
                return;

            DataGridViewCell cell = dataGridView1.Rows[e.RowIndex - 1].Cells[0];
            cell.Value = (dataGridView1.Rows.Count - 1).ToString();

            cell = dataGridView1.Rows[e.RowIndex - 1].Cells[1];
            cell.Value = "Absolute";
        }
        private void btnSaveSeq_Click(object sender, EventArgs e)
        {
            if(File.Exists("Positions.csv"))
                File.Delete("Positions.csv");

            using (StreamWriter writer = new StreamWriter("Positions.csv"))
            {
                foreach(DataGridViewRow row in dataGridView1.Rows)
                {
                    try
                    {
                        string posline = "";
                        posline += row.Cells[0].Value.ToString() + ',';
                        posline += row.Cells[1].Value.ToString() + ',';
                        posline += row.Cells[2].Value.ToString() + ',';
                        posline += row.Cells[3].Value.ToString() + ',';
                        posline += row.Cells[4].Value.ToString() + ',';
                        posline += row.Cells[5].Value.ToString() + ',';

                        DataGridViewCheckBoxCell cell = row.Cells[6] as DataGridViewCheckBoxCell;
                        if(cell.Value == null)
                        {
                            posline += "False";
                        }
                        else if(cell.Value.ToString().Contains("False"))
                        {
                            posline += "False";
                        }
                        else
                        {
                            posline += "True";
                        }
                        writer.WriteLine(posline);
                    }
                    catch(Exception eee) 
                    {
                    }
                }
                writer.Close();
            }
        }
        private void btnLoadSeq_Click(object sender, EventArgs e)
        {
            if (!File.Exists("Positions.csv"))
                return;

            LoadingSeq = true;

            dataGridView1.Rows.Clear();

            string[] lines = File.ReadAllLines("Positions.csv");
            foreach(string line in lines)
            {
                dataGridView1.Rows.Add(line.Split(','));
            }

            LoadingSeq = false;
        }
        private void btnClearSeq_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
        private void btnDeletePos_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Index == dataGridView1.Rows.Count - 1)
                    return;
                dataGridView1.Rows.RemoveAt(row.Index);
                break;
            }
        }
        private void btnDuplicatePos_Click(object sender, EventArgs e)
        {

        }
        private void btnMovePosition_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (row.Index == dataGridView1.Rows.Count - 1)
                    return;
                kinematix.PlayMove(row.Index);
                break;
            }
        }
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            kinematix.GoHome();
        }
        #endregion

        private void chkViewSpectra_CheckedChanged(object sender, EventArgs e)
        {
            if (chkObjShow.Checked && chkViewSpectra.Checked)
                cam.imgMode = ImageModeObj.ThresholdedObj;
            else if(chkObjShow.Checked)
                cam.imgMode = ImageModeObj.Object;
            else if(chkViewSpectra.Checked)
                cam.imgMode = ImageModeObj.Thresholded;
            else
                cam.imgMode = ImageModeObj.Original;
        }

        private void numMin_ValueChanged(object sender, EventArgs e)
        {
            cam.SetMinVal((int)numHueMin.Value, (int)numSatMin.Value, (int)numValMin.Value);
        }

        private void numMax_ValueChanged(object sender, EventArgs e)
        {
            cam.SetMaxVal((int)numHueMax.Value, (int)numSatMax.Value, (int)numValMax.Value);
        }

        

        





    }
}
