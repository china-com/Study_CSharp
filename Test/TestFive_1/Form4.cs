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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "纯文本|*.txt";
            op.InitialDirectory = @"E:\workspace\Study_CSharp\Test\TestFive_1";
            op.FilterIndex = 0;
            if (op.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog cp = new ColorDialog();
            cp.AllowFullOpen = true;
            cp.AnyColor = true;
            if (cp.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionColor = cp.Color;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FontDialog fp = new FontDialog();
            fp.Color = richTextBox1.SelectionColor;
            fp.Font = richTextBox1.SelectionFont;
            fp.AllowScriptChange = true;
            fp.ShowColor = true;
            if (fp.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SelectionFont = fp.Font;
                richTextBox1.SelectionColor = fp.Color;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sp = new SaveFileDialog();
            sp.InitialDirectory = @"E:\workspace\Study_CSharp\Test\TestFive_1";
            sp.Filter = "纯文本|*.rtf";
            sp.FileName = "1.rtf";
            if (sp.ShowDialog()==DialogResult.OK)
            {
                richTextBox1.SaveFile(sp.FileName, RichTextBoxStreamType.RichText);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
