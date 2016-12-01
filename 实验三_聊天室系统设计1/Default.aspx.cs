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
        string name = TextBoxUserName.Text;
        string pass = TextBoxPassword.Text;
        if ((name.Equals("user1") && pass.Equals("pass1")) || (name.Equals("user2") && pass.Equals("pass2")))
        {
            Session["name"] = name;
            Session["pass"] = pass;
            Response.Redirect("main.aspx");
        }
        else
        {
            LabelMessage.Text = "密码错误，请重新输入";
        }
    }
}