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
    public class CameraHandler
    {
        public Capture Capture;

        public Image<Bgr, Byte> Frame;
        public bool CaptureInProgress;
        public bool CaptureOpened = false;
        protected ImageBox _viewer;

        public CameraHandler(int numcapture, ref ImageBox viewer)
        {
            _viewer = viewer;
            try
            {
                Capture = new Capture();
                Capture.ImageGrabbed += ProcessFrame;
                CaptureOpened = true;

            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }
        public virtual void ProcessFrame(object sender, EventArgs arg)
        {
            Frame = Capture.RetrieveBgrFrame();
            _viewer.Image = Frame;
        }
        public void SetImageBox(ref ImageBox imgbox)
        {
            _viewer = imgbox;
        }
        /*
        public Image<Gray, Byte> GetGrayImage()
        {
            Image<Bgr, Byte> smooth = Frame.SmoothGaussian(3, 3, 34.3, 45.3);
            Image<Hsv, Byte> hsvImage = smooth.Convert<Hsv, Byte>();
            Image<Gray, Byte> imgThresh = GetThresholdedImage(hsvImage);

            MCvMoments moments = imgThresh.GetMoments(true);


            PointF center = new PointF((float)moments.GravityCenter.x, (float)moments.GravityCenter.y);
            CircleF circle = new CircleF(center,GetRadius(imgThresh, center));
            Gray color = new Gray(185.0);
            imgThresh.Draw(circle,color,3);
            


            return imgThresh;
        }
        public int GetRadius(Image<Gray, Byte> img, PointF center)
        {
            Bitmap bitmap = img.Bitmap;
            int radius1 =0;
            int radius2 = 0;
            int radius3 = 0;
            int radius4 = 0;
            float x,y;
            for(x = center.X; x<bitmap.Width; x+=4)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius1 += 4;
            }
            for (x = center.X; x > 0; x -= 4)
            {
                Color color = bitmap.GetPixel((int)x, (int)center.Y);
                if (color.B > 128) radius2 += 4;
            }
            for (y = center.Y; y < bitmap.Height; y += 4)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius3 += 4;
            }
            for (y = center.Y; y > 0; y -= 4)
            {
                Color color = bitmap.GetPixel((int)center.X, (int)y);
                if (color.B > 128) radius4 += 4;
            }
            return (radius1 + radius2 + radius3 + radius4)/4;
        }
        private Image<Gray, Byte> GetThresholdedImage(Image<Hsv, Byte> imgHSV)
        {
            Image<Gray, Byte> imgThresh = new Image<Gray, Byte>(imgHSV.Width, imgHSV.Height);
            imgThresh = imgHSV.InRange(new Hsv(90, 160, 30), new Hsv(130, 256, 256));
            //imgThresh = imgHSV.InRange(new Hsv(0, 0, 120), new Hsv(180, 90, 256));
            return imgThresh;
        } */ 
    }
}
