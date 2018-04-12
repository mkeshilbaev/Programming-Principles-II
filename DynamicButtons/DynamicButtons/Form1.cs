using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicButtons
{
    public partial class Form1 : Form
    {
        int n = 10;
        int size = 50;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void AddButtons()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Button btn = new Button();
                    btn.Name = i + "_" + j;
                    btn.Size = new Size(size, size);
                    btn.Location = new Point(i * size, j * size);

                    btn.Click += button_Click;
                    this.Controls.Add(btn);
                }
            }
            Clear();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Clear();
            Button btn = sender as Button;
            int x = int.Parse(btn.Name[0].ToString());
            int y = int.Parse(btn.Name[2].ToString());

            for (int i = 0; i < n; i++)
            {
                this.Controls[n * i + y].BackColor = Color.Red;
                this.Controls[n * x + i].BackColor = Color.Red;
            }
        }

        private void Clear()
        {
            for (int i = 0; i < n * n; i++)
            {
                this.Controls[i].BackColor = Color.White;
            }
        }
    }
}