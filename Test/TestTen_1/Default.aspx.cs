using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace TestTen_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string ConnectionString = "server=localhost;User Id=root;password=admin;Database=studydemo";
            using (MySqlConnection conn=new MySqlConnection(ConnectionString))
            {
                conn.Open();
                using (MySqlCommand comm = conn.CreateCommand())
                {
                    comm.CommandText = "select * from teachingmanage";
                    MySqlDataReader reader = comm.ExecuteReader();
                    Response.Write("<Table border=1>");
                    Response.Write("<Table border=1>");
                    Response.Write("<tr><th>代码</th><th>课程名称</th><th>系代码</th>");
                    while (reader.Read())
                    {
                        Response.Write("<tr>");
                        Response.Write("<td>" + reader["ClassNumber"].ToString() + "</td>");
                        Response.Write("<td>" + reader["ClassName"].ToString() + "</td>");
                        Response.Write("<td>" + reader["DepartmentNumber"].ToString() + "</td>");
                        Response.Write("</tr>");
                    }
                    Response.Write("</table>");
                }
            }
        }
    }
}