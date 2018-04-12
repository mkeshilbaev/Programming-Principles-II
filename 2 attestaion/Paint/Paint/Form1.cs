﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

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
            ERASER,
            PIPETTE,
            clearAll           
        };

        Tool tool;
        public Color currentColor = Color.Black;

        public Paint()
        {
            InitializeComponent();          
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);         
            pen = new Pen(Color.Black, 2);
            tool = Tool.PEN;
            clicked = false;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black, 2);
            tool = Tool.PEN;
            pictureBox1.BackColor = Color.White;
            clicked = false;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pen.StartCap = LineCap.Round;
            pen.EndCap = LineCap.Round;
        }

        public void Check(int x, int y)
        {
            if (x < 0 || x >= bmp.Width || y < 0 || y >= bmp.Height)
                return;

            if (bmp.GetPixel(x, y) == initcolor)
            {
                bmp.SetPixel(x, y, currentColor);
                q.Enqueue(new Point(x, y));
            }         
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {         
            clicked = true;
            prev = e.Location;

            if (tool == Tool.FILL)
            {
                int x = e.X;
                int y = e.Y;
                initcolor = bmp.GetPixel(x, y);
                q.Enqueue(new Point(x, y));
                bmp.SetPixel(x, y, currentColor);
                q.Enqueue(e.Location);
                while(q.Count != 0)
                {
                    Point p = q.Dequeue();
                    Check(p.X - 1, p.Y);
                    Check(p.X + 1, p.Y);
                    Check(p.X, p.Y - 1);
                    Check(p.X, p.Y + 1);
                }
                pictureBox1.Refresh();
            }
            if (tool == Tool.PIPETTE)
            {
                currentColor = bmp.GetPixel(e.X, e.Y);
                pictureBox2.BackColor = currentColor;
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
            
           // pictureBox1.Refresh();
            
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
          //  pictureBox1.Refresh();

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

        private void button12_Click(object sender, EventArgs e)
        {
            tool = Tool.PIPETTE;
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            tool = Tool.clearAll;
            g.Clear(Color.White);
            pictureBox1.Refresh();

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
            pictureBox2.BackColor = currentColor;
        }       

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            if (clicked)
            {
                switch (tool)
                {
                    case Tool.PEN:
                        break;
                    case Tool.RRECTANGLE:
                        int x = Math.Min(prev.X, cur.X);
                        int y = Math.Min(prev.Y, cur.Y);
                        int w = Math.Abs(prev.X - cur.X);
                        int h = Math.Abs(prev.Y - cur.Y);
                        e.Graphics.DrawRectangle(pen, x, y, w, h);
                        break;
                    case Tool.LINE:
                        break;
                    case Tool.ELLIPSE:
                        break;
                    case Tool.TRIANGLE:
                        break;
                    case Tool.FILL:
                        break;
                    case Tool.ERASER:
                        break;
                    case Tool.PIPETTE:
                        break;
                    case Tool.clearAll:
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
