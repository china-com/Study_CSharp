using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;

namespace TestTen_3
{
    public partial class Default : System.Web.UI.Page
    {
        string conntxt = "server=localhost;User Id=root;password=admin;Database=studydemo";
        MySqlConnection conn=null;
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string username = TextBox1.Text.Trim().ToString();
                string password = TextBox2.Text.Trim().ToString();
                string item = "tenStudent";
                if (DropDownList1.SelectedValue == "学生")
                {
                    item = "tenStudent";
                }
                else if (DropDownList1.SelectedValue == "教师")
                {
                    item = "tenTeacher";
                }
                else if (DropDownList1.SelectedValue == "管理员")
                {
                    item = "tenAdmin";
                }
                conn= new MySqlConnection(conntxt);
                conn.Open();
                string sqlstr = "select * from " + item +" where username='"+username+"' && password='"+password+"'";
                //MySqlDataAdapter oda = new MySqlDataAdapter(sqlstr, conn);
                /*方式一：利用DataAdapter和DataSet对象
                DataSet ds = new DataSet();
                
                oda.Fill(ds);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Label5.Text = "用户名或密码错误，请重试！";
                }
                */
                /*方式二：利用DataAdapter和DataTable对象
                DataTable dt = new DataTable();
                oda.Fill(dt);
                if (dt.Rows.Count==0)
                {
                    Label5.Text = "用户名或密码错误，请重试！";
                }
                */
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sqlstr;
                MySqlDataReader reader =cmd.ExecuteReader();
                if (!reader.Read())
                {
                    Label5.Text = "用户名或密码错误，请重试！";
                }
                else
                {
                    if (DropDownList1.SelectedValue == "管理员")
                    {
                        Session["username"] = "admin";
                    }
                    else
                    {
                        Session["username"] = TextBox1.Text;
                    }
                    Response.Redirect(item+".aspx");
                }
            }
            catch (Exception ex)
            {

                throw ;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentRegis.aspx");
        }
    }
}