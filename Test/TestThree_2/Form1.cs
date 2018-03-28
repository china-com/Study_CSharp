using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace TestThree_2
{
    public partial class Form1 : Form
    {
        public static string str;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            str=textBox1.Text;
            Form2 f2=new Form2();
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = System.Configuration.ConfigurationManager.AppSettings["Name"];
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
