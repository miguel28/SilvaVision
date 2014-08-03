using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USBInterface;
using JoytickInterop;

namespace ServoControlTest
{
    public partial class frmTest : Form
    {
        private USBDevice usb;
        private SDLJoystick joy;

        int[] NorthVector = { -90, 90, 0, -60, 90, -6 };
        int[] SouthVector = { 90, -90, 0, 70, -90, 0 };
        int[] WestVector = { 0, 30, 90, -60, 0, 90 };
        int[] EastVector = { -90, -90, 0, 90, 90, 0 };
        int[] CurrentVector = {0,0,0,0,0,0};
        public frmTest()
        {
            InitializeComponent();
            usb = new USBDevice(0x3995, 0x0020, 8);
            joy = new SDLJoystick();
            joy.InitJoystick(0, 12);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            UpdateValuesToNum();
        }

        private void UpdateValuesToNum()
        {
            numericUpDown1.Value = trackBar1.Value;
            numericUpDown2.Value = trackBar2.Value;
            numericUpDown3.Value = trackBar3.Value;
            numericUpDown4.Value = trackBar4.Value;
            numericUpDown5.Value = trackBar5.Value;
            numericUpDown6.Value = trackBar6.Value;

            usb.StreamWriteBegin();
            usb.StreamWriteChar((char)(trackBar1.Value));
            usb.StreamWriteChar((char)trackBar2.Value);
            usb.StreamWriteChar((char)trackBar3.Value);
            usb.StreamWriteChar((char)trackBar4.Value);
            usb.StreamWriteChar((char)trackBar5.Value);
            usb.StreamWriteChar((char)trackBar6.Value);
            usb.SendBuffer();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void JogModeChanged(object sender, EventArgs e)
        {
            if(radSinglejog.Checked)
            {
                groupBox1.Enabled = true;
                groupBox3.Enabled = false;
                timer1.Enabled = false;
            }
            if (radInclination.Checked)
            {
                groupBox1.Enabled = false;
                groupBox3.Enabled = true;
                timer1.Enabled = false;
            }
            if(radJoy.Checked)
            {
                groupBox1.Enabled = false;
                groupBox3.Enabled = false;
                timer1.Enabled = true;
            }
        }

        private void InclinationChanged(object sender, EventArgs e)
        {
            if (radNorth.Checked)
                CurrentVector = NorthVector;
            if (radSouth.Checked)
                CurrentVector = SouthVector;
            if (radWest.Checked)
                CurrentVector = WestVector;
            if (radEast.Checked)
                CurrentVector = EastVector;

            Reset();
        }

        private void Reset()
        {
            trackBar1.Value = 90;
            trackBar2.Value = 90;
            trackBar3.Value = 90;
            trackBar4.Value = 90;
            trackBar5.Value = 90;
            trackBar6.Value = 90;
            UpdateValuesToNum(); 
        }

        private void trcInclination_Scroll(object sender, EventArgs e)
        {
            if (radNorth.Checked)
                CurrentVector = NorthVector;
            if (radSouth.Checked)
                CurrentVector = SouthVector;
            if (radWest.Checked)
                CurrentVector = WestVector;
            if (radEast.Checked)
                CurrentVector = EastVector;

            int[] SendVector = new int[6];
            usb.StreamWriteBegin();
            for (int i = 0; i < 6; i++ )
            {
                SendVector[i] = (int)((float)CurrentVector[i] * ((float)trcInclination.Value / 100.0)) + 90;
                usb.StreamWriteChar((char)(SendVector[i]));
            }   
            usb.SendBuffer();

            numericUpDown1.Value = SendVector[0];
            numericUpDown2.Value = SendVector[1];
            numericUpDown3.Value = SendVector[2];
            numericUpDown4.Value = SendVector[3];
            numericUpDown5.Value = SendVector[4];
            numericUpDown6.Value = SendVector[5];
        }

        private void UpdateMotorFromJoy()
        {
            int[] SendVector = { 0, 0, 0, 0, 0, 0 };
            int[] SendVectorX = { 0, 0, 0, 0, 0, 0 };
            int[] SendVectorY = { 0, 0, 0, 0, 0, 0 };
            int i;
            float joyX, joyY;

            joy.Update();
            joyX = joy.GetAxis(0);
            joyY = joy.GetAxis(1);

            if(joyX<=0)
            {
                for (i = 0; i < 6; i++)
                    SendVectorX[i] = (int)((float)WestVector[i] * (-joyX));
            }
            else
            {
                for (i = 0; i < 6; i++)
                    SendVectorX[i] = (int)((float)EastVector[i] * (joyX));
            }

            if (joyY <= 0)
            {
                for (i = 0; i < 6; i++) 
                    SendVectorY[i] = (int)((float)NorthVector[i] * (-joyY));
            }
            else
            {
                for (i = 0; i < 6; i++)
                    SendVectorY[i] = (int)((float)SouthVector[i] * (joyY));
            }
            usb.StreamWriteBegin();
            if(joy.ButtonHeld(4))
            {
                usb.StreamWriteChar((char)90);
                usb.StreamWriteChar((char)90);
                usb.StreamWriteChar((char)90);
                usb.StreamWriteChar((char)90);
                usb.StreamWriteChar((char)90);
                usb.StreamWriteChar((char)90);
            }
            else
            {
                for (i = 0; i < 6; i++)
                {
                    SendVector[i] = SendVectorX[i] + SendVectorY[i] + 90;
                    usb.StreamWriteChar((char)(SendVector[i]));
                }
            }
            
            usb.SendBuffer();
            label7.Text = joyX.ToString() + " , " + joyY.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateMotorFromJoy();
        }

    }
}
