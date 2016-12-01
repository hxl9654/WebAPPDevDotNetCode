using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class Student
{
    int studentNO;
    string studentName;
    string studentSex;
    int studentAge;
    string studentFaculty;
    string studentProvience;
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
    public string StudentSex
    {
        get
        {
            return studentSex;
        }
        set
        {
            studentSex = value;
        }
    }
    public int StudentAge
    {
        get
        {
            return studentAge;
        }
        set
        {
            studentAge = value;
        }
    }
    public string StudentFaculty
    {
        get
        {
            return studentFaculty;
        }
        set
        {
            studentFaculty = value;
        }
    }
    public string StudentProvience
    {
        get
        {
            return studentProvience;
        }
        set
        {
            studentProvience = value;
        }
    }
}