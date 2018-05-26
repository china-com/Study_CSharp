using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestFour_1;

namespace TestFour_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"E:\workspace\Visual Studio\Study_CSharp\Test\TestFour_1\loadFile.rtf", RichTextBoxStreamType.PlainText);
            MessageBox.Show("保存成功!");
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(@"E:\workspace\Visual Studio\Study_CSharp\Test\TestFour_1\loadFile.rtf", RichTextBoxStreamType.PlainText);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("请输入替换的内容！");
            }
            else
            {
                richTextBox1.SelectionColor = Color.Red;
                richTextBox1.SelectedText = textBox2.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
