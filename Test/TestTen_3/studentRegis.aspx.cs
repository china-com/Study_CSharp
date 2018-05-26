using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace TestTen_3
{
    public partial class studentRegis : System.Web.UI.Page
    {
        string conntxt = "server=localhost;User Id=root;password=admin;Database=studydemo";
        MySqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sqlstr =String.Format("insert into tenstudent(username,password) values ('{0}','{1}')",TextBox1.Text.Trim().ToString(),TextBox2.Text.Trim().ToString());
            try
            {
                conn = new MySqlConnection(conntxt);
                conn.Open();
                MySqlCommand comm = new MySqlCommand();
                comm.Connection = conn;
                comm.CommandText = sqlstr;
                comm.ExecuteNonQuery();
                Response.Write("<script>alert('注册成功！')</script>");
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}