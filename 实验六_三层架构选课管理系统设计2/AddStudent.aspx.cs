using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddStudent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        Student student = new Student();
        student.StudentNO = Int32.Parse(TextBoxStudentNO.Text);
        student.StudentName = TextBoxName.Text;
        student.StudentAge = Int32.Parse(TextBoxAge.Text);
        student.StudentSex = (RadioButtonSexMale.Checked ? "男" : "女");
        student.StudentFaculty = DropDownListFaculty.SelectedValue;
        student.StudentProvience = DropDownListProvience.SelectedValue;
        StudentBLL bll = new StudentBLL();
        bll.AddStudent(student);
    }
}