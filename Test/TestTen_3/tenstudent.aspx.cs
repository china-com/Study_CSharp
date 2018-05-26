using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace TestTen_3
{
    public partial class tenstudent : System.Web.UI.Page
    {
        string conntxt = "server=localhost;User Id=root;password=admin;Database=studydemo";
        MySqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["username"].ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlstr = "update tenstudent set password='"+TextBox1.Text.Trim().ToString()+"'"+" where username='" + Session["username"].ToString()+"'";
            try
            {
                if (TextBox1.Text.Trim().ToString().Equals(TextBox2.Text.Trim().ToString()))
                {
                    conn = new MySqlConnection(conntxt);
                    conn.Open();
                    MySqlCommand comm = new MySqlCommand();
                    comm.Connection = conn;
                    comm.CommandText = sqlstr;
                    comm.ExecuteNonQuery();
                    Response.Write("<script>alert('密码修改成功！下次记得使用新密码登录。')</script>");
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}