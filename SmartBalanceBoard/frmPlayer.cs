using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;
using VisionRecognition;

namespace SmartBalanceBoard
{
    public partial class frmPlayer : Form
    {
        public CHSmartBalance cam;
        public PathSolver solver;
        public PathSequence sequence;
        private USBInterface.USBDevice usb;
        int[] SouthVector = { -90, 90, 0, -60, 90, -6 };
        int[] NorthVector = { 90, -90, 0, 70, -90, 0 };
        int[] WestVector = { 0, 30, 90, -60, 0, 90 };
        int[] EastVector = { -90, -90, 0, 90, 90, 0 };
        int[] CurrentVector = { 0, 0, 0, 0, 0, 0 };
        float Empuje = 0.0f;

        public frmPlayer(CHSmartBalance _cam, PathSolver _solver, PathSequence _sequence)
        {
            InitializeComponent();
            cam = _cam;
            cam.SetImageBox(ref imageBox1);
            cam.imgMode = ImageMode.Player;
            solver = _solver;
            sequence = _sequence;
            cam.Capture.Start();
            InitiaizeUSB();
        }
        private void InitiaizeUSB()
        {
            usb = new USBInterface.USBDevice(0x3995, 0x0020, 8);
            usb.StreamWriteBegin();
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.StreamWriteChar((char)0);
            usb.SendBuffer();
        }
        private void chkShowObj_CheckedChanged(object sender, EventArgs e)
        {
            if(chkShowObj.Checked)
                cam.imgMode = ImageMode.ShowBall;
            else
                cam.imgMode = ImageMode.Player;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Application.DoEvents();
            int[] SendVector;
            if(checkBox1.Checked)
            {
                if (cam.bStep == cam.NextStep)
                {
                    Empuje += 0.015f;
                    if (Empuje > 0.7f)
                        Empuje = 0.6f;
                    goto next;
                    
                }
                else
                {
                    SendVector = new int[6];
                    while(Empuje>0.0f)
                    {
                        usb.StreamWriteBegin();
                        for (int i = 0; i < 6; i++)
                        {
                            SendVector[i] = (int)((float)CurrentVector[i] * (Empuje)) + 90;
                            usb.StreamWriteChar((char)(SendVector[i]));
                        }
                        usb.SendBuffer();
                        System.Threading.Thread.Sleep(3);
                        Empuje -= 0.01f;
                    }

                    
                }
                Empuje = 0.0f; 
                switch(cam.NextStep)
                {
                    case StepsTypes.Up:
                        CurrentVector = NorthVector;
                        break;
                    case StepsTypes.Down:
                        CurrentVector = SouthVector;
                        break;
                    case StepsTypes.Right:
                        CurrentVector = WestVector;
                        break;
                    case StepsTypes.Left:
                        CurrentVector = EastVector;
                        break;
                }
                cam.bStep = cam.NextStep;
            next:
                SendVector = new int[6];
                usb.StreamWriteBegin();
                for (int i = 0; i < 6; i++)
                {
                    SendVector[i] = (int)((float)CurrentVector[i] * (Empuje)) + 90;
                    usb.StreamWriteChar((char)(SendVector[i]));
                }
                usb.SendBuffer();
                //System.Threading.Thread.Sleep(10);
            }
            timer1.Enabled = true;
            timer1.Interval = 50;
            Application.DoEvents();
        }
        

    }
}
