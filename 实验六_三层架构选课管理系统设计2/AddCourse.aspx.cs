using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddCourse : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Course course = new Course();
        course.CourseNO = Int32.Parse(TextBoxNO.Text);
        course.CourseName = TextBoxName.Text;
        course.CourseCredit = Int32.Parse(TextBoxCredit.Text);
        CourseBLL bll = new CourseBLL();
        bll.AddCourse(course);
    }
}