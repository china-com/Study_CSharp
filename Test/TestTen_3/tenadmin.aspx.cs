using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace TestTen_3
{
    public partial class tenadmin : System.Web.UI.Page
    {
        string ConnectionString = "server=localhost;User Id=root;password=admin;Database=studydemo";
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Session["username"].ToString();
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand comm = conn.CreateCommand())
                {
                    comm.CommandText = "select * from tenstudent";
                    MySqlDataReader reader = comm.ExecuteReader();
                    Response.Write("<Table border=1>");
                    Response.Write("<Table border=1>");
                    Response.Write("<tr><th>用户名</th>");
                    while (reader.Read())
                    {
                        Response.Write("<tr>");
                        Response.Write("<td>" + reader["username"].ToString() + "</td>");
                        Response.Write("</tr>");
                    }
                    Response.Write("</table>");
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();
            MySqlCommand comm=conn.CreateCommand();
            comm.CommandText = "delete from tenstudent where username='"+TextBox1.Text+"'";
            comm.ExecuteNonQuery();
            conn.Close();
        }
    }
}