using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class CourseBLL
{
    public void AddCourse(Course course)
    {
        CourseDAL dal = new CourseDAL();
        dal.AddCourse(course);
    }
    public List<Course> GetCourseList()
    {
        CourseDAL dal = new CourseDAL();
        return dal.GetCourseList();
    }
}