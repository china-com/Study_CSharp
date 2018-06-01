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
    public partial class ChangePassword : System.Web.UI.Page
    {
        string ConnectionString = "User ID=chj;Password=123456;Data Source=(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = orcl)))";
        OracleConnection conn = null;
        OracleCommand cmd = null;

    protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "欢迎您！" +Session["role"].ToString()+"账户："+ Session["UserName"].ToString()+"   。";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text==TextBox2.Text)
            {
                try
                {
                    string tablename="adminuser";
                    if (Session["role"].ToString()=="员工")
                    {
                        tablename = "empuser";
                    }
                    string sqlStr = "update "+tablename+" set Password='" + TextBox1.Text.Trim()+"' where UserName='" +Session["UserName"].ToString()+ "'";
                    conn = new OracleConnection(ConnectionString);
                    conn.Open();
                    cmd = new OracleCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = sqlStr;
                    cmd.ExecuteNonQuery();
                    Response.Write("<script>javascript:alert('密码修改完成！下次请使用新密码登录。');history.back();</script>");
                }
                catch (Exception)
                {
                    Response.Write("<script>javascript:alert('系统繁忙！');history.back();</script>");
                }
                finally
                {
                    cmd.Dispose();
                    conn.Close();
                }
            }
            else
            {
                Response.Write("<script>javascript:alert('两次密码不一致！');history.back();</script>");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox1.Focus();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}