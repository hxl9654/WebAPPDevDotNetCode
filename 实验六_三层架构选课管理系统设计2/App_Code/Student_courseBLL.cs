using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Student_CourseBLL
{
    public void AddStudent_Course(Student_Course student_Course)
    {
        Student_CourseDAL dal = new Student_CourseDAL();
        dal.AddStudent_Course(student_Course);
    }
    public List<Student_Course> GetStudent_CourseList()
    {
        Student_CourseDAL dal = new Student_CourseDAL();
        return dal.GetStudent_CourseList();
    }
    public void DeleteStudent_Course(Student_Course student_Course)
    {
        Student_CourseDAL dal = new Student_CourseDAL();
        dal.DeleteStudent_course(student_Course);
    }
}