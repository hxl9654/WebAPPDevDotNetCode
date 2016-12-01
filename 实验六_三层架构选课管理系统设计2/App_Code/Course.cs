using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Course
{
    int courseNO;
    string courseName;
    int courseCredit;
    public int CourseNO
    {
        get
        {
            return courseNO;
        }
        set
        {
            courseNO = value;
        }
    }
    public string CourseName
    {
        get
        {
            return courseName;
        }
        set
        {
            courseName = value;
        }
    }
    public int CourseCredit
    {
        get
        {
            return courseCredit;
        }
        set
        {
            courseCredit = value;
        }
    }
}