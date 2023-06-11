using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicCalculator
{
    public partial class Form : System.Windows.Forms.Form
    {
        public float value1, value2;
        public char sign;
        public Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(textBox1.Text);
            sign = '-';
            textBox1.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(textBox1.Text);
            sign = 'x';
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            value1 = float.Parse(textBox1.Text);
            sign = '/';
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            value2 = float.Parse(textBox1.Text);
            float result;
            if (sign=='+')
            {
                result = value1 + value2;
                textBox1.Text = result.ToString();
            }
            else if (sign=='-')
            {
                result = value1 - value2;
                textBox1.Text = result.ToString();
            }
            else if (sign == 'x')
            {
                result = value1 * value2;
                textBox1.Text = result.ToString();
            }
            else
            {
                result = value1 / value2;
                textBox1.Text = result.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '+';
            textBox1.Text = "";
        }
    }
}
