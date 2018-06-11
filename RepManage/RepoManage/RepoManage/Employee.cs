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
    public partial class Employee : Form
    {
        string ConnectionString = "User ID=chj;Password=123456;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        public Employee()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void Employee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3601/About.aspx");
        }

        private void 操作员信息管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3601/Default.aspx");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into consumer values ('"+textBox1.Text+"','"+textBox2.Text+"','"+comboBox1.Text+"','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("供应商添加成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from consumer where ConID='" + textBox1.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox2.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    comboBox1.Text = (string)ds.Tables[0].Rows[0][2].ToString().Trim();
                    textBox3.Text = (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox4.Text = (string)ds.Tables[0].Rows[0][4].ToString().Trim();
                    textBox5.Text = (string)ds.Tables[0].Rows[0][5].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的客户编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }*/

        private void 添加客户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "服装商";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void 修改用户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from Consumer where ConID='" + textBox6.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox7.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    comboBox2.Text = (string)ds.Tables[0].Rows[0][2].ToString().Trim();
                    textBox9.Text = (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox8.Text = (string)ds.Tables[0].Rows[0][4].ToString().Trim();
                    textBox25.Text = (string)ds.Tables[0].Rows[0][5].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的供应商编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "服装商";
            textBox9.Text = "";
            textBox8.Text = "";
            textBox25.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "update consumer set ConName='" + textBox7.Text + "',ConClass='" + comboBox2.Text + "',Phone='" + textBox9.Text + "',Address='" + textBox8.Text +"',Remark='" + textBox25.Text + "'" + " where ConID='" + textBox6.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("供应商信息修改成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from consumer where ConID='" + textBox10.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sqlStr1 = "delete from consumer where ConID='" + textBox10.Text.Trim() + "'";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("供应商删除成功！");
                }
                else
                {
                    MessageBox.Show("输入的客户编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 删除客户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from consumer";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(sqlStr,conn);
                adapter.Fill(ds, "table");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "table";
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 查询客户信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox18.Text = "";
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
            textBox23.Text = "";
            dateTimePicker4.Value = DateTime.Now;
            dateTimePicker3.Value = DateTime.Now;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into cargo values ('" + textBox23.Text + "','" + textBox22.Text + "','" + textBox21.Text + "','" +dateTimePicker4.Text+"','"+ textBox20.Text + "','" + textBox18.Text + "'," + textBox19.Text +",'"+dateTimePicker3.Text+ "')";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("货物信息添加成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 添加货物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from cargo where CargoID='" + textBox11.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox12.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    textBox13.Text = (string)ds.Tables[0].Rows[0][2].ToString().Trim();
                    dateTimePicker1.Text= (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox14.Text = (string)ds.Tables[0].Rows[0][4].ToString().Trim();
                    textBox16.Text = (string)ds.Tables[0].Rows[0][5].ToString().Trim();
                    textBox15.Text = (string)ds.Tables[0].Rows[0][6].ToString().Trim();
                    dateTimePicker2.Text = (string)ds.Tables[0].Rows[0][7].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的货物编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "update cargo set Name='" + textBox12.Text +"',RepoID='"+textBox13.Text +"',StartTime='" + dateTimePicker1.Text + "',Factory='" + textBox14.Text + "',BuyerID='" + textBox16.Text + "',Price=" + textBox15.Text + ",InTime='" + dateTimePicker2.Text + "' where CargoID='" + textBox11.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("信息修改成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 修改货物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = false;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from cargo where CargoID='" + textBox17.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sqlStr1 = "delete from cargo where CargoID='" + textBox17.Text.Trim() + "'";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("输入的客户编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 删除货物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = false;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from cargo";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(sqlStr, conn);
                adapter.Fill(ds, "table");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "table";
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 查询货物信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = false;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox24.Text = "";
            textBox26.Text = "";
            textBox27.Text = "";
            textBox28.Text = "";
            textBox29.Text = "";
            dateTimePicker5.Value = DateTime.Now;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into intable values ('" + textBox24.Text + "','" + textBox26.Text + "','" + dateTimePicker5.Text + "'," + textBox27.Text + ",'" + textBox28.Text + "','" + textBox29.Text + "')";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("商品入库成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("请检查输入的数值是否正确！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 入库操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = false;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void 入库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            panel11.Visible = false;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from intable";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(sqlStr, conn);
                adapter.Fill(ds, "table");
                dataGridView3.DataSource = ds;
                dataGridView3.DataMember = "table";
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 出入操作ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            panel11.Visible = true;
            panel12.Visible = false;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox30.Text = "";
            textBox31.Text = "";
            textBox32.Text = "";
            textBox33.Text = "";
            textBox34.Text = "";
            dateTimePicker6.Value = DateTime.Now;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "insert into outtable values ('" + textBox30.Text + "','" + textBox31.Text + "','" + dateTimePicker6.Text + "'," + textBox32.Text + ",'" + textBox33.Text + "','" + textBox34.Text + "')";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                cmd.ExecuteNonQuery();
                MessageBox.Show("商品出库成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("请检查输入的数值是否正确！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from outtable";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(sqlStr, conn);
                adapter.Fill(ds, "table");
                dataGridView4.DataSource = ds;
                dataGridView4.DataMember = "table";
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                conn.Close();
            }
        }

        private void 出库信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
            panel13.Visible = false;
            panel14.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from repo where RepoID='" + textBox35.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox36.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    textBox37.Text = (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox38.Text = (string)ds.Tables[0].Rows[0][2].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的仓库编号有误！");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox35.Text = "";
            textBox36.Text = "";
            textBox37.Text = "";
            textBox38.Text = "";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Employee ep = new Employee();
            this.Hide();
            ep.Show();
        }

        private void 仓库信息管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
            panel14.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from repo where RepoID='" + textBox35.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    try
                    {
                        string sqlStr1 = "update repo set RepoName='" + textBox36.Text +"',RepoAddress='" + textBox38.Text + "',RepoSize ="+textBox37.Text;
                        conn = new OracleConnection(ConnectionString);
                        conn.Open();
                        cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sqlStr1;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("该仓库信息修改成功！");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("输入的数据有误!");
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                    
                }
                else
                {
                    try
                    {
                        string sqlStr2 = "insert into repo values ('" + textBox35.Text + "','" + textBox36.Text + "','" + textBox38.Text + "'," + textBox37.Text + ")";
                        conn = new OracleConnection(ConnectionString);
                        conn.Open();
                        cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandText = sqlStr2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("仓库信息添加成功！");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("请检查输入的数值是否正确！");
                    }
                    finally
                    {
                        cmd.Dispose();
                        conn.Close();
                    }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 仓库信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;
            panel10.Visible = true;
            panel11.Visible = true;
            panel12.Visible = true;
            panel13.Visible = true;
            panel14.Visible = true;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from repo";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(sqlStr, conn);
                adapter.Fill(ds, "table");
                dataGridView5.DataSource = ds;
                dataGridView5.DataMember = "table";
            }
            catch (Exception)
            {
                MessageBox.Show("系统繁忙！");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
