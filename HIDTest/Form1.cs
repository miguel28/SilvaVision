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

namespace HIDTest
{
    public partial class Form1 : Form
    {
        USBDevice usb;
        public Form1()
        {
            InitializeComponent();
            usb = new USBDevice(0x3995, 0x0010);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            short a1,a2,a3,a4;
            char gripper;
            usb.ReciveBuffer();
            usb.StreamReadBegin();
            a1 = usb.StreamReadInt16();
            a2 = usb.StreamReadInt16();
            a3 = usb.StreamReadInt16();
            a4 = usb.StreamReadInt16();
            gripper = usb.StreamReadChar();

            lblData.Text = "";
            lblData.Text += "A1: " + a1.ToString() + System.Environment.NewLine;
            lblData.Text += "A2: " + a2.ToString() + System.Environment.NewLine;
            lblData.Text += "A3: " + a3.ToString() + System.Environment.NewLine;
            lblData.Text += "A4: " + a4.ToString() + System.Environment.NewLine;
            lblData.Text += "Gripper ";
            if((gripper&0x01) == 0x00)
                lblData.Text += "Opened";
            else
                lblData.Text += "Closed";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usb.StreamWriteBegin();
            usb.StreamWriteInt16(Convert.ToInt16(txtA1.Text));
            usb.StreamWriteInt16(Convert.ToInt16(txtA2.Text));
            usb.StreamWriteInt16(Convert.ToInt16(txtA3.Text));
            usb.StreamWriteInt16(Convert.ToInt16(txtA4.Text));
            usb.StreamWriteChar(chkGripper.Checked ? (char)1 : (char)0);
            usb.SendBuffer();
        }

        private void txtA1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtA2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtA3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void txtA4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
    }
}
