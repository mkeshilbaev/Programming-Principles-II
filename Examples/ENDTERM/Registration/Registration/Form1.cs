using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration
{
    public partial class Form1 : Form
    {
        public string memory = "";
        public string memory1 = "";
        public bool Ok;

        public Form1()
        {
            InitializeComponent();
            Ok = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text.Contains("@"))
                    Ok = true;
                else
                    Ok = false;

                memory = textBox1.Text;
            }
            

           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {          
                if (!textBox1.Text.Contains(""))
                    Ok = true;
            memory1 = textBox2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            if (Ok)
                label3.Text = "Confirmed";
            else
                label3.Text = "Wrong!";
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < textBox3.Text.Length; i++)
            {
                if (textBox1.Text.Contains("@"))
                    Ok = true;
                else
                    Ok = false;
            {
        }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (!textBox4.Text.Contains(""))
                Ok = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            memory = textBox1.Text;
            if (Ok && memory == textBox3.Text && memory1 == textBox4.Text)
                label4.Text = "Confirmed";
            else
                label4.Text = "Wrong!";
        }   
    }
}
