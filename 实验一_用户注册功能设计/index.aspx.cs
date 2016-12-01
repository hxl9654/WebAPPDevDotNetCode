using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["UserName"] != null && Session["UserName"].Equals("admin"))
        {
            Label1.Text = "当前登录的用户是：" + Session["UserName"];
        }
        else Response.Redirect("login.aspx");
    }

    protected void ButtonRefreshStatu_Click(object sender, EventArgs e)
    {
        if (Session["UserName"] != null && Session["UserName"].Equals("admin"))
        {
            Label1.Text = "当前登录的用户是：" + Session["UserName"];
        }
        else Label1.Text = "当前登录的用户已超时";
    }
}