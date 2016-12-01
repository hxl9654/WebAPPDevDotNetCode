using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Select : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownListCourse.DataTextField = "CourseName";
            DropDownListCourse.DataValueField = "CourseNO";
            DropDownListStudent.DataTextField = "StudentName";
            DropDownListStudent.DataValueField = "StudentNO";
            DropDownListStudent.DataSource = (new StudentBLL()).GetStudentList();
            DropDownListCourse.DataSource = (new CourseBLL()).GetCourseList();
            GridView1.DataSource = (new Student_CourseBLL()).GetStudent_CourseList();
            DropDownListStudent.DataBind();
            DropDownListCourse.DataBind();
            GridView1.DataBind();
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Student_Course student_Course = new Student_Course();
        student_Course.CourseNO = Int32.Parse(DropDownListCourse.SelectedValue);
        student_Course.StudentNO = Int32.Parse(DropDownListStudent.SelectedValue);
        Student_CourseBLL bll = new Student_CourseBLL();
        bll.AddStudent_Course(student_Course);
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        Student_Course student_Course = new Student_Course();
        Student_CourseBLL bll = new Student_CourseBLL();
        student_Course.CourseNO = Int32.Parse(GridView1.Rows[e.RowIndex].Cells[2].Text);
        student_Course.StudentNO = Int32.Parse(GridView1.Rows[e.RowIndex].Cells[0].Text);
        bll.DeleteStudent_Course(student_Course);
    }

    protected void ButtonRefresh_Click(object sender, EventArgs e)
    {
        Response.Redirect("select.aspx");
    }
}