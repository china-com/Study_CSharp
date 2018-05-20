using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestNine_4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HttpCookie cookie = Request.Cookies["Name"];
                if (cookie==null)
                {
                    Label1.Text = "欢迎，登录网站！";
                }
                else
                {
                    Label1.Text = "欢迎" +HttpUtility.UrlDecode(cookie.Values["Name"]) + "登录网站";
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["Name"];
            if (cookie==null)
            {
                cookie = new HttpCookie("Name");
            }
            cookie.Values["Name"] =HttpUtility.UrlEncode(this.TextBox1.Text.ToString());
            cookie.Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies.Add(cookie);
        }
    }
}