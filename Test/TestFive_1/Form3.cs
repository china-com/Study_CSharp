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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(textBox1.Text))
            {
                MessageBox.Show("已存在了！");
            }
            else
            {
                comboBox1.Items.Add(textBox1.Text);            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim().Length==0)
            {
                MessageBox.Show("需要删除的内容不能为空！");
            }
            else
            {
                int i;
                i = comboBox1.Items.IndexOf(textBox2.Text.Trim());
                if (i>=0)
                {
                    comboBox1.Items.RemoveAt(i);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem!=null)
            {
                comboBox2.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem!=null)
            {
                comboBox1.Items.Add(comboBox2.SelectedItem);
                comboBox2.Items.Remove(comboBox2.SelectedItem);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
