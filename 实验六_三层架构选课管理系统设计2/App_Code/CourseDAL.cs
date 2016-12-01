using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class CourseDAL
{
    public void AddCourse(Course course)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [dbo].[Course] ([CourseNO], [CourseName], [CourseCredit]) VALUES (@CourseNO, @CourseName, @CourseCredit)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", course.CourseNO));
        SQLCommand.Parameters.Add(new SqlParameter("@CourseName", course.CourseName));
        SQLCommand.Parameters.Add(new SqlParameter("@CourseCredit", course.CourseCredit));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
    public List<Course> GetCourseList()
    {
        List<Course> ListCourse = new List<Course>();
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        DataSet ds2 = new DataSet();
        SqlDataAdapter sda2 = new SqlDataAdapter("SELECT * FROM Course", SQLConnection);

        SQLConnection.Open();
        sda2.Fill(ds2);
        SQLConnection.Close();
        for (int i = 0; i < ds2.Tables[0].Rows.Count; i++)
        {
            Course course = new Course();
            course.CourseNO = Int32.Parse(ds2.Tables[0].Rows[i]["CourseNO"].ToString());
            course.CourseName = ds2.Tables[0].Rows[i]["CourseName"].ToString();
            course.CourseCredit = Int32.Parse(ds2.Tables[0].Rows[i]["CourseCredit"].ToString());
            ListCourse.Add(course);
        }
        return ListCourse;
    }
}