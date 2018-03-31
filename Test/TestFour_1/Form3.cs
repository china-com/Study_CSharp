using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFour_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "";
            foreach (object chkbox in this.groupBox1.Controls)
            {
                if (chkbox is CheckBox)
                {
                    if (((CheckBox)chkbox).Checked)
                    {
                        str += ((CheckBox)chkbox).Text + "、";
                    }
                }
            }
            if (radioButton1.Checked==true)
            {
                str += "\r\n性格为：" + radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                str += "\r\n性格为：" + radioButton2.Text;
            }
            else if(radioButton3.Checked == true)
            {
                str += "\r\n性格为：" + radioButton3.Text;
            }
            else  if(radioButton4.Checked == true)
            {
                str += "\r\n性格为：" + radioButton4.Text;
            }
            else  if(radioButton5.Checked == true)
            {
                str += "\r\n性格为：" + radioButton5.Text;
            }
            else if (radioButton6.Checked == true)
            {
                str += "\r\n性格为：" + radioButton6.Text;
            }
            MessageBox.Show("兴趣爱好有：" + str);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
