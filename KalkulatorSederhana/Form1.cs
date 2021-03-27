using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhana
{
    public partial class Form1 : Form
    {
        string sign;
        double val1;
        double val2;
        int trackkeypoint = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + button10.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(textBox1.Text);
            double result;

            if (sign == "+")
            {
                result = val1 + val2;
                textBox1.Text = result.ToString();
            }

            else if (sign == "-")
            {
                result = val1 - val2;
                textBox1.Text = result.ToString();
            }

            else if (sign == "*")
            {
                result = val1 * val2;
                textBox1.Text = result.ToString();
            }

            else
            {
                result = val1 / val2;
                textBox1.Text = result.ToString();
            }
        }
    }
}
