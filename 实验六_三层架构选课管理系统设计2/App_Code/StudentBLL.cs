using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class StudentBLL
{
    public void AddStudent(Student student)
    {
        StudentDAL dal = new StudentDAL();
        dal.AddStudent(student);
    }
    public List<Student> GetStudentList()
    {
        StudentDAL dal = new StudentDAL();
        return dal.GetStudentList();
    }
}