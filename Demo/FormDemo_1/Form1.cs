using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox2.Text);
            switch (i)
            {
                case (int)enumweek.Monday:
                    MessageBox.Show("上课");
                    break;
                case (int)enumweek.Thursday:
                    MessageBox.Show("出去玩");
                    break;
                default:
                    MessageBox.Show("ws");
                    break;
            }
        }
    }
    public enum enumweek
    {
        Monday=1, Tuesday=2, Wednesday=3, Thursday=4, Friday=5, Saturday=6, Sunday=7
    }
}
