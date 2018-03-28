using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThree_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1, str2;
            double a,b,sum;
            str1 = textBox1.Text;
            str2 = textBox2.Text;
            a = Convert.ToDouble(str1);
            b = Convert.ToDouble(str2);
            if (radioButton1.Checked==true)
            {
                sum = a + b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton2.Checked==true)
            {
                sum = a - b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton3.Checked==true)
            {
                sum = a * b;
                textBox3.Text = sum.ToString();
            }
            else if (radioButton4.Checked==true)
            {
                sum = a / b;
                textBox3.Text = sum.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }
    }
}
