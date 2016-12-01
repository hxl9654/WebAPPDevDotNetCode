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
        if (Request.Cookies["UserName"] != null && Request.Cookies["Password"] != null)
        {
            TextBoxUserName.Text = Request.Cookies["UserName"].Value;
            TextBoxPassword.Text = Request.Cookies["Password"].Value;
        }
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        if(CheckBoxRememberPassword.Checked)
        {
            Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(1);
            Response.Cookies["UserName"].Value = TextBoxUserName.Text;
            Response.Cookies["Password"].Value = TextBoxPassword.Text;
        }
        Response.Redirect("login.aspx");
    }

    protected void ButtonForgetRememberedPassword_Click(object sender, EventArgs e)
    {
        Response.Cookies["UserName"].Expires = DateTime.Now.AddMinutes(-1);
        Response.Cookies["Password"].Expires = DateTime.Now.AddMinutes(-1);
        TextBoxUserName.Text = "";
        TextBoxPassword.Text = "";
    }
}