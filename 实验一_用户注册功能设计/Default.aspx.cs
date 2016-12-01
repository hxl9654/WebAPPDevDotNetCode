using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if(TextBoxUserName.Text.Equals("admin")&&TextBoxPassword.Text.Equals("12345"))
        {
            Session.Timeout = 1;
            Session["UserName"] = "admin";
        }
        Response.Redirect("index.aspx");
    }

    protected void ButtonClear_Click(object sender, EventArgs e)
    {
        TextBoxUserName.Text = "";
        TextBoxPassword.Text = "";
    }
}