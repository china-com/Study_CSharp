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
namespace TestSeven_4
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

        private void showData2()
        {
            string tname = "";
            try
            {
                if (conn==null)
                {
                    conn.Open();
                }
                dataadpater = new MySqlDataAdapter("SELECT * FROM student",conn);
                dataset = new DataSet();
                dataadpater.Fill(dataset);
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = dataset.Tables[0].ToString();
                tname = dataset.Tables[0].ToString();
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox4.DataBindings.Clear();
                textBox1.DataBindings.Add("Text", dataset, "table.sno");
                textBox2.DataBindings.Add("Text", dataset, "table.sex");
                textBox3.DataBindings.Add("Text", dataset, "table.name");
                textBox4.DataBindings.Add("Text", dataset, "table.grade");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(conntxt);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string strSQL = "UPDATE student set ";
            strSQL += "name="+textBox3.Text+"";
            strSQL += ",ex='" + textBox2.Text + "'";
            strSQL += ",graden="  + textBox4.Text ;
            strSQL += "where no='"+ textBox1.Text +"'";
            int index = dataGridView1.CurrentRow.Index;
            MySqlCommand command = null;
            try
            {
                command = new MySqlCommand();
                command.Connection = conn;
                command.CommandText = strSQL;
                conn.Open();
                int n = command.ExecuteNonQuery();
                if (n>0)
                {
                    MessageBox.Show("成功更新数据，有" + n.ToString() + "行更新了！");
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
                    command.Dispose();
                }
            }
            showData2();
            this.dataGridView1.CurrentCell = this.dataGridView1.Rows[index].Cells[0];
            dataGridView1.Rows[index].Selected = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommandBuilder builder = new MySqlCommandBuilder(dataadpater);
                int n = dataadpater.Update(dataset, "Table");
                MessageBox.Show("成功更新数据，有" + n.ToString() + "行更新了！");
            }
            catch
            {
                MessageBox.Show("更新不成功！");
            }
        }
    }
}
