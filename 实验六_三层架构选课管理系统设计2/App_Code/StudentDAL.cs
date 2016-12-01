using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class StudentDAL
{
    public void AddStudent(Student student)
    {
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        string SQLCommandText = "INSERT INTO [Student] ([StudentNO], [StudentName], [StudentSex], [StudentAge], [StudentFaculty], [StudentProvince]) VALUES (@StudentNO, @StudentName, @StudentSex, @StudentAge, @StudentFaculty, @StudentProvince)";
        SqlCommand SQLCommand = new SqlCommand(SQLCommandText, SQLConnection);
        SQLCommand.Parameters.Add(new SqlParameter("@StudentNO", student.StudentNO));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentName", student.StudentName));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentSex", student.StudentSex));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentAge", student.StudentAge));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentFaculty", student.StudentFaculty));
        SQLCommand.Parameters.Add(new SqlParameter("@StudentProvince", student.StudentProvience));
        SQLConnection.Open();
        SQLCommand.ExecuteNonQuery();
        SQLConnection.Close();
    }
    public List<Student> GetStudentList()
    {
        List<Student> StudentList = new List<Student>();
        string SQLServerConnectString = "Data Source=HXL-PC;Initial Catalog=WebAppDevClass;Integrated Security=True;Pooling=False";
        SqlConnection SQLConnection = new SqlConnection(SQLServerConnectString);
        DataSet ds1 = new DataSet();
        SqlDataAdapter sda1 = new SqlDataAdapter("SELECT * FROM Student", SQLConnection);

        SQLConnection.Open();
        sda1.Fill(ds1);
        SQLConnection.Close();
        for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
        {
            Student student = new Student();
            student.StudentNO = Int32.Parse(ds1.Tables[0].Rows[i]["StudentNO"].ToString());
            student.StudentName = ds1.Tables[0].Rows[i]["StudentName"].ToString();
            student.StudentSex = ds1.Tables[0].Rows[i]["StudentSex"].ToString();
            student.StudentAge = Int32.Parse(ds1.Tables[0].Rows[i]["StudentAge"].ToString());
            student.StudentFaculty = ds1.Tables[0].Rows[i]["StudentFaculty"].ToString();
            student.StudentProvience = ds1.Tables[0].Rows[i]["StudentProvince"].ToString();
            StudentList.Add(student);
        }
        return StudentList;
    }
}