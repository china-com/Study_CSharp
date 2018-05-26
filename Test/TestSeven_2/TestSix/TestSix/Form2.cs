using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestSix
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string conntxt = "server=localhost;User Id=root;password=admin;Database=StudyDemo";

        private void showstudent()
        {
            string cmdtxt = "select * from student";
            
            MySqlConnection conn = new MySqlConnection(conntxt);
            conn.Open();
            MySqlDataAdapter db = new MySqlDataAdapter(cmdtxt, conn);
            DataSet da = new DataSet();
            db.Fill(da, "student");
            dataGridView1.DataSource = da;
            dataGridView1.DataMember = "student";
            conn.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            showstudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showstudent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cmdtxt = "insert into student(xh,xm,pw) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            MySqlConnection conn = new MySqlConnection(conntxt);
            conn.Open();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = conn;
            cm.CommandText = cmdtxt;
            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("学生信息添加成功！", "提示信息");
                textBox1.Text="";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            catch(Exception ex)
            {
                MessageBox.Show("信息添加不成功！" + ex.InnerException.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cmdtxt = "delete from student where xh='" + textBox4.Text + "'";
            MySqlConnection conn = new MySqlConnection(conntxt);
            conn.Open();
            MySqlCommand cm = new MySqlCommand();
            cm.Connection = conn;
            cm.CommandText = cmdtxt;
            if (textBox4.Text.Trim().Length == 0)
            {
                MessageBox.Show("学号不能为空，请重新输入！", "提示信息");
            }
            else
            {
                try
                {
                    cm.ExecuteNonQuery();
                    MessageBox.Show("学生信息删除成功!", "提示信息");
                    textBox4.Text = "";
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("信息删除不成功！"+ex.InnerException.ToString());
                }
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
