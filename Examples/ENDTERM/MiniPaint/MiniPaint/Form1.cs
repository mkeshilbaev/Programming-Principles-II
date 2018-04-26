﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public bool cliked;
        Graphics g;
        public int x, y;

        public Form1()
        {
            InitializeComponent();
            cliked = false;
            g = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            g.DrawRectangle(new Pen(Color.Black, 2), x, y, 50, 50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            g.DrawEllipse(new Pen(Color.Black, 2), x, y, 50, 50);
        }

       
        
    } 
}

