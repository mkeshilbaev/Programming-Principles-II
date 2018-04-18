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
                t.y += 5;
            if (t.dir == 2)
                t.x += 5;     
            if (t.dir == 3)
                t.x -= 5;
            if (t.dir == 4)
                t.y -= 5;

            g.Clear(Color.White);
            t.Draw(g);
        }

        
    }
}
