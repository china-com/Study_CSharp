using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestNine_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Timeout = 1;
            if (Session["Number"]!=null)
            {
                Session["Number"] = (int)Session["Number"] + 1;
            }
            else
            {
                Session["Number"] = 1;
            }
            string s = Session["Number"].ToString();
            Label1.Text = "你是第" + s + "访问该页面！";
        }
    }
}