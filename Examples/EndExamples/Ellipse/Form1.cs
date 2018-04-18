using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ellipse
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics gfx;
        PointF cur, cur2;
        Pen pen= new Pen(Color.Black, 2f);
        float R = 10;
        int N = 10;
        int _ticks = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();

            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            cur = cur2;
            timer1.Start();
            R = 15;
            _ticks = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _ticks++;
            DrawCircle();
            if (_ticks == 20)
            {
                timer1.Stop();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            cur2 = e.Location;
        }

        private void DrawCircle()
        {
            pen.Color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            gfx.DrawEllipse(pen, GetRectangle());
            R = R + 10;
            pictureBox1.Refresh();
        }

        private RectangleF GetRectangle()
        {
            PointF p = new PointF(cur.X - R, cur.Y - R);
            RectangleF rect = new RectangleF(p, new SizeF(2 * R, 2 * R));
            return rect;
        }
    }
}
