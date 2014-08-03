using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinematiXRobot
{
    public enum RobotMoveType
    {
        NoMove,
        Absolute,
        Relative,
        LastCommanded,
        Home
    }
    public class RobotMove
    {
        public RobotMoveType MoveType;
        private int[] JointData = new int [4];
        public bool GripperActivated = false;

        #region Contructors
        public RobotMove()
        {
        }

        public RobotMove(RobotMoveType type)
        {
            MoveType = type;
        }

        public RobotMove(RobotMoveType type, int[] data)
        {
            MoveType = type;
            JointData = data;
        }

        public RobotMove(DataGridViewRow row)
        {
            string moveType = row.Cells[1].Value.ToString();

            if (moveType.Contains("Absolute"))
                MoveType = RobotMoveType.Absolute;
            else if (moveType.Contains("Relative"))
                MoveType = RobotMoveType.Relative;
            else if (moveType.Contains("Rel Last Commanded"))
                MoveType = RobotMoveType.LastCommanded;
            else if (moveType.Contains("Home"))
                MoveType = RobotMoveType.Home;

            JointData[0] = Convert.ToInt32(row.Cells[2].Value.ToString());
            JointData[1] = Convert.ToInt32(row.Cells[3].Value.ToString());
            JointData[2] = Convert.ToInt32(row.Cells[4].Value.ToString());
            JointData[3] = Convert.ToInt32(row.Cells[5].Value.ToString());

            DataGridViewCheckBoxCell cell = row.Cells[6] as DataGridViewCheckBoxCell;
            if (cell.Value == null)
                GripperActivated = false;
            else if (cell.Value.ToString().Contains("False"))
                GripperActivated = false;
            else
                GripperActivated = true;
        }
        #endregion

        public void SetPosition(int A1, int A2, int A3, int A4)
        {
            JointData[0] = A1;
            JointData[1] = A2;
            JointData[2] = A3;
            JointData[3] = A4;
        }
        public string GetCommand()
        {
            string ret = "";

            ret += JointData[0].ToString() + ',';
            ret += JointData[1].ToString() + ',';
            ret += JointData[2].ToString() + ',';
            ret += JointData[3].ToString() + ',';
            ret += GripperActivated ? '1' : '0';
            ret += 'm';
            return ret; 
        }

    }
}
