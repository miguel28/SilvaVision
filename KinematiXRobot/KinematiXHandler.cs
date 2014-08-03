using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace KinematiXRobot
{
    public enum RobotStatus
    {
        NoConnected,
        Connected,
        Ready,
        Moving,
        Error,
        Done,
    }
    public enum RobotRunMode
    {
        Idle,
        JogMode,
        SequenceMode,
        ExternalRun
    }

    public class KinematiXHandler : SerialPort
    {
        private Timer tmrReceiver;
        private Timer tmrTimeOut;
        private TextBox console;

        private string readBuffer = "";
        public RobotStatus Status = RobotStatus.NoConnected;
        public int[] AngleEncoders = new int[6];
        public bool GripperActivated = false;


        public RobotMove HomePosition;
        public List<RobotMove> Sequence;

        public KinematiXHandler(string port, int baud, int timeOutInterval):base()
        {
            tmrReceiver = new Timer();
            tmrReceiver.Interval = 100;
            tmrReceiver.Tick += new System.EventHandler(this.ReceiveTimerHandler);

            tmrTimeOut = new Timer();
            tmrTimeOut.Interval = timeOutInterval;
            tmrTimeOut.Tick += new System.EventHandler(this.TimeOutTimerHandler);
            
            Sequence = new List<RobotMove>();
            SetHome(100, 200, 300, 400);

            try
            {
                base.BaudRate = baud;
                base.PortName = port;
                base.ReadBufferSize = 32;

                base.Open();
                System.Threading.Thread.Sleep(1000);
                tmrReceiver.Enabled = true;
                //base.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.ReceivePortHandler);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Status = RobotStatus.Error;
            }
        }

        #region Data Transfering
        public void AddConsoleHandler(ref TextBox con)
        {
            console = con;
        }
        private void ReceiveTimerHandler(object sender,EventArgs e)
        {
            try
            {
                readBuffer = base.ReadLine();
                
                if(console != null)
                {
                    console.Text += readBuffer + Environment.NewLine;
                    console.ScrollToCaret();
                    if (console.Lines.Length > 40)
                        console.Clear();
                }

                string[] splited = readBuffer.Split(',');
                if (splited.Length < 5)
                    return;

                tmrReceiver.Stop();
                tmrReceiver.Start();
            
                for (int i = 0; i < 5; i++)
                    AngleEncoders[i] = Convert.ToInt32(splited[i]);

                int tempStatus = Convert.ToInt32(splited[4]);
                GripperActivated = (tempStatus & 0x01)>0;
                switch (tempStatus>>1)
                {
                    case 0:
                        Status = RobotStatus.Ready;
                        break;
                    case 1:
                        Status = RobotStatus.Moving;
                        break;
                    case 2:
                        Status = RobotStatus.Moving;
                        break;
                    case 3:
                        Status = RobotStatus.Done;
                        break;
                    default:
                        Status = RobotStatus.Error;
                        break;
                }
            }
            catch(Exception ex)
            {
                ex.ToString();
            }
            
        }
        private void TimeOutTimerHandler(object sender, EventArgs e)
        {
            base.Close();
            MessageBox.Show("Robot Time out Connection", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tmrReceiver.Enabled = false;
        }
        private void ReceivePortHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                readBuffer = base.ReadLine();
                
            }
            catch (Exception ex1)
            { 
            }

        }
        #endregion
        #region Positioning
        public void SetHome(int a1, int a2, int a3, int a4)
        {
            HomePosition = new RobotMove(RobotMoveType.Absolute);
            HomePosition.SetPosition(a1,a2,a3,a4);
            HomePosition.GripperActivated = false;
        }

        public void GoHome()
        {
            PlayMove(HomePosition);
        }

        public void PlayMove(int move)
        {
            PlayMove(Sequence[move]);
        }

        public void PlayMove(RobotMove move)
        {
            string command = move.GetCommand();
            base.Write(command);
            System.Threading.Thread.Sleep(500);
        }

        public void PlaySequence()
        {

        }

        #endregion
    }
}
