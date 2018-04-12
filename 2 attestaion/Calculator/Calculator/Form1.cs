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
        Double a = 0, b = 0;
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
            a = 0;
            label1.Text = "";
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            /* textBox1.Clear();
             value = 0;
             textBox1.Text = "0";
             */
        }

        private void clearLastDigit_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (a != 0)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = btn.Text;
            }
            else
            {
                operation = btn.Text;
                a = Double.Parse(textBox1.Text);
                operation_pressed = true;
            }
            if (operation_pressed == true)
            {
                if (result == 0)
                {
                    {
                        {
                            label1.Text = a + " " + operation;
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
                    b = Double.Parse(textBox1.Text);

                    switch (operation)
                    {
                        case "+":
                            operation_pressed = true;
                            result = a + b;
                            textBox1.Text = Convert.ToString(result);
                            a = result;

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
                            result = a - b;
                            textBox1.Text = Convert.ToString(result);
                            a = result;

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
                            result = a * b;
                            textBox1.Text = Convert.ToString(result);
                            a = result;

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
                            if (b != 0)
                            {
                                result = a / b;
                                textBox1.Text = Convert.ToString(result);
                                a = result;
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

                        default:
                            break;
                    }
                    operation_pressed = false;
                }

                private void percent_Click(object sender, EventArgs e)
                {
                    Double n = a * (double.Parse(textBox1.Text) / 100);
                    textBox1.Text = (n).ToString();
                }

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

                private void memoryClear_Click(object sender, EventArgs e)
                {
                    memory = 0;
                }
            }
        }

        
    
 