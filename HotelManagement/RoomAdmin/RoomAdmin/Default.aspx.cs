using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RoomAdmin
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim().ToString()==""||TextBox2.Text.Trim().ToString()=="")
            {
                Response.Write("<script>javascript:alert('用户名或密码不能为空！');history.back();</script>");
                //Response.End;
            }
            string sqlstr;
            if (RadioButton1.Checked)
            {
                sqlstr = "select * from adminuser where username='" + TextBox1.Text.Trim().ToString() + "'&& password='" + TextBox2.Text.Trim().ToString() + "'";
            }
            else
            {
                sqlstr= "select * from empuser where username='" + TextBox1.Text.Trim().ToString() + "'&& password='" + TextBox2.Text.Trim().ToString() + "'";
            }
        }
    }
}