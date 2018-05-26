using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TestSix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conntxt = "server=localhost;User Id=root;password=admin;Database=StudyDemo";
            MySqlConnection conn = new MySqlConnection(conntxt);
            conn.Open();
            string cmdtxt = "select xh,pw from student where xh='" + textBox1.Text + "'and pw='" + textBox2.Text + "'";
            MySqlCommand cd = new MySqlCommand();
            cd.CommandText = cmdtxt;
            cd.Connection = conn;
            MySqlDataReader dbreader = cd.ExecuteReader();
            try
            {
                if (dbreader.HasRows == true)
                {
                    MessageBox.Show("登陆成功！");
                    Form2 fm2 = new Form2();
                    fm2.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("学号或密码错误！");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库操作异常：" + ex.StackTrace.ToString());
            }
            finally
            {
                dbreader.Close();
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
