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

namespace OracleTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = null;
            OracleDataAdapter DataAdapter = null;
            DataSet dataset = null;
            try
            {
                string ConnectionString = "User ID=scott;Password=tiger;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                DataAdapter = new OracleDataAdapter();
                dataset = new DataSet();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                //cmd.CommandText = "insert into student(no,name,sex,grade) values (9,'张三','男',99)";
                //cmd.ExecuteNonQuery();
                
                cmd.CommandText = "select * from student";
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dataset, "t1");
                cmd.CommandText = "select * from teacher";
                DataAdapter.SelectCommand = cmd;
                DataAdapter.Fill(dataset, "t2");
                string s = " ";
                for (int i = 0; i < dataset.Tables["t1"].Columns.Count; i++)
                {
                    s += dataset.Tables["t1"].Columns[i].ToString() + "\t";
                }
                listBox1.Items.Add(s);
                for (int i = 0; i < dataset.Tables[0].Rows.Count; i++)
                {
                    DataRow dr = dataset.Tables[0].Rows[i];
                    s = "";
                    for (int j = 0; j < dataset.Tables[0].Columns.Count; j++)
                    {
                        s += dr[j].ToString() + "\t";
                    }
                    listBox1.Items.Add(s);
                }
                textBox1.DataBindings.Add("Text", dataset, "t2.t_name");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "t2";
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Dispose();
                }
                if (dataset != null)
                {
                    dataset.Dispose();
                }
                if (DataAdapter != null)
                {
                    DataAdapter.Dispose();
                }
            }
        }
    }
}
