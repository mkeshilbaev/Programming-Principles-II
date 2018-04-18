using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CIrcles
{
    public partial class Form1 : Form
    {
        Graphics g;
        PointF cur, cur2;
        Pen pen = new Pen(Color.Black, 2f);
        float Rd = 10;
        int N = 10;
        int _ticks = 0;
        Random rand = new Random();
        GraphicsPath gp = new GraphicsPath();

        public Form1()
        {
            InitializeComponent();
            g =  CreateGraphics();
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

        private void DrawCircle()
        {
            pen.Color = Color.FromArgb(rand.Next(0, 256), rand.Next(0, 256), rand.Next(0, 256));
            g.DrawEllipse(pen, GetRectangle());
            Rd = Rd + 10;
            pictureBox1.Refresh();
        }

        private RectangleF GetRectangle()
        {
            PointF p = new PointF(cur.X - R, cur.Y - R);
            RectangleF rect = new RectangleF(p, new SizeF(2 * R, 2 * R));
            return rect;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cur = cur2;
            timer1.Start();
            R = 15;
            _ticks = 0;
        }

        private void pictureBox1_Move(object sender, EventArgs e)
        {
            cur2 = e.Location;
        }
    }
}
