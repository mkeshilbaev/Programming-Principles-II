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

namespace Tank
{
    
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp = new Bitmap(@"C:\Users\mkesh\Desktop\bckgrnd.png");
        int speed = 5;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        Tank t = new Tank(250, 250);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
                t.dir = 1;
            if (e.KeyCode == Keys.D)
                t.dir = 2;           
            if (e.KeyCode == Keys.A)
                t.dir = 3;
            if (e.KeyCode == Keys.W)
                t.dir = 4;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (t.dir == 1)
                t.Y += speed;
            if (t.dir == 2)
                t.X += speed;     
            if (t.dir == 3)
                t.X -= speed;
            if (t.dir == 4)
                t.Y -= speed;

            if (t.Y >= this.Height - 70)
            {
                t.Y = this.Height - 70;
            }
            if (t.Y <= 65)
            {
                t.Y = 65;
            }
            if (t.X >= this.Width - 52)
            {
                t.X = this.Width - 52;
            }
            if (t.X <= 60)
            {
                t.X = 60;
            }

            Color pixColor = bmp.GetPixel(t.X, t.Y);
            g.DrawImage(bmp, new Point(0, 0));

            if(pixColor == Color.FromArgb(255, 255, 255))
            {
                speed = 50;
            }
            if (pixColor == Color.FromArgb(34, 9, 210))
            {
                speed = 5;
            }
            if (pixColor == Color.FromArgb(40, 220, 20))
            {
                speed = 10;
            }
            t.Draw(g);         
        }
    }
}
