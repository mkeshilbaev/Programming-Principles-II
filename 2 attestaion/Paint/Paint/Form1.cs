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

namespace Paint
{
    public partial class Paint : Form
    {
        Graphics g;
        Bitmap bmp;
        bool clicked;
        Point prev, cur;
        Pen pen;
        Queue<Point> q = new Queue<Point>();
        Color initcolor, fillcolor;

        public enum Tool
        {
            PEN,
            RRECTANGLE,
            LINE,
            ELLIPSE,
            TRIANGLE,
            FILL,
            ERASER
        };

        Tool tool;
        private Color currentColor;

        public Paint()
        {
            InitializeComponent();          
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);         
            pen = new Pen(Color.Black, 2);
            tool = Tool.PEN;
            clicked = false;
            Queue<Point> q = new Queue<Point>();
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Check(int x, int y)
        {

            if (cur.X < 0 || cur.Y < 0 || cur.X >= pictureBox1.Width || cur.Y >= pictureBox1.Height)
                return;
            if (bmp.GetPixel(x, y) != initcolor)
                return;
            q.Enqueue(new Point(x, y));
        }

        public void Fill(Point p)
        {          
            while (q.Count != 0)
            {
                Point curPoint = q.Dequeue();
                bmp.SetPixel(curPoint.X, curPoint.Y, fillcolor);
                pictureBox1.Refresh();
                Check(curPoint.X - 1, curPoint.Y);
                Check(curPoint.X, curPoint.Y - 1);
                Check(curPoint.X + 1, curPoint.Y);
                Check(curPoint.X, curPoint.Y + 1);
            }
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {         
            clicked = true;
            prev = e.Location;

            if (tool == Tool.FILL)
            {
              Fill(e.Location);
            }
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == false)
                return;

            cur = e.Location;

            if (clicked == true && tool == Tool.PEN)
            {
                g.DrawLine(pen, prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();

            if (clicked == true && tool == Tool.ERASER)
            {
                g.DrawLine(new Pen(Color.White, 10), prev, cur);
                prev = cur;
            }
            pictureBox1.Refresh();
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
           clicked = false;
           if (tool == Tool.RRECTANGLE && clicked == false)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                g.DrawRectangle(pen, x, y, w, h);
            }
            
            pictureBox1.Refresh();
            
            if(tool == Tool.TRIANGLE)
            {
                g.DrawPolygon(pen, GetTriangle(prev, e.Location));
            }

            if (tool == Tool.LINE)
            {
                int x1 = Math.Min(prev.X, cur.X);
                int y1 = Math.Min(prev.Y, cur.Y);
                int x2 = Math.Abs(prev.X - cur.X);
                int y2 = Math.Abs(prev.Y - cur.Y);
                g.DrawLine(pen, prev.X, prev.Y, e.Location.X, e.Location.Y);
            }
            pictureBox1.Refresh();

            if (tool == Tool.ELLIPSE)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                g.DrawEllipse(pen, x, y, w, h);
            }
            pictureBox1.Refresh();
        }

        private PointF[] GetTriangle(Point p1, Point p2)
        {
            PointF[] points = {new PointF(p1.X, p2.Y),
                               p2,
                               new PointF((p1.X + p2.X)/2, p1.Y) };
            return points;
        }

        private void button1_Click(object sender, EventArgs e)
        
        {
            tool = Tool.PEN;
        }
        
        private void button21_Click(object sender, EventArgs e)
        {
            tool = Tool.RRECTANGLE;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tool = Tool.LINE;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tool = Tool.ELLIPSE;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tool = Tool.ERASER;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = Tool.FILL;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tool = Tool.TRIANGLE;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            clicked = true;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = float.Parse(trackBar1.Value.ToString());
        }

        private void Button(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pen.Color = btn.BackColor;
            currentColor = btn.BackColor;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            if (tool == Tool.RRECTANGLE /*&& clicked == true*/)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawRectangle(pen, x, y, w, h);             
            }

            if (tool == Tool.LINE && clicked == true)
            {
                int x1 = Math.Min(prev.X, cur.X);
                int y1 = Math.Min(prev.Y, cur.Y);
                int x2 = Math.Abs(prev.X - cur.X);
                int y2 = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawLine(pen, x1, y1, x2, y2);
            }

            if (tool == Tool.ELLIPSE && clicked == true)
            {
                int x = Math.Min(prev.X, cur.X);
                int y = Math.Min(prev.Y, cur.Y);
                int w = Math.Abs(prev.X - cur.X);
                int h = Math.Abs(prev.Y - cur.Y);
                e.Graphics.DrawEllipse(pen, x, y, w, h);
            }

            if (tool == Tool.FILL && clicked == true)
            {
                Point curPoint = q.Dequeue();
                bmp.SetPixel(cur.X, cur.Y, fillcolor);
                pictureBox1.Refresh();
            }

        }

    }
}
