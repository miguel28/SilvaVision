using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VisionRecognition;

namespace SmartBalanceBoard
{
    public partial class frmAnalyzeLab : Form
    {
        private CHSmartBalance cam;
        private PathSolver solver;
        private PathSequence mainsequence;
        private bool SettingStart = false;
        private bool SettingFinish = false;

        public frmAnalyzeLab(bool AnalizeImage, CHSmartBalance _cam)
        {
            InitializeComponent();
            cam = _cam;
            pictureBox1.Image = new Bitmap(1000, 1000);

            if (AnalizeImage)
            {
                imgCameraBox.Image = cam.GridFrame;
                cam.gridRecognizer.SetImage(cam.GridFrame);
                cam.gridRecognizer.Recognize();
            }
                

            pictureBox1.Image = cam.gridRecognizer.GetRecognizedBitmap();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (SettingStart)
                cam.gridRecognizer.SetStartPoint(e.Location);
            else if (SettingFinish)
                cam.gridRecognizer.SetFinishPoint(e.Location);
            else
                cam.gridRecognizer.TogglePosition(e.Location);

            SettingFinish = SettingStart = false;
            grpSteps.Enabled = true;
            /// Redraw the Image
            pictureBox1.Image = cam.gridRecognizer.GetRecognizedBitmap();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnRecognize_Click(object sender, EventArgs e)
        {
            cam.gridRecognizer.Recognize();
        }
        private void btnSetStart_Click(object sender, EventArgs e)
        {
            SettingStart = true;
            grpSteps.Enabled = false;
        }
        private void btnSetFinish_Click(object sender, EventArgs e)
        {
            SettingFinish = true;
            grpSteps.Enabled = false;
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            string err = cam.gridRecognizer.CheckPreliminarErrors();
            if (err.Length == 0)
            {
                solver = new PathSolver(cam.gridRecognizer);
                mainsequence = solver.Solve();
                pictureBox1.Image = GetPathBitmap(mainsequence);
            }
            else MessageBox.Show(err, "Recognizer Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public Bitmap GetPathBitmap(PathSequence path)
        {
            Bitmap paths = cam.gridRecognizer.GetRecognizedBitmap();
            Bitmap pathsolved = new Bitmap(paths.Width, paths.Height);
            Graphics g = Graphics.FromImage(pathsolved);
            g.DrawImage(paths, 0, 0);

            int CurrentX = cam.gridRecognizer.StartPoint.X;
            int CurrentY = cam.gridRecognizer.StartPoint.Y;
            int gridWidth = cam.gridRecognizer.gridWidth;
            int gridHeight = cam.gridRecognizer.gridHeight;
            foreach(PathStep step in path.Steps)
            {
                Pen pen = new Pen(Color.Blue, 5.0f);
                Point p1,p2;

                switch(step.sType)
                {
                    case StepsTypes.Up:
                        p1 = new Point((CurrentX * gridWidth) + (gridWidth/2),(CurrentY * gridHeight));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth/2), ( (CurrentY + 1) * gridHeight)); 
                        g.DrawLine(pen,p1,p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth/4),(CurrentY * gridHeight) + (gridHeight/4));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth/2), (CurrentY * gridHeight)); 
                        g.DrawLine(pen,p1,p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth*3/4),(CurrentY * gridHeight) + (gridHeight/4));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth/2), (CurrentY * gridHeight)); 
                        g.DrawLine(pen,p1,p2);
                        CurrentY--;
                        break;

                    case StepsTypes.Down:
                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 2), (CurrentY * gridHeight));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2), ((CurrentY + 1) * gridHeight));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4), (CurrentY * gridHeight) + (gridHeight * 3 / 4));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2), ((CurrentY + 1) * gridHeight));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3 / 4), (CurrentY * gridHeight) + (gridHeight *3 / 4));
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2), ((CurrentY + 1) * gridHeight));
                        g.DrawLine(pen, p1, p2);
                        CurrentY++;
                        break;

                    case StepsTypes.Left:
                        p1 = new Point(CurrentX * gridWidth, (CurrentY * gridHeight) + (gridHeight/2));
                        p2 = new Point((CurrentX + 1) * gridWidth , (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4), (CurrentY * gridHeight) + (gridHeight / 4));
                        p2 = new Point(CurrentX * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4), (CurrentY * gridHeight) + (gridHeight *3 / 4));
                        p2 = new Point(CurrentX * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);
                        CurrentX--;
                        break;

                    case StepsTypes.Right:
                        p1 = new Point(CurrentX * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        p2 = new Point((CurrentX + 1) * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth *3/ 4), (CurrentY * gridHeight) + (gridHeight / 4));
                        p2 = new Point((CurrentX + 1) * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3/ 4), (CurrentY * gridHeight) + (gridHeight * 3 / 4));
                        p2 = new Point((CurrentX + 1) * gridWidth, (CurrentY * gridHeight) + (gridHeight / 2));
                        g.DrawLine(pen, p1, p2);
                        CurrentX++;
                        break;
                }
            }


            return pathsolved;
        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            frmPlayer player = new frmPlayer(cam,solver,mainsequence);
            player.Show();
        }
    }
}
