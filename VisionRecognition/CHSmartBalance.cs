using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;

namespace VisionRecognition
{
    public enum ImageMode
    {
        Original,
        Gray,
        ShowGrid,
        DrawingBox,
        GrayShowGrid,
        ShowBall,
        Board,
        BoardShowGrid,
        Player
    }

    public class CHSmartBalance : CameraHandler
    {
        public Image<Gray, Byte> GridFrame;
        public Image<Gray, Byte> BoardSpectra;
        public ImageMode imgMode;
        public Point p1 = new Point();
        public Size ps = new Size();
        public GridRecognizer gridRecognizer;
        public PathSolver solver;

        private PointF center;
        private CircleF circle;
        private int Radius;

        private List<PointF> centersAvr = new List<PointF>();
        //private List<PointF> centersball = new List<PointF>();

        public Point AutoCenter;
        public StepsTypes NextStep = StepsTypes.NoMove;
        public StepsTypes bStep = StepsTypes.NoMove;
        public CHSmartBalance(int numcapture, ref ImageBox viewer, ref GridRecognizer grid)
            : base(numcapture, ref viewer)
        {
            gridRecognizer = grid;
        
        }

        public override void ProcessFrame(object sender, EventArgs arg)
        {
            Frame = Capture.RetrieveBgrFrame();
            ProcessBoardThres(Frame);
            switch(imgMode)
            {
                case ImageMode.Original:
                    _viewer.Image = Frame;
                    break;

                case ImageMode.DrawingBox:
                    Frame.Draw(new Rectangle(p1,ps), new Bgr(Color.DarkGreen), 2);
                    Frame.Draw(new Rectangle(p1, ps), new Bgr(Color.LightGreen), 1);
                    _viewer.Image = Frame;
                    break;
                case ImageMode.Gray:
                    Image<Gray, Byte> gray = Frame.Convert<Gray, Byte>();
                    Image<Gray, Byte> range = gray.InRange(new Gray(gridRecognizer.Brightness), new Gray(255));
                    _viewer.Image = range;
                    break;
                case ImageMode.ShowGrid:
                    Frame.Draw(gridRecognizer._box, new Bgr(Color.DarkGreen), 2);
                    Frame.Draw(gridRecognizer._box, new Bgr(Color.LightGreen), 1);
                    foreach (LineSegment2D line in gridRecognizer.hlines)
                    {
                        Frame.Draw(line, new Bgr(Color.DarkGreen), 2);
                        Frame.Draw(line, new Bgr(Color.LightGreen), 1);
                    }
                    foreach (LineSegment2D line in gridRecognizer.vlines)
                    {
                        Frame.Draw(line, new Bgr(Color.DarkGreen), 2);
                        Frame.Draw(line, new Bgr(Color.LightGreen), 1);
                    }
                    _viewer.Image = Frame;
                    break;

                case ImageMode.GrayShowGrid:
                    Image<Gray, Byte> gray2 = Frame.Convert<Gray, Byte>();
                    Image<Gray, Byte> range2 = gray2.InRange(new Gray(gridRecognizer.Brightness), new Gray(255));
                    Image<Bgr, Byte> color = new Image<Bgr, Byte>(range2.Bitmap);

                    color.Draw(gridRecognizer._box, new Bgr(Color.DarkGreen), 2);
                    color.Draw(gridRecognizer._box, new Bgr(Color.LightGreen), 1);
                    foreach (LineSegment2D line in gridRecognizer.hlines)
                    {
                        color.Draw(line, new Bgr(Color.DarkGreen), 2);
                        color.Draw(line, new Bgr(Color.LightGreen), 1);
                    }
                    foreach (LineSegment2D line in gridRecognizer.vlines)
                    {
                        color.Draw(line, new Bgr(Color.DarkGreen), 2);
                        color.Draw(line, new Bgr(Color.LightGreen), 1);
                    }

                    _viewer.Image = color;
                    break;
                case ImageMode.ShowBall:
                    Image<Hsv, Byte> hsv2 = Frame.Convert<Hsv, Byte>();
                    Image<Gray, Byte> range3 = GetThresholdedImage(hsv2);
                    Image<Bgr, Byte> color2 = new Image<Bgr, Byte>(range3.Bitmap);
                    CalcPosition(range3);
                    color2.Draw(circle, new Bgr(Color.DarkGreen), 2);
                    color2.Draw(circle, new Bgr(Color.LightGreen), 1);
                    _viewer.Image = color2;
                    Frame.Draw(circle, new Bgr(Color.DarkGreen), 2);
                    Frame.Draw(circle, new Bgr(Color.LightGreen), 1);
                    //_viewer.Image = Frame;
                    break;
                case ImageMode.Board:
                    Image<Gray, Byte> board = Frame.Convert<Gray, Byte>();
                    Image<Gray, Byte> brange = board.InRange(new Gray(gridRecognizer.BoardMin), new Gray(gridRecognizer.BoardMax));
                    _viewer.Image = brange;
                    break;
                case ImageMode.BoardShowGrid:
                    Image<Bgr, Byte> color3 = new Image<Bgr, Byte>(BoardSpectra.Bitmap);
                    PointF Center = CalcRealCenterAverage(GetGravityCenter(BoardSpectra));
                    int MaxRadius = GetRadius(BoardSpectra, Center, 20);
                    CircleF Circle = new CircleF(Center, 10);
                    color3.Draw(Circle, new Bgr(Color.Red), 2);
                    _viewer.Image = color3;

                    break;
                default:
                    break;
                case ImageMode.Player:
                    gridRecognizer._box.Location = AutoCenter;
                    gridRecognizer.UpdateGrid();
                    gridRecognizer.GetHorizontalLines();
                    gridRecognizer.GetVerticalLines();

                    Frame.Draw(gridRecognizer._box, new Bgr(Color.DarkGreen), 2);
                    Frame.Draw(gridRecognizer._box, new Bgr(Color.LightGreen), 1);
                    foreach (LineSegment2D line in gridRecognizer.hlines)
                    {
                        Frame.Draw(line, new Bgr(Color.DarkGreen), 2);
                        Frame.Draw(line, new Bgr(Color.LightGreen), 1);
                    }
                    foreach (LineSegment2D line in gridRecognizer.vlines)
                    {
                        Frame.Draw(line, new Bgr(Color.DarkGreen), 2);
                        Frame.Draw(line, new Bgr(Color.LightGreen), 1);
                    }

                    Frame = DrawBlockedPositions(Frame);
                    Frame = DrawPath(Frame);

                    /*Draw Ball*/

                    Image<Hsv, Byte> hsv5 = Frame.Convert<Hsv, Byte>();
                    Image<Gray, Byte> range5 = GetThresholdedImage(hsv5);
 
                    CalcPosition(range5);
                    Frame.Draw(circle, new Bgr(Color.DarkBlue), 2);
                    Frame.Draw(circle, new Bgr(Color.LightBlue), 1);

                    _viewer.Image = Frame;
                    break;
            }
        }
        public void TakeGridFrame()
        {
            Image<Gray, Byte> gray = Capture.RetrieveBgrFrame().Convert<Gray, Byte>();
            GridFrame = gray.InRange(new Gray(gridRecognizer.Brightness), new Gray(255)); 
        }
        public Image<Gray, Byte> ProcessBoardThres(Image<Bgr, Byte> Frame)
        {
            Image<Gray, Byte> grayFrame = Frame.Convert<Gray, Byte>();
            Image<Gray, Byte> smallGrayFrame = grayFrame.PyrDown();
            Image<Gray, Byte> smoothedGrayFrame = smallGrayFrame.PyrUp();
            Image<Gray, Byte> cannyFrame = smoothedGrayFrame.Canny(gridRecognizer.BoardMin, gridRecognizer.BoardMax).Dilate(gridRecognizer.Dilate).Erode(gridRecognizer.Erode);
            BoardSpectra = cannyFrame;
            PointF Center = CalcRealCenterAverage(GetGravityCenter(BoardSpectra));

            AutoCenter = new Point(
                            (int)Center.X - (int)(gridRecognizer._box.Width/2),
                            (int)Center.Y - (int)(gridRecognizer._box.Height/2));
            
            return cannyFrame;
        }
        private Image<Gray, Byte> GetThresholdedImage(Image<Hsv, Byte> imgHSV)
        {
            Image<Gray, Byte> imgThresh = new Image<Gray, Byte>(imgHSV.Width, imgHSV.Height);
            imgThresh = imgHSV.InRange(new Hsv(72, 100, 30), new Hsv(141, 256, 256));
            imgThresh._Erode(1);
            return imgThresh;
        }
        public Image<Gray, Byte> GetGrayImage()
        {
            Image<Bgr, Byte> smooth = Frame.SmoothGaussian(3, 3, 34.3, 45.3);
            Image<Hsv, Byte> hsvImage = smooth.Convert<Hsv, Byte>();
            Image<Gray, Byte> imgThresh = GetThresholdedImage(hsvImage);

            MCvMoments moments = imgThresh.GetMoments(true);

            PointF center = new PointF((float)moments.GravityCenter.x, (float)moments.GravityCenter.y);
            CircleF circle = new CircleF(center, GetRadius(imgThresh, center));
            Gray color = new Gray(185.0);
            imgThresh.Draw(circle, color, 3);

            return imgThresh;
        }

        private PointF CalcRealCenterAverage(PointF c)
        {
            centersAvr.Add(c);
            if (centersAvr.Count > 5)
                centersAvr.RemoveAt(0);
            float x=0;
            float y = 0;

            foreach(PointF p in centersAvr)
            {
                x += p.X;
                y += p.Y;
            }
            return new PointF(x / centersAvr.Count, y / centersAvr.Count);
        }
        private void CalcPosition(Image<Gray, Byte> imgThresh)
        {
            MCvMoments moments = imgThresh.GetMoments(true);

            center = new PointF((float)moments.GravityCenter.x, (float)moments.GravityCenter.y);
            Radius = GetRadius(imgThresh, center);
            circle = new CircleF(center, Radius);

            //Gray color = new Gray(185.0);
            //imgThresh.Draw(circle, color, 3);
        }
        private PointF GetGravityCenter(Image<Gray, Byte> imgThresh)
        {
            MCvMoments moments = imgThresh.GetMoments(true);

            return new PointF((float)moments.GravityCenter.x, (float)moments.GravityCenter.y);
        }
        private int GetRadius(Image<Gray, Byte> img, PointF center)
        {
            Bitmap bitmap = img.Bitmap;
            int radius1 = 0;
            int radius2 = 0;
            int radius3 = 0;
            int radius4 = 0;
            float x, y;
            for (x = center.X; x < bitmap.Width; x += 8)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius1 += 8;
            }
            for (x = center.X; x > 0; x -= 8)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius2 += 8;
            }
            for (y = center.Y; y < bitmap.Height; y += 8)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius3 += 8;
            }
            for (y = center.Y; y > 0; y -= 8)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius4 += 8;
            }
            return (radius1 + radius2 + radius3 + radius4) / 4;
        }
        private int GetRadius(Image<Gray, Byte> img, PointF center, int step)
        {
            Bitmap bitmap = img.Bitmap;
            int radius1 = 0;
            int radius2 = 0;
            int radius3 = 0;
            int radius4 = 0;
            float x, y;
            for (x = center.X; x < bitmap.Width; x += step)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius1 += step;
            }
            for (x = center.X; x > 0; x -= step)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius2 += step;
            }
            for (y = center.Y; y < bitmap.Height; y += step)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius3 += step;
            }
            for (y = center.Y; y > 0; y -= step)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius4 += step;
            }
            return (radius1 + radius2 + radius3 + radius4) / 4;
        }

        public Image<Bgr,Byte> DrawBlockedPositions(Image<Bgr,Byte> Frame)
        {
            for(int i = 0; i< gridRecognizer._Rows; i++)
            {
                for(int j = 0; j< gridRecognizer._Columns; j++)
                {
                    if(gridRecognizer.GetPosition(i,j))
                    {
                        LineSegment2D l;
                        int tX = gridRecognizer._box.X + (i * gridRecognizer.gridWidth);
                        int tY = gridRecognizer._box.Y + (j * gridRecognizer.gridHeight);

                        l = new LineSegment2D(new Point(tX, tY), new Point(tX + gridRecognizer.gridWidth, tY + gridRecognizer.gridHeight));
                        Frame.Draw(l, new Bgr(Color.DarkRed), 2);
                        l = new LineSegment2D(new Point(tX, tY + gridRecognizer.gridHeight), new Point(tX + gridRecognizer.gridWidth, tY));
                        Frame.Draw(l, new Bgr(Color.DarkRed), 2);
                    }
                }
            }
            return Frame;
        }
        public Image<Bgr,Byte> DrawPath(Image<Bgr,Byte> Frame)
        {
            if(!gridRecognizer.Intersect(new Point((int)center.X, (int)center.Y)))
                goto end;
            string err = gridRecognizer.CheckPreliminarErrors();
            //if (err.Length > 0)
            //    goto end;

            int gridWidth = gridRecognizer.gridWidth;
            int gridHeight = gridRecognizer.gridHeight;

            Point cen = new Point((int)((center.X - gridRecognizer._box.X) / gridWidth), (int)((center.Y - gridRecognizer._box.Y) / gridHeight));

            gridRecognizer.StartPoint = cen;
            solver = new PathSolver(gridRecognizer);
            solver.Silence = true;
            PathSequence path = solver.Solve();
            
            if (path.IsEmpty())
                goto end;

            int CurrentX = gridRecognizer.StartPoint.X;
            int CurrentY = gridRecognizer.StartPoint.Y;

            NextStep = path.Steps[0].sType;
            foreach (PathStep step in path.Steps)
            {
                Point p1, p2;

                switch (step.sType)
                {
                    case StepsTypes.Up:
                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, (CurrentY * gridHeight) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + +gridRecognizer._box.X, ((CurrentY + 1) * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, (CurrentY * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3 / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, (CurrentY * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);
                        CurrentY--;
                        break;

                    case StepsTypes.Down:
                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, (CurrentY * gridHeight) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, ((CurrentY + 1) * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight * 3 / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, ((CurrentY + 1) * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3 / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight * 3 / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX * gridWidth) + (gridWidth / 2) + gridRecognizer._box.X, ((CurrentY + 1) * gridHeight) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);
                        CurrentY++;
                        break;

                    case StepsTypes.Left:
                        p1 = new Point(CurrentX * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX + 1) * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 4) + gridRecognizer._box.Y);
                        p2 = new Point(CurrentX * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight * 3 / 4) + gridRecognizer._box.Y);
                        p2 = new Point(CurrentX * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);
                        CurrentX--;
                        break;

                    case StepsTypes.Right:
                        p1 = new Point(CurrentX * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX + 1) * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3 / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX + 1) * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);

                        p1 = new Point((CurrentX * gridWidth) + (gridWidth * 3 / 4) + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight * 3 / 4) + gridRecognizer._box.Y);
                        p2 = new Point((CurrentX + 1) * gridWidth + gridRecognizer._box.X, (CurrentY * gridHeight) + (gridHeight / 2) + gridRecognizer._box.Y);
                        Frame.Draw(new LineSegment2D(p1, p2), new Bgr(Color.Purple), 3);
                        CurrentX++;
                        break;
                }
            }

            end:
            return Frame;
        }
    }
}
