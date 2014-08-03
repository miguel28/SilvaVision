using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.UI;
using Emgu.CV.CvEnum;

namespace VisionRecognition
{
    public class GridRecognizer
    {
        #region declaration
        private Image<Gray, Byte> _image;
        public Rectangle _box;
        public int _Rows,_Columns;
        private bool[] _buffer;
        private const int brightnessLevel = 128;
        public Point StartPoint;
        public Point FinishPoint;

        private int imgWidth;
        private int imgHeight;
        public int xOffset;
        public int yOffset;
        public int gridHeight;
        public int gridWidth;
        public int Brightness;
        public int BoardMin,BoardMax;
        public int Erode, Dilate;
        public int RectWidth, RectLength;
        public bool AutoRect;

        public List<LineSegment2D> vlines = new List<LineSegment2D>();
        public List<LineSegment2D> hlines = new List<LineSegment2D>();
        #endregion

        public GridRecognizer(Rectangle box, int rows, int columns)
        {
            SetGrid(box, rows, columns);
            _image = null;
            _buffer = new bool[rows * columns];
        }
        public void SetGrid(Rectangle box, int rows, int columns)
        {
            _box = box;
            _Rows = rows;
            _Columns = columns;
            xOffset = _box.X;
            yOffset = _box.Y;
            gridHeight = _box.Height / _Rows;
            gridWidth = _box.Width / _Columns;
        }
        public void UpdateGrid()
        {
            xOffset = _box.X;
            yOffset = _box.Y;
            gridHeight = _box.Height / _Rows;
            gridWidth = _box.Width / _Columns;
        }
        public void SetImage(Image<Gray, Byte> img)
        {
            _image = img;

            imgWidth = _image.Width;
            imgHeight = _image.Height;
        }
        public List<LineSegment2D> GetVerticalLines()
        {
            vlines.Clear();
            for (int i = 1; i < _Rows; i++)
            {
                int x1 = (i * gridWidth) + xOffset;
                int y1 = yOffset;
                int x2 = x1;
                int y2 = _box.Bottom;
                vlines.Add(new LineSegment2D(new Point(x1, y1), new Point(x2, y2)));
            }
            return vlines;
        }
        public List<LineSegment2D> GetHorizontalLines()
        {
            hlines.Clear();
            for (int i = 1; i < _Rows; i++)
            {
                int x1 = xOffset;
                int y1 = (i * gridHeight) + yOffset;
                int x2 = _box.Right;
                int y2 = y1;
                hlines.Add(new LineSegment2D(new Point(x1, y1), new Point(x2, y2)));
            }
            return hlines;
        }
        
        #region Image Recognition
        public void Recognize()
        {
            for(int i = 0; i<_Rows; i++)
            {
                for(int j = 0; j<_Columns; j++)
                {
                    Rectangle rec = new Rectangle((i*gridWidth) + xOffset, 
                                                   (j*gridHeight) + yOffset,
                                                   gridWidth,
                                                   gridHeight);

                    SetPosition(i,j,GetGridStep(rec));
                }
            }
        }
        private int PixelBrightness(Color color)
        {
            return (color.B + color.G + color.R) / 3;
        }
        private bool GetGridStep(Rectangle rec)
        {
            Bitmap bitmap = _image.Bitmap;
            int totalBrightness = 0;
            for(int i = rec.X; i< rec.Right; i++)
            {
                for(int j = rec.Y; j < rec.Bottom; j++)
                {
                    Color color = bitmap.GetPixel(i,j);
                    totalBrightness += PixelBrightness(color);
                }
            }
            totalBrightness /= (rec.Width * rec.Height);
            return (totalBrightness <= brightnessLevel);
        }
        #endregion

        #region Buffer Handler
        public bool[] GetBuffer()
        {
            return _buffer;
        }
        public void SetPosition(int x, int y, bool solid)
        {
            if (x < 0 || x >= _Columns || y < 0 || y >= _Rows)
                return;
            _buffer[(y * _Columns) + x] = solid;
        }
        public bool GetPosition(int x, int y)
        {
            if (x < 0 || x >= _Columns || y < 0 || y >= _Rows)
                return true;
            else 
                return _buffer[(y * _Columns) + x];
        }
        public void TogglePosition(Point p)
        {
            bool solid = GetPosition(p.X/gridWidth, p.Y/gridHeight);
            SetPosition(p.X / gridWidth, p.Y / gridHeight, !solid);
        }
        public void ToggleRealPosition(int x, int y)
        {
            int posx = (x-xOffset) / gridWidth;
            int posy = (y-yOffset) / gridHeight;
            bool oldState = GetPosition(posx, posy);
            SetPosition(posx, posy, !oldState);
        }
        public void SetStartPoint(Point p)
        {
            //// Conver click posicion to buffer position
            StartPoint = new Point(p.X / gridWidth, p.Y / gridHeight);
        }
        public void SetFinishPoint(Point p)
        {
            //// Conver click posicion to buffer position
            FinishPoint = new Point(p.X / gridWidth, p.Y / gridHeight);
        }
        #endregion

        public string CheckPreliminarErrors()
        {
            string strRet = "";
            if(StartPoint == null)
                strRet = "The start Point has't been defined yet";
            if (FinishPoint == null)
                strRet = "The finish Point has't been defined yet";
            if (GetPosition(StartPoint.X, StartPoint.Y))
                strRet = "The start Point is in a Solid Position, please get sure where is it.";
            if (GetPosition(FinishPoint.X, FinishPoint.Y))
                strRet = "The Finish Point is in a Solid Position, please get sure where is it.";
            if(FinishPoint == StartPoint)
                strRet = "The Finish Point and the Start Point are in the same place, please get sure where is it each one.";
            return strRet;
        }
        public Bitmap GetRecognizedBitmap()
        {
            Bitmap bm = new Bitmap(_box.Width, _box.Height);

            using (Graphics g = Graphics.FromImage(bm))
            {
                g.Clear(Color.LightGray);
                g.DrawRectangle(Pens.Black, 1, 1, imgWidth, imgHeight);

                for (int i = 0; i < _Rows; i++)
                {
                    for (int j = 0; j < _Columns; j++)
                    {
                        Rectangle rec = new Rectangle((i * gridWidth),
                                                       (j * gridHeight),
                                                       gridWidth,
                                                       gridHeight);
                        if (GetPosition(i, j))
                            g.FillRectangle(Brushes.DarkSlateGray, rec);
                        else
                            g.FillRectangle(Brushes.White, rec);
                        g.DrawRectangle(Pens.Black, rec);
                    }
                }

                if (StartPoint != null)
                    g.FillRectangle(Brushes.Green, StartPoint.X * gridWidth, StartPoint.Y * gridHeight, gridWidth, gridHeight);
       
                if (FinishPoint != null)
                {
                    g.DrawLine(Pens.Red, new Point(FinishPoint.X * gridWidth, FinishPoint.Y * gridHeight),
                    new Point((FinishPoint.X * gridWidth) + gridWidth, (FinishPoint.Y * gridHeight) + gridHeight));

                    g.DrawLine(Pens.Red, new Point(FinishPoint.X * gridWidth, (FinishPoint.Y*gridHeight) + gridHeight),
                        new Point((FinishPoint.X * gridWidth) + gridWidth, FinishPoint.Y * gridHeight));
                }
            }
            return bm;
        }
        public bool Intersect(Point p)
        {
            return (p.X >= _box.X && p.X <= _box.Right) && (p.Y >= _box.Y && p.Y <= _box.Bottom);
        }

    }
}
