using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULATOR
{
    public partial class Form1 : Form
    {
        Double first = 0, second = 0;
        String operation = "";
        bool operation_pressed = false;
        double memory = 0;
        double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_CLick(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Clear();

            operation_pressed = false;
            Button btn = sender as Button;

            if (btn.Text == ",")
            {
                if (!textBox1.Text.Contains(","))
                {
                    textBox1.Text = textBox1.Text + btn.Text;

                    if (result == 0 || textBox1.Text == "0" || textBox1.Text == "")
                    {
                        textBox1.Text = "0" + btn.Text;
                    }
                }
            }
            else
                textBox1.Text = textBox1.Text + btn.Text;
            result = double.Parse(textBox1.Text);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
            first = 0;
            label1.Text = "";
        }

        private void clearLastDigit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            if (textBox1.Text.Length == 0)
                textBox1.Text += '0';
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (first != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = btn.Text;
            }
            else
            {
                operation = btn.Text;
                first = Double.Parse(textBox1.Text);
                operation_pressed = true;
            }
            if (operation_pressed == true)
            {
                if (result == 0)
                {
                    {
                        {
                            label1.Text = first + " " + operation;
                        }
                    }
                }
                else
                {
                    label1.Text = result + " " + operation;
                }
                    }
                }

                private void equal_Click(object sender, EventArgs e)
                {
                    label1.Text = "";
                    second = Double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    operation_pressed = true;
                    result = first + second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "-":
                    operation_pressed = true;
                    result = first - second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "×":
                    operation_pressed = true;
                    result = first * second;
                    textBox1.Text = Convert.ToString(result);
                    first = result;

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "÷":
                    operation_pressed = true;
                    if (second != 0)
                    {
                        result = first / second;
                        textBox1.Text = Convert.ToString(result);
                        first = result;
                    }

                    else textBox1.Text = "impossible";

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "%":
                    operation_pressed = true;
                    result = first * second / 100;
                    textBox1.Text = Convert.ToString(result);
                    break;

                case "Mod":
                    operation_pressed = true;
                    result = first % second;
                    textBox1.Text = Convert.ToString(result);
                    label1.Text = first + " Mod";
                    break;

                case "x^y":
                    operation_pressed = true;
                    result = Math.Pow(first, second);
                    textBox1.Text = Convert.ToString(result);
                    label1.Text = first + "^";
                    break;

                default:
                    break;
            }
            operation_pressed = false;

                }

               /* private void percent_Click(object sender, EventArgs e)
                {
                    Double n = a * (double.Parse(textBox1.Text) / 100);
                    textBox1.Text = (n).ToString();
                }
               */

                private void root_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Sqrt(n)).ToString();
                    label1.Text += "√(" + n + ")";
                }

                private void square_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    textBox1.Text = (Math.Pow(n, 2)).ToString();
                    label1.Text += "sqr(" + n + ")";
                }

                private void rational_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    textBox1.Text = (1 / n).ToString();
                    label1.Text += "1/(" + n + ")";
                }

                private void plusminus_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    textBox1.Text = (-1 * n).ToString();
                }

                private void memoryStore_Click(object sender, EventArgs e)
                {
                    memory = double.Parse(textBox1.Text);
                    textBox1.Text = "";
                    label1.Text = "";
                }

                private void memoryRecall_Click(object sender, EventArgs e)
                {
                    textBox1.Text = memory.ToString();
                    label1.Text = "";
                }

                private void MemoryAdd_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    memory = memory + n;
                    textBox1.Text = "";
                }

                private void memorySubtract_Click(object sender, EventArgs e)
                {
                    double n = Double.Parse(textBox1.Text);
                    memory = memory - n;
                    textBox1.Text = "";
                }

        private void Sin_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sin((Math.PI * n) / 180).ToString());
            label1.Text += "Sin(" + n + ")";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Cos((Math.PI * n)/180)).ToString();
            label1.Text += "Cos(" + n + ")";
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Tan((Math.PI * n)/180)).ToString();
            label1.Text += "tan(" + n + ")";
        }

        private void log_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Log10(n)).ToString();
            label1.Text += "log(" + n + ")";
        }

        private void Exp_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Exp(n)).ToString();
        }

        /*
        private void Mod_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
           // textBox1.Text = ((n % b)).ToString();
            //abel1.Text += n + " Mod";
        }
        */

        private void TenPower_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(10, n)).ToString();
            label1.Text += "10^(" + n + ")";
        }

        /*
        private void XandYpow_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(a, n)).ToString();
            label1.Text += a + "^";
        }
        */

        private void PI_Click(object sender, EventArgs e)
        {
            textBox1.Text = Math.PI.ToString();
        }

        private void Fact_Click(object sender, EventArgs e)
        {
            result = 1;
            Double n = double.Parse(textBox1.Text);
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            textBox1.Text = Convert.ToString(result);
        }

        private void Brecket1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "(";

        }

        private void Brecket2_Click(object sender, EventArgs e)
        {
            textBox1.Text = ")";
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 241;
            textBox1.Width = 215;
        }

        private void engineerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 400;
            textBox1.Width = 400;
        }

        private void memoryClear_Click(object sender, EventArgs e)
                {
                    memory = 0;
                }
            }
        }

        
    
 