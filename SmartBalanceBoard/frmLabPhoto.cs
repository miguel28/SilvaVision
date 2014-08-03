using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisionRecognition;
using USBInterface;

namespace SmartBalanceBoard
{
    public partial class frmLabPhoto : Form
    {
        private CHSmartBalance cam;
        private GridRecognizer gridRecognizer;
        private USBDevice usb;

        private bool IsDrawingBox = false;
        private bool clickDraw = false;
        private Point p1 = new Point();
        private Point p2 = new Point(-1,-1);

        public frmLabPhoto()
        {
            InitializeComponent();
            //InitiaizeUSB();
            SetGrid();
            
        }

        private void InitiaizeUSB()
        {
            usb = new USBDevice(0x3995, 0x0020, 8);
            usb.StreamWriteBegin();
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.SendBuffer();
        }
        private void SetGrid()
        {
            Rectangle box = new Rectangle((int)numX.Value,(int)numY.Value,(int)numWidth.Value,(int)numHeight.Value);
            int rows = (int)numRows.Value;
            int cols = (int)numColumns.Value;
            gridRecognizer = new GridRecognizer(box,rows,cols);
            gridRecognizer.GetHorizontalLines();
            gridRecognizer.GetVerticalLines();
            gridRecognizer.Brightness = barBrighteness.Value;

            gridRecognizer.BoardMin = trbBoardMin.Value;
            gridRecognizer.BoardMax = trbBoardMax.Value;

            gridRecognizer.Erode = trbErode.Value;
            gridRecognizer.Dilate = trbDilate.Value;
            if(cam != null)
                cam.gridRecognizer = gridRecognizer;
        }
        private void btnOpenDev_Click(object sender, EventArgs e)
        {
            cam = new CHSmartBalance((int)numDev.Value, ref imgCameraBox, ref gridRecognizer);
            if(cam.CaptureOpened)
            {
                numDev.Enabled = false;
                btnOpenDev.Enabled = false;
                btnCloseDev.Enabled = true;
                grpGridSetup.Enabled = true;
                grpNextStep.Enabled = true;
                btnUseThis.Enabled = true;
                btnIgnore.Enabled = true;
                cam.imgMode = ImageMode.ShowGrid;
                cam.Capture.Start();
                timer1.Enabled = true;
            }
        }
        private void btnCloseDev_Click(object sender, EventArgs e)
        {
            numDev.Enabled = true;
            btnOpenDev.Enabled = true;
            btnCloseDev.Enabled = false;
            grpGridSetup.Enabled = false;
            grpNextStep.Enabled = false;
            btnUseThis.Enabled = false;
            cam.Capture.Stop();
        }
        
        private void btnDefaults_Click(object sender, EventArgs e)
        {
            numX.Value = 96;
            numY.Value = 25;
            numWidth.Value = 413;
            numHeight.Value = 407;
            numRows.Value = 10;
            numColumns.Value = 10;
        }
        private void btnDrawBox_Click(object sender, EventArgs e)
        {
            if (!IsDrawingBox)
            {
                IsDrawingBox = true;
                grpCameraSetup.Enabled = false;
                grpGridSetup.Enabled = false;
                grpNextStep.Enabled = false;
                btnDrawBox.Text = "Cancel";
                cam.imgMode = ImageMode.DrawingBox;
            }
            else
            {
                IsDrawingBox = false;
                grpCameraSetup.Enabled = true;
                grpGridSetup.Enabled = true;
                grpNextStep.Enabled = true;
                btnDrawBox.Text = "Draw Box";
                chk_CheckedChanged(null, null);
            }
            
        }
        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowGrid.Checked)
            {
                if (radOriginal.Checked)
                    cam.imgMode = ImageMode.ShowGrid;
                if (radWall.Checked)
                    cam.imgMode = ImageMode.GrayShowGrid;
                if (radBoard.Checked)
                    cam.imgMode = ImageMode.BoardShowGrid;
            }
            else
            {
                if (radOriginal.Checked)
                    cam.imgMode = ImageMode.Original;
                if (radWall.Checked)
                    cam.imgMode = ImageMode.Gray;
                if (radBoard.Checked)
                    cam.imgMode = ImageMode.Board;
            }
            cam.gridRecognizer.AutoRect = chkAutoRect.Checked;
        }
        private void barBightness_Scroll(object sender, EventArgs e)
        {
            SetGrid();
        }
        private void nums_ValueChanged(object sender, EventArgs e)
        {
            SetGrid();
        }

        private void imgCameraBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (cam == null) return;
            if (IsDrawingBox && clickDraw)
                p2 = e.Location;

            UpdateDrawBox();
        }
        private void imgCameraBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (cam == null) return;
            if (IsDrawingBox)
            {
                if (clickDraw)
                {
                    p2 = e.Location;
                    clickDraw = false;
                    UpdateDrawBox();
                    p1 = new Point();
                    btnDrawBox_Click(null, null);

                    Rectangle rec = new Rectangle(cam.p1, cam.ps);
                    numX.Value = rec.X;
                    numY.Value = rec.Y;
                    numWidth.Value = rec.Width;
                    numHeight.Value = rec.Height;
                    numWidth.Refresh();
                    numHeight.Refresh();
                    numX.Refresh();
                    numY.Refresh();
                    //SetGrid();
                    return;
                }
                else
                    p1 = e.Location;
            }
            clickDraw = true;
            UpdateDrawBox();
        }
        private void UpdateDrawBox()
        {
            Point tempp1, tempp2;
            if(p2.X < 0)return; 
            if (p1.X >= p2.X)
            {
                tempp1 = p1;
                tempp2 = p2;
                p1.X = p2.X;
                p2.X = tempp1.X;
                
            }
            if (p1.Y >= p2.Y)
            {
                tempp1 = p1;
                tempp2 = p2;
                p1.Y = p2.Y;
                p2.Y = tempp1.Y;
            }
            cam.p1 = p1;
            cam.ps = new Size(p2.X - p1.X, p2.Y - p1.Y);
        }

        private void ShowNextStep(bool Use)
        {
            //cam = new CHSmartBalance((int)numDev.Value, ref imgCameraBox, ref gridRecognizer);
            SetGrid();
            cam.TakeGridFrame();
            frmAnalyzeLab analyze = new frmAnalyzeLab(Use, cam);

            Hide();
            analyze.ShowDialog();
            Show();
        }
        private void btnIgnore_Click(object sender, EventArgs e)
        {
            ShowNextStep(false);
        }
        private void btnUseThis_Click(object sender, EventArgs e)
        {
            ShowNextStep(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chkAutoRect.Checked == false)
                return;
            try
            {
                numX.Value = cam.AutoCenter.X;
                numY.Value = cam.AutoCenter.Y;
                numX.Refresh();
                numY.Refresh();
            }
            catch { }
            
        }
   
    }
}
