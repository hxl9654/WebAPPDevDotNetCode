using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBoxAll.Text = "" + Application["AllMessages"];
    }

    protected void ButtonSend_Click(object sender, EventArgs e)
    {
        Application["AllMessages"] += ("\n" + Session["name"] + "说" + TextBoxSend.Text);
        TextBoxAll.Text = "" + Application["AllMessages"];
        TextBoxSend.Text = "";
    }
}