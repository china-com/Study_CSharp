using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestNine_1
{
    public partial class WelParam : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "欢迎" + Request.QueryString["name"];
            Label2.Text = "你的年龄为：" + Request.QueryString["age"] + "岁";
        }
    }
}