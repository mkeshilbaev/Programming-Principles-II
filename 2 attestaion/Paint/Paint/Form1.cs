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

        public Paint()
        {
            InitializeComponent();          
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);         
            pen = new Pen(Color.Black, 2);
            tool = Tool.PEN;
            clicked = false;
        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {         
            clicked = true;
            prev = e.Location;
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

            if (tool == Tool.LINE)
            {
                int x1 = Math.Min(prev.X, cur.X);
                int y1 = Math.Min(prev.Y, cur.Y);
                int x2 = Math.Abs(prev.X - cur.X);
                int y2 = Math.Abs(prev.Y - cur.Y);
                g.DrawLine(pen, x1, y1, e.Location.X, e.Location.Y);
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
          
            if (tool == Tool.TRIANGLE)
            {
                
            }


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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            clicked = true;
        }

        private void Button(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            pen.Color = btn.BackColor;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (tool == Tool.RRECTANGLE && clicked == true)
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

        }

    }
}
