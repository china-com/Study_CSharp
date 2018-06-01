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
    public partial class Admin : Form
    {
        string ConnectionString = "User ID=chj;Password=123456;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        public Admin()
        {
            InitializeComponent();
        }

        private void 添加管理员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
        }

        private void 修改管理员信息ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 修改管理员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost:3601/Default.aspx");
            //this.panel1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string sqlStr = "select * from empuser where UserName='" + textBox1.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                //cmd.CommandText = sqlStr;
                //OracleDataReader reader = cmd.ExecuteReader();
                if (textBox2.Text.Trim() == textBox3.Text.Trim())
                {
                    string sqlStr1 = "insert into empuser values ('" + textBox1.Text + "','" + textBox2.Text + "')";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("员工增加成功！");
                }
                else
                {
                    MessageBox.Show("两次密码不一致！");
                }
                //MessageBox.Show("服务器繁忙，请稍后再试！");
            }
            catch (Exception)
            {
                MessageBox.Show("该员工用户已存在！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void 取消登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 注销登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.Show();
        }

        private void 删除管理员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true ;
            this.panel2.Visible = true;
            this.panel3.Visible = false;
            this.panel4.Visible = false;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
        }

        private void 添加采购员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = false;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
            //this.panel2.BringToFront();
            //panel1.Location = panel2.Location;
            //label7.Text = "添加采购员账户";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from empuser where UserName='" + textBox4.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sqlStr1 = "delete from empuser where username='" + textBox4.Text.Trim() + "'";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("输入的用户名有误！");
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

        private void button7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                string gender = "男";
                if (radioButton2.Checked==true)
                {
                    gender = radioButton2.Text;
                }
                string sqlStr1 = "insert into buyer values ('" + textBox5.Text + "','" + textBox6.Text + "','" + gender + "','" + textBox7.Text + "','" + textBox8.Text + "')";
                cmd.CommandText = sqlStr1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("采购员增加成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("该采购员已存在！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from buyer where BuyerID='" + textBox9.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sqlStr1 = "delete from buyer where BuyerID='" + textBox9.Text.Trim() + "'";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("输入的采购员ID有误！");
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

        private void 删除采购员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.panel5.Visible = false;
            this.panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            /*
            string name = null;
            string gender = null;
            string phone = null;
            string address = null;
            */
            try
            {
                string sqlStr = "select * from buyer where BuyerID='" + textBox10.Text.Trim() + "'";
                DataSet ds = new DataSet();
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataAdapter adapter = new OracleDataAdapter();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                /*if (dt.Rows.Count>0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        name = dr["Name"].ToString();
                        gender = dr["Gender"].ToString();
                        phone = dr["Phone"].ToString();
                        address = dr["Address"].ToString();
                    }
                }*/
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    textBox11.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    if ((string)ds.Tables[0].Rows[0][2].ToString().Trim()==radioButton4.Text)
                    {
                        radioButton4.Checked=true;
                        radioButton3.Checked = false;
                    }
                    else
                    {
                        radioButton3.Checked = true;
                        radioButton4.Checked = false;
                    }
                    textBox12.Text = (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox13.Text = (string)ds.Tables[0].Rows[0][4].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的采购员ID有误！");
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

        private void 修改采购员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.panel5.Visible = true;
            this.panel6.Visible = false;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "男";
                if (radioButton3.Checked==true)
                {
                    gender = radioButton3.Text;
                }
                string sqlStr = "update buyer set Name='"+textBox11.Text+"',Gender='"+gender+"',Phone='"+textBox12.Text+"',Address='"+textBox13.Text+"'"+" where BuyerID='" + textBox10.Text.Trim() + "'";
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

        private void 添加提货员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.panel5.Visible = true;
            this.panel6.Visible = true;
            this.panel7.Visible = false;
            this.panel8.Visible = false;
            //label7.Text = "添加提货员账户";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
            textBox17.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                string gender = "男";
                if (radioButton5.Checked == true)
                {
                    gender = radioButton5.Text;
                }
                string sqlStr1 = "insert into picker values ('" + textBox14.Text + "','" + textBox15.Text + "','" + gender + "','" + textBox16.Text + "','" + textBox17.Text + "')";
                cmd.CommandText = sqlStr1;
                cmd.ExecuteNonQuery();
                MessageBox.Show("提货员增加成功！");
            }
            catch (Exception)
            {
                MessageBox.Show("该提货员已存在！");
            }
            finally
            {
                cmd.Dispose();
                conn.Close();
            }
        }

        private void 删除提货员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.panel5.Visible = true;
            this.panel6.Visible = true;
            this.panel7.Visible = true;
            this.panel8.Visible = false;
        }

        private void 修改提货员信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = true;
            this.panel2.Visible = true;
            this.panel3.Visible = true;
            this.panel4.Visible = true;
            this.panel5.Visible = true;
            this.panel6.Visible = true;
            this.panel7.Visible = true;
            this.panel8.Visible = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from picker where PickerID='" + textBox18.Text.Trim() + "'";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlStr;
                OracleDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string sqlStr1 = "delete from picker where PickerID='" + textBox18.Text.Trim() + "'";
                    cmd.CommandText = sqlStr1;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("删除成功！");
                }
                else
                {
                    MessageBox.Show("输入的提货员ID有误！");
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

        private void button20_Click(object sender, EventArgs e)
        {
            textBox19.Text = "";
            textBox20.Text = "";
            textBox21.Text = "";
            textBox22.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from picker where PickerID='" + textBox19.Text.Trim() + "'";
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
                    textBox20.Text = (string)ds.Tables[0].Rows[0][1].ToString().Trim();
                    if ((string)ds.Tables[0].Rows[0][2].ToString().Trim() == radioButton7.Text)
                    {
                        radioButton7.Checked = true;
                        radioButton8.Checked = false;
                    }
                    else
                    {
                        radioButton8.Checked = true;
                        radioButton7.Checked = false;
                    }
                    textBox21.Text = (string)ds.Tables[0].Rows[0][3].ToString().Trim();
                    textBox22.Text = (string)ds.Tables[0].Rows[0][4].ToString().Trim();
                }
                else
                {
                    MessageBox.Show("输入的采购员ID有误！");
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

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                string gender = "男";
                if (radioButton7.Checked == true)
                {
                    gender = radioButton7.Text;
                }
                string sqlStr = "update picker set Name='" + textBox20.Text + "',Gender='" + gender + "',Phone='" + textBox21.Text + "',Address='" + textBox22.Text + "'" + " where PickerID='" + textBox19.Text.Trim() + "'";
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
    }
}
