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
    public enum ImageModeObj
    {
        Original,
        Thresholded,
        Object,
        ThresholdedObj
    }
    public class ObjectRecognizer : CameraHandler
    {
        public ImageModeObj imgMode = ImageModeObj.Original;
        private Hsv minVal;
        private Hsv maxVal;
        private int Radius;
        PointF center;
        CircleF circle;

        public ObjectRecognizer(int numcapture, ref ImageBox viewer) : base(numcapture, ref viewer)
        {

        }

        public void SetMinVal(int hue, int saturation, int value)
        {
            minVal = new Hsv(hue, saturation, value);
        }
        public void SetMaxVal(int hue, int saturation, int value)
        {
            maxVal = new Hsv(hue, saturation, value);
        }
        public override void ProcessFrame(object sender, EventArgs arg)
        {
            Frame = Capture.RetrieveBgrFrame();
            switch (imgMode)
            {
                case ImageModeObj.Original:
                    _viewer.Image = Frame;
                    break;

                case ImageModeObj.Thresholded:
                    Image<Hsv, Byte> hsv = Frame.Convert<Hsv, Byte>();
                    Image<Gray, Byte> range = GetThresholdedImage(hsv);
                    _viewer.Image = range;
                    break;
                case ImageModeObj.Object:
                    Image<Hsv, Byte> hsv1 = Frame.Convert<Hsv, Byte>();
                    Image<Gray, Byte> range1 = GetThresholdedImage(hsv1);
                    CalcPosition(range1);
                    Frame.Draw(circle, new Bgr(Color.DarkGreen), 2);
                    Frame.Draw(circle, new Bgr(Color.LightGreen), 1);
                    _viewer.Image = Frame;
                    break;

                case ImageModeObj.ThresholdedObj:
                    Image<Hsv, Byte> hsv2 = Frame.Convert<Hsv, Byte>();
                    Image<Gray, Byte> range2 = GetThresholdedImage(hsv2);
                    Image<Bgr, Byte> color = new Image<Bgr, Byte>(range2.Bitmap);
                    CalcPosition(range2);
                    color.Draw(circle, new Bgr(Color.DarkGreen), 2);
                    color.Draw(circle, new Bgr(Color.LightGreen), 1);
                    _viewer.Image = color;
                    break;
                default:
                    break;
            }
        }

        public void CalcPosition(Image<Gray, Byte> imgThresh)
        {
            MCvMoments moments = imgThresh.GetMoments(true);

            center = new PointF((float)moments.GravityCenter.x, (float)moments.GravityCenter.y);
            Radius = GetRadius(imgThresh, center);
            circle = new CircleF(center, Radius);

            //Gray color = new Gray(185.0);
            //imgThresh.Draw(circle, color, 3);
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

        public int GetRadius(Image<Gray, Byte> img, PointF center)
        {
            Bitmap bitmap = img.Bitmap;
            int radius1 = 0;
            int radius2 = 0;
            int radius3 = 0;
            int radius4 = 0;
            float x, y;
            for (x = center.X; x < bitmap.Width; x += 4)
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
            return (radius1 + radius2 + radius3 + radius4) / 4;
        }
        private Image<Gray, Byte> GetThresholdedImage(Image<Hsv, Byte> imgHSV)
        {
            Image<Gray, Byte> imgThresh = new Image<Gray, Byte>(imgHSV.Width, imgHSV.Height);
            imgThresh = imgHSV.InRange(minVal, maxVal);
            return imgThresh;
        }
        
    }
}
