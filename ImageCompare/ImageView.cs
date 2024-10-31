using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ImageCompare
{
    public class ImageView : PictureBox
    {
        private static PointF pan = new PointF(0.0f, 0.0f);// On raw src rect
        private static float scale = 20.0f;

        static RectangleF imageRect = new RectangleF();
        private System.ComponentModel.IContainer components;
        static RectangleF viewRect = new RectangleF();

        public void FitImage()
        {

        }

        public void Free()
        {
            mBitmap?.Dispose();
        }

        public void UpdateViewRect()
        {
            int w = Width;
            int h = Height;

            imageRect.X = pan.X;
            imageRect.Y = pan.Y;
            imageRect.Width = w / scale;
            imageRect.Height = h / scale;

            viewRect.X = 0;
            viewRect.Y = 0;
            viewRect.Width = w;
            viewRect.Height = h;
        }

        //private System.Drawing.Image mImage = null;
        private Bitmap mBitmap = null;

        public ImageView(string imPath) : base()
        {
            //mImage = System.Drawing.Image.FromFile("D:/data/test/aa_cpu.tif");
            if (imPath != null)
            {
                mBitmap = new Bitmap(imPath);
            }

            MouseDown += new MouseEventHandler(this.MouseDownHandler);
            MouseMove += new MouseEventHandler(this.MouseMoveHandler);
            MouseUp += new MouseEventHandler(this.MouseUpHandler);
            MouseWheel += new MouseEventHandler(this.MouseWheelHandler);
        }

        private void ImageView_MouseWheel(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        bool panning = false;
        Point mouseStart;
        PointF oldPan;
        private void MouseDownHandler(object sender, MouseEventArgs e)
        {
            panning = true;
            mouseStart = new Point(e.X, e.Y);
            oldPan = pan;
        }


        private void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if(panning)
            {
                int moveX = e.X - mouseStart.X;
                int moveY = e.Y - mouseStart.Y;

                pan.X = oldPan.X - (moveX / scale);
                pan.Y = oldPan.Y - (moveY / scale);

                UpdateViewRect();
                Form1.instance.UpdateImages();
            }

            // Color
            int rawX = (int)(e.X / scale + imageRect.X + 0.5);
            int rawY = (int)(e.Y / scale + imageRect.Y + 0.5);

            if(rawX >= 0 && rawY >= 0 && rawX < mBitmap.Width && rawY < mBitmap.Height)
            {
                Color c = mBitmap.GetPixel(rawX, rawY);
                Form1.instance.UpdateColorText(rawX, rawY, c);
            }
        }

        private void MouseUpHandler(object sender, MouseEventArgs e)
        {
            panning = false;
        }

        private void MouseWheelHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Old size {imageRect.X}, {imageRect.Y} + {imageRect.Width}, {imageRect.Height}");

            Console.WriteLine($"Mouse {e.X}, {e.Y}");

            PointF rawPoint = new PointF();
            rawPoint.X = (e.X / scale);
            rawPoint.Y = (e.Y / scale);

            Console.WriteLine($"raw {rawPoint.X}, {rawPoint.Y}");


            float newScale = scale + (float)e.Delta / 200;
            newScale = Math.Max(Math.Min(newScale, 20.0f), 0.1f);


            float scaleChange = newScale / scale;


            pan.X += (rawPoint.X * (scaleChange - 1));
            pan.Y += (rawPoint.Y * (scaleChange - 1));



            scale = newScale;

            UpdateViewRect();
            Form1.instance.UpdateImages();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            if (mBitmap != null)
            {
                Graphics g = pe.Graphics;

                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(mBitmap, viewRect, imageRect, GraphicsUnit.Pixel);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            UpdateViewRect();
            this.Refresh();
            base.OnResize(e);
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
