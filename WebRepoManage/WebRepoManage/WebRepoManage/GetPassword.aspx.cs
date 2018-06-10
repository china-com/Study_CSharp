using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebRepoManage
{
    public partial class GetPassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text.Trim()!=""||TextBox2.Text.Trim()!=""||TextBox3.Text.Trim()!="")
            {
                Response.Write("<script>javascript:alert('您的找回密码材料已提交，请耐心等待！');history.back();</script>");
            }
            else
            {
                Response.Write("<script>javascript:alert('请填写好资料后再点提交！！！');history.back();</script>");
            }
        }
    }
}