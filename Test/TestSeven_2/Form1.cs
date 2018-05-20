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

namespace TestSeven_2
{
    public partial class Form1 : Form
    {
        string ConnectionString = "server=localhost;User Id=root;password=admin;Database=studydemo";
        MySqlConnection conn = null;
        MySqlDataAdapter dataadapter = null;
        DataSet dataset = null;
        MySqlCommand cmd = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                dataadapter = new MySqlDataAdapter();
                dataset = new DataSet();
                cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM student";
                dataadapter.SelectCommand = cmd;
                dataadapter.Fill(dataset, "t1");
                comboBox1.Items.Clear();
                for (int i = 0; i < dataset.Tables["t1"].Columns.Count; i++)
                {
                    comboBox1.Items.Add(dataset.Tables["t1"].Columns[i].ToString());
                }
                dataset.Clear();
                comboBox2.Items.Add("=");
                comboBox2.Items.Add("<");
                comboBox2.Items.Add(">");
                comboBox2.Items.Add("like");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tb1 = textBox1.Text;
            if (comboBox2.Text == " like ")
            {
                tb1 = "%" + textBox1.Text + "%";
            }
            string strSQL = "SELECT * FROM student WHERE";
            strSQL += " "+comboBox1.Text + comboBox2.Text + "'"+tb1+"'";
            try
            {
                cmd.CommandText = strSQL;
                dataadapter.SelectCommand = cmd;
                dataset.Clear();
                dataadapter.Fill(dataset, "t1");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "t1";
            }
            catch
            {
                MessageBox.Show("请正确设置检索条件！");
            }finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
            }
        }
    }
}
