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

namespace CarWithClass
{
    public partial class Form1 : Form
    {
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        Car car = new Car(5, 50);

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
                car.dir = 1;
            if (e.KeyCode == Keys.S)
                car.dir = 0;          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (car.dir == 0)
                car.x += 2;

            else
                car.y += 2;

            g.Clear(Color.White);
            car.Draw(g);
        }
    }
}
