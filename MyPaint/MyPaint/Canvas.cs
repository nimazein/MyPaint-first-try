using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Canvas : Form
    {
        private int oldX, oldY;
        private Bitmap bmp;
        public bool IsLine = false;
        public Canvas()
        {
            InitializeComponent();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pictureBox1.Image = bmp;

        }
        public Canvas(String FileName)
        {
            InitializeComponent();
            bmp = new Bitmap(FileName);
            Graphics g = Graphics.FromImage(bmp);
            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            pictureBox1.Image = bmp;
        }


        public int CanvasWidth
        {
            get
            {
                return pictureBox1.Width;
            }
            set
            {
                pictureBox1.Width = value;
                Bitmap tbmp = new Bitmap(value, pictureBox1.Width);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        public int CanvasHeight
        {
            get
            {
                return pictureBox1.Height;
            }
            set
            {
                pictureBox1.Height = value;
                Bitmap tbmp = new Bitmap(pictureBox1.Width, value);
                Graphics g = Graphics.FromImage(tbmp);
                g.Clear(Color.White);
                g.DrawImage(bmp, new Point(0, 0));
                bmp = tbmp;
                pictureBox1.Image = bmp;
            }
        }

        private bool IsClicked = false;
        int X = 0;
        int Y = 0;
        int X1 = 0;
        int Y1 = 0;
        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsLine)
            {
                if (IsClicked)
                {
                    X1 = e.X;
                    Y1 = e.Y;
                    pictureBox1.Invalidate();
                }
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    Graphics g = Graphics.FromImage(bmp);
                    g.DrawLine(new Pen(MainForm.CurColor, MainForm.CurWidth), oldX, oldY, e.X, e.Y);
                    oldX = e.X;
                    oldY = e.Y;

                    pictureBox1.Invalidate();
                }
            }

            
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (IsLine)
            {
                IsClicked = true;
                X = e.X;
                Y = e.Y;
            }
            else
            {
                oldX = e.X;
                oldY = e.Y;
            }
            
        }

        public string SavedFile = null;
        public void SaveAs()
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.AddExtension = true;
            dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
            ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                SavedFile = dlg.FileName;
                bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
            }
        }

        public void Save()
        {
            if (SavedFile == null)
            {
                SaveFileDialog dlg = new SaveFileDialog();              
                dlg.AddExtension = true;
                dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpg)|*.jpg";
                ImageFormat[] ff = { ImageFormat.Bmp, ImageFormat.Jpeg };
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    SavedFile = dlg.FileName;
                    bmp.Save(dlg.FileName, ff[dlg.FilterIndex - 1]);
                }
            }
            else
            {
                bmp.Save(SavedFile);
            }
            
        }
        public void DrawTransparent(int n, double r, Color CurColor, int curWidth)
        {

            int width = (int)(r * 2 + 10);
            Bitmap bmp = new Bitmap(width, width);

            Graphics graph = Graphics.FromImage(bmp);
            Pen pen = new Pen(CurColor, curWidth);

            double R = r / 2;
            double alpha = 0;
            double x0 = r + 10, y0 = r + 10;

            PointF[] points = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;

            for (int k = 0; k <= 2 * n; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                a += da;
            }

            graph.DrawLines(pen, points);

            pictureBox1.Image = bmp;
        }
        public void DrawPainted(int n, double r, Color CurColor)
        {
            int width = (int)(r * 2 + 10);
            Bitmap bmp = new Bitmap(width, width);

            Graphics graph = Graphics.FromImage(bmp);
            Brush brush = new SolidBrush(CurColor);

            double R = r / 2;
            double alpha = 0;
            double x0 = r + 10, y0 = r + 10;

            PointF[] points = new PointF[2 * n + 1];
            double a = alpha, da = Math.PI / n, l;

            for (int k = 0; k <= 2 * n; k++)
            {
                l = k % 2 == 0 ? r : R;
                points[k] = new PointF((float)(x0 + l * Math.Cos(a)), (float)(y0 + l * Math.Sin(a)));
                a += da;
            }

            graph.FillClosedCurve(brush, points);

            pictureBox1.Image = bmp;
        }

        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            IsClicked = false;
           // Graphics graphics = Graphics.FromImage()
        }

        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Pen pen = new Pen(MainForm.CurColor, MainForm.CurWidth);
            e.Graphics.DrawLine(pen, new Point(X, Y), new Point(X1, Y1));


        }

    }
}
