using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [Student] ([StudentNO], [StudentName], [StudentSex], [StudentAge], [StudentFaculty], [StudentProvince]) VALUES (@StudentNO, @StudentName, @StudentSex, @StudentAge, @StudentFaculty, @StudentProvince)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", Int32.Parse(TextBoxStudentNO.Text)));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentName", TextBoxName.Text));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentSex", (RadioButtonSexMale.Checked ? "男" : "女")));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentAge", Int32.Parse(TextBoxAge.Text)));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentFaculty", DropDownListFaculty.Text));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentProvince", DropDownListProvience.Text));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
}