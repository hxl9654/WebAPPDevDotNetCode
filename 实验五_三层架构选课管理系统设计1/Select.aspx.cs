using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Select : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            DropDownListCourse.DataTextField = "CourseName";
            DropDownListCourse.DataValueField = "CourseNO";
            DropDownListStudent.DataTextField = "StudentName";
            DropDownListStudent.DataValueField = "StudentNO";

            string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
            SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
            DataSet ds1 = new DataSet();
            DataSet ds2 = new DataSet();
            DataSet ds3 = new DataSet();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Student", SQLConnection);
            SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Course", SQLConnection);
            SqlDataAdapter sda3 = new SqlDataAdapter("SELECT   Student_Course.StudentNO, Student_Course.CourseNO, Course.CourseName, Student.StudentName, Course.CourseCredit FROM Student_Course INNER JOIN Student ON Student_Course.StudentNO = Student.StudentNO INNER JOIN Course ON Student_Course.CourseNO = Course.CourseNO", SQLConnection);

            SQLConnection.Open();
            sda1.Fill(ds1);
            sda2.Fill(ds2);
            sda3.Fill(ds3);
            SQLConnection.Close();
            DropDownListStudent.DataSource = ds1;
            DropDownListStudent.DataBind();
            DropDownListCourse.DataSource = ds2;
            DropDownListCourse.DataBind();
            GridView1.DataSource = ds3;
            GridView1.DataBind();
        }
    }

    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [dbo].[Student_Course] ([CourseNO], [StudentNO]) VALUES (@CourseNO, @StudentNO)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", Int32.Parse(DropDownListCourse.SelectedValue)));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", Int32.Parse(DropDownListStudent.SelectedValue)));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "DELETE [dbo].[Student_Course] where [CourseNO] = @CourseNO and [StudentNO] = @StudentNO";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", Int32.Parse(GridView1.Rows[e.RowIndex].Cells[2].Text)));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", Int32.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text)));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }

    protected void ButtonRefresh_Click(object sender, EventArgs e)
    {
        Response.Redirect("select.aspx");
    }
}