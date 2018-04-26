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
        Double firstNumber = 0, secondNumber = 0, result = 0;
        String operation = "";
        bool operation_pressed = false;
        bool isFirstNumberEntered = false;
        bool isSecondNumberEntered = false;
        double memory = 0;
        bool equalClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 241;
            textBox1.Width = 215;
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void engineerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 358;
            textBox1.Width = 320;
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button_CLick(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operation_pressed))
                textBox1.Text = "";
                operation_pressed = false;

            Button btn = sender as Button;

            if (btn.Text == "," && !textBox1.Text.Contains(","))
            {
                textBox1.Text += btn.Text;
            }

            else if (btn.Text != ",")
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                }
                textBox1.Text += btn.Text;
            }

            if (equalClicked)
            {
                textBox1.Text = "";
                textBox1.Text += btn.Text;
                equalClicked = false;
            }        
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            result = 0;
            firstNumber = 0;
            secondNumber = 0;
        }

        private void clearEntry_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
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

            
            if (firstNumber != 0 && !operation_pressed)
            {
                equal.PerformClick();
                operation_pressed = true;
                operation = btn.Text;
            }

            else
            {     
                firstNumber = Double.Parse(textBox1.Text);
                operation_pressed = true;
                operation = btn.Text;
                equalClicked = false;
                isFirstNumberEntered = true;
            }

            if (operation_pressed == true)
            {
                if (result == 0)
                {
                    label1.Text = firstNumber + " " + operation;
                }
                else
                    label1.Text = result + " " + operation;
            }
        }

        private void equal_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            operation_pressed = false;

            if (equalClicked == true)
            {
                result += secondNumber;
                textBox1.Text = result.ToString();
            }

            else
            {
                equalClicked = true;
                secondNumber = Double.Parse(textBox1.Text);
            }
             
            switch (operation)
            {
                case "+":
                    operation_pressed = true;
                    result = firstNumber + secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;

                    if (textBox1.Text == "")
                    {
                        result += firstNumber;
                    }

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
                    result = firstNumber - secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;

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
                    result = firstNumber * secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    firstNumber = result;

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
                    if (secondNumber != 0)
                    {
                        result = firstNumber / secondNumber;
                        textBox1.Text = Convert.ToString(result);
                        firstNumber = result;
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
                    result = firstNumber + firstNumber * secondNumber/ 100;
                    textBox1.Text = Convert.ToString(result);

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "Mod":
                    operation_pressed = true;
                    result = firstNumber % secondNumber;
                    textBox1.Text = Convert.ToString(result);
                    label1.Text = firstNumber + " Mod";

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "x^y":
                    operation_pressed = true;
                    result = Math.Pow(firstNumber, secondNumber);
                    textBox1.Text = Convert.ToString(result);
                    label1.Text = firstNumber + "^";

                    if (result != 0)
                    {
                        label1.Text = result + "";
                    }
                    else
                    {
                        label1.Text = "";
                    }
                    break;

                case "Exp":
                    operation_pressed = true;
                    result = Math.Exp(firstNumber);
                    textBox1.Text = Convert.ToString(result);

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
            //   textBox1.Text = result.ToString();
            isSecondNumberEntered = true;
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

        private void Sin_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Sin((Math.PI * n) / 180).ToString());
            label1.Text += "Sin(" + n + ")";
        }

        private void Cos_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Cos((Math.PI * n) / 180)).ToString();
            label1.Text += "Cos(" + n + ")";
        }

        private void Tan_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Tan((Math.PI * n) / 180)).ToString();
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

        private void TenPower_Click(object sender, EventArgs e)
        {
            double n = Double.Parse(textBox1.Text);
            textBox1.Text = (Math.Pow(10, n)).ToString();
            label1.Text += "10^(" + n + ")";
        }

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

        }

        private void Brecket2_Click(object sender, EventArgs e)
        {

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

        private void Exp_Click_1(object sender, EventArgs e)
        {

        }

        private void memoryClear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }
    }
}
