using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EndExamples
{
    public partial class Form1 : Form
    {
        int N = 10;
        int sz = 50;
        public Form1()
        {
            InitializeComponent();
            AddButtons();
        }

        private void AddButtons()
        {
            int k = 0;
            for(int i=0; i<N; i++)
            {
                for(int j=0; j<N; j++)
                {
                    Button btn = new Button();
                    btn.Name = i + "_" + j;
                    btn.Size = new Size(sz, sz);
                    btn.Location = new Point(i*sz, j*sz);

                    btn.Click += btnClick;
                    this.Controls.Add(btn);
                }
            }
            Clear();

        }

        private void btnClick(object sender, EventArgs e)
        {
            Clear();
            Button btn = sender as Button;
            int x = int.Parse(btn.Name[0].ToString());
            int y = int.Parse(btn.Name[2].ToString());
            
            for (int i=0; i<N; i++)
            {
                this.Controls[N * i + y].BackColor = Color.Red;
                this.Controls[N * x + i].BackColor = Color.Red;
            }
        }

        private void Clear()
        {
            for(int i=0; i<N*N; i++)
            {
                this.Controls[i].BackColor = Color.White;
            }
        }
    }
}
