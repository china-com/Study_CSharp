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

namespace TestSeven
{
    public partial class Form1 : Form
    {
        string conntxt = "server=localhost;User Id=root;password=admin;Database=studydemo";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = null;
            MySqlDataAdapter dataadapter = null;
            DataSet ds = null;
            
            try
            {
                conn = new MySqlConnection(conntxt);
                conn.Open();
                dataadapter = new MySqlDataAdapter();
                ds = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT * FROM student";
                dataadapter.SelectCommand = cmd;
                dataadapter.Fill(ds, "t1");
                cmd.CommandText = "select * from teacher";
                dataadapter.SelectCommand = cmd;
                dataadapter.Fill(ds, "t2");
                string s = " ";
                for (int i = 0; i < ds.Tables["t1"].Columns.Count; i++)
                {
                    s += ds.Tables["t1"].Columns[i].ToString() + "\t";
                }
                listBox1.Items.Add(s);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = ds.Tables[0].Rows[i];
                    s = "";
                    for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                    {
                        s += dr[j].ToString() + "\t";
                    }
                    listBox1.Items.Add(s);
                }
                textBox1.DataBindings.Add("Text", ds, "t2.t_name");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "t2";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
                if (ds != null)
                {
                    ds.Dispose();
                }
                if (dataadapter != null)
                {
                    dataadapter.Dispose();
                }
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
