using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace WebRepoManage
{
    public partial class Default : System.Web.UI.Page
    {
        string ConnectionString = "User ID=chj;Password=123456;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
        OracleConnection conn = null;
        OracleCommand cmd = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text.ToString().Trim();
            string password = TextBox2.Text.ToString().Trim();
            if (TextBox1.Text.Trim().ToString() == "" || TextBox2.Text.Trim().ToString() == "")
            {
                Response.Write("<script>javascript:alert('用户名或密码不能为空！');history.back();</script>");
                //Response.End;
            }
            //string sqlstr = "select * from adminuser where UserName='root' and Password='admin'";
            string tablename = "adminuser";
            Session["role"] = "管理员";
            if (RadioButton2.Checked)
            {
                tablename = "empuser";
                Session["role"] = "员工";
            }
            Session["UserName"] = TextBox1.Text;
            string sqlstr = "select * from "+tablename+" where UserName='" + username + "' and Password='" + password + "'";
            try
            { 
                //sqlstr= "select * from adminuser where UserName ='root' ";
                conn = new OracleConnection(ConnectionString);
                conn.Open();
                //cmd = new OracleCommand(sqlstr,conn);
                //cmd.Parameters.Add("username")
                //cmd.Connection = conn;
                //cmd.CommandText = sqlstr;
                //cmd.Parameters.Add("UserName", TextBox1.Text.Trim());
                //cmd.Parameters.Add("Password", TextBox2.Text.Trim());
                //Response.Write("<script>javascript:alert('shabi');history.back();</script>");
                //OracleDataReader reader = cmd.ExecuteReader();
                OracleDataAdapter oda = new OracleDataAdapter(sqlstr, conn);
                DataSet ds = new DataSet();
                oda.Fill(ds);
                if (ds.Tables[0].Rows.Count==0)
                {
                    Response.Write("<script>javascript:alert('用户名或密码错误，请重试！');history.back();</script>");
                }
                else
                {
                    Response.Redirect("ChangePassword.aspx");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>javascript:alert('系统繁忙！');history.back();</script>");
            }
            finally
            {
                conn.Close();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
            RadioButton1.Checked=true;
            RadioButton2.Checked = false;
        }
    }
}