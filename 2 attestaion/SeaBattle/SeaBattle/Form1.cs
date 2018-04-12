using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{   
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        Pen pen;
        List<Point> p = new List<Point>();
        Point cur, prev;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
            g = Graphics.FromImage(bmp);
            pen = new Pen(Color.Black, 2);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
        }

        private void pictureBox1_SeaBattle(object sender, EventArgs e)
        {
            e.DrawRectangle(new Pen(Color.Black, 2), pictureBox1.Width, pictureBox1.Height, 20, 20);
        }
    }
}
