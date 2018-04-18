using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pricel
{   
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        string[] colors = { "green", "yellow", "blue", "gray" };

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int index = new Random().Next(0, colors.Length);
            Shape shape = new Shape(e.X - 25, e.Y - 25, 50, 50, Color.FromName(colors[index]));
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Shape shape1 = new Shape(10, 10, 50, 50, Color.Red);
            Shape shape2 = new Shape(40, 50, 50, 50, Color.Cyan);
            shape1.Draw(e.Graphics);
            shape2.Draw(e.Graphics);
        }
    }
}
