using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFive_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                MessageBox.Show("您的性别是：" + radioButton1.Text);
            }
            else
            {
                MessageBox.Show("您的性别是：" + radioButton2.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string s = "";
            if (checkBox1.Checked)
            {
                s += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                s += checkBox2.Text;
            }
            MessageBox.Show("您所钟爱的水果是：" + s, "提示信息");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult st;
            st = MessageBox.Show("真的要退出系统？", "提示信息", MessageBoxButtons.OKCancel);
            if (st==DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
