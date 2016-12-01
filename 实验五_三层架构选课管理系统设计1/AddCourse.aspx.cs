using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [dbo].[Course] ([CourseNO], [CourseName], [CourseCredit]) VALUES (@CourseNO, @CourseName, @CourseCredit)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", Int32.Parse(TextBoxNO.Text)));
        SQLCommand.Parameters.Add(new SqlParameter("@CourseName", TextBoxName.Text));
        SQLCommand.Parameters.Add(new SqlParameter("@CourseCredit", Int32.Parse(TextBoxCredit.Text)));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
}