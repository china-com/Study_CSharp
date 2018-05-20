using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestNine_3
{
    public partial class Default1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Label1.Text = Session["name"].ToString();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Application["talk"] = TextBox1.Text;
            Label2.Text = Application["content"] .ToString()+ "<br/>" + Label1.Text + "说:" + TextBox1.Text;
            Application["content"] = Label2.Text;
        }
    }
}