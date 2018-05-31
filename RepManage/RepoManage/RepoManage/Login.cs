using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace RepoManage
{
    public partial class Login : Form
    {
        string ConnectionString = "User ID=chj;Password=123456;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim()==""||textBox2.Text.Trim()=="")
                {
                    label4.Text = "请输入正确的用户名和密码！";
                    return;
                }
                
                string item = "empuser";
                if (comboBox1.Text=="管理员")
                {
                    item = "adminuser";
                }
                //System.Console.Write(comboBox1.SelectedValue.ToString());
                
                string sqlStr = "select * from "+item+" where UserName='"+textBox1.Text.Trim()+"'";
                //string sqlStr = "insert into empuser values ('emp','123456')";
                //DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                //cmd.ExecuteNonQuery();
                OracleDataReader reader = cmd.ExecuteReader();
                if (!reader.Read())
                {
                    label4.Text = "用户名或密码错误，请重新输入！";
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
                else if(reader["Password"].ToString().Trim()==textBox2.Text.Trim())
                {
                    if (comboBox1.Text=="管理员")
                    {
                        Admin ad = new Admin();
                        this.Hide();
                        ad.Show();
                    }
                    else
                    {
                        Employee emp = new Employee();
                        this.Hide();
                        emp.Show();
                    }
                }
                else
                {
                    label4.Text = "密码错误，请重新输入！";
                    textBox2.Text = "";
                    textBox2.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("数据库正忙,请稍后重试！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
    }
}
