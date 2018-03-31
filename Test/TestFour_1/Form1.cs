using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFour_2;

namespace TestFour_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
            textBox2.Paste();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Copy();
            textBox1.Paste();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "左边：A\r\n左边：B\r\n左边：C\r\n";
            textBox1.Text = "右边：D\r\n左边：E\r\n";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
