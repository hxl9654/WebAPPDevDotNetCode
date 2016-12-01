using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class Student_CourseDAL
{
    public void AddStudent_Course(Student_Course student_Course)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [dbo].[Student_Course] ([CourseNO], [StudentNO]) VALUES (@CourseNO, @StudentNO)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", student_Course.CourseNO));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", student_Course.StudentNO));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
    public List<Student_Course> GetStudent_CourseList()
    {
        List<Student_Course> Student_Course = new List<Student_Course>();
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        DataSet ds3 = new DataSet();
        SqlDataAdapter sda3 = new SqlDataAdapter("SELECT   Student_Course.StudentNO, Student_Course.CourseNO, Course.CourseName, Student.StudentName, Course.CourseCredit FROM Student_Course INNER JOIN Student ON Student_Course.StudentNO = Student.StudentNO INNER JOIN Course ON Student_Course.CourseNO = Course.CourseNO", SQLConnection);

        SQLConnection.Open();
        sda3.Fill(ds3);
        SQLConnection.Close();
        for (int i = 0; i < ds3.Tables[0].Rows.Count; i++)
        {
            Student_Course student_Course = new Student_Course();
            student_Course.CourseNO = Int32.Parse(ds3.Tables[0].Rows[i]["CourseNO"].ToString());
            student_Course.StudentNO = Int32.Parse(ds3.Tables[0].Rows[i]["StudentNO"].ToString());
            student_Course.StudentName = ds3.Tables[0].Rows[i]["StudentName"].ToString();
            student_Course.CourseName = ds3.Tables[0].Rows[i]["CourseName"].ToString();
            student_Course.CourseCredit = Int32.Parse(ds3.Tables[0].Rows[i]["CourseCredit"].ToString());
            Student_Course.Add(student_Course);
        }
        return Student_Course;
    }
    public void DeleteStudent_course(Student_Course student_Course)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "DELETE [dbo].[Student_Course] where [CourseNO] = @CourseNO and [StudentNO] = @StudentNO";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@CourseNO", student_Course.CourseNO));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", student_Course.StudentNO));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
}