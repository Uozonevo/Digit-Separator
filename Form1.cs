using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECE2310_HW3_part1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input, num1, num2, num3, num4, num5;

            input = int.Parse(textBox1.Text);
            num1 = input / 10000 % 10;
            num2 = input / 1000 % 10;
            num3 = input / 100 % 10;
            num4 = input / 10 % 10;
            num5 = input % 10;

            textBox2.Text = num1.ToString();
            textBox3.Text = num2.ToString();
            textBox4.Text = num3.ToString();
            textBox5.Text = num4.ToString();
            textBox6.Text = num5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
