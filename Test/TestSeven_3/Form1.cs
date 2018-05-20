using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestSeven_3
{
    public partial class Form1 : Form
    {
        string conntxt = "server=localhost;User Id=root;password=admin;Database=studydemo";
        MySqlConnection conn = null;
        MySqlDataAdapter dataadpater = null;
        DataSet dataset = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void showData()
        {
            try
            {
                conn = new MySqlConnection(conntxt);
                conn.Open();
                dataadpater = new MySqlDataAdapter("select * from student", conn);
                dataset = new DataSet();
                dataadpater.Fill(dataset);
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = dataset.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
                dataset.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strSQL = "INSERT into student values(";
            strSQL += "" + textBox1.Text;
            strSQL += "," + "'" + textBox3.Text + "'";
            strSQL += "," + "'" + textBox2.Text + "'";
            strSQL += "," + textBox4.Text + ")";
            MySqlCommand command = null;
            try
            {
                command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = strSQL;
                conn.Open();
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    MessageBox.Show("成功插入数据！");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
                command.Dispose();
            }
            showData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(conntxt);
            showData();
        }
    }
}
