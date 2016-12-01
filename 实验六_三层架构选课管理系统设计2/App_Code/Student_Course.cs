using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Student_Course
{
    int id;
    int studentNO;
    string studentName;
    int courseNO;
    string courseName;
    int courseCredit;
    public int StudentNO
    {
        get
        {
            return studentNO;
        }
        set
        {
            studentNO = value;
        }
    }
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
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
    public string StudentName
    {
        get
        {
            return studentName;
        }
        set
        {
            studentName = value;
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