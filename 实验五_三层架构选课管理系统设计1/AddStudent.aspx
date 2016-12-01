<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddStudent.aspx.cs" Inherits="AddStudent" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>学生信息录入</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            学号：<asp:TextBox ID="TextBoxStudentNO" runat="server" MaxLength="20" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            姓名：<asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div>
            性别：<asp:RadioButton ID="RadioButtonSexMale" runat="server" Text="男"  Checked="True" GroupName="RadioButtonSex" />
            <asp:RadioButton ID="RadioButtonSexFemale" runat="server" Text="女"  GroupName="RadioButtonSex"/>
        </div>
        <div>
            年龄：<asp:TextBox ID="TextBoxAge" runat="server" MaxLength="3" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            学院：<asp:DropDownList ID="DropDownListFaculty" runat="server">
                <asp:ListItem>计算机学院</asp:ListItem>
                <asp:ListItem>电子学院</asp:ListItem>
                <asp:ListItem>软件学院</asp:ListItem>
                <asp:ListItem>艺术学院</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            省份：<asp:DropDownList ID="DropDownListProvience" runat="server">
                <asp:ListItem>四川省</asp:ListItem>
                <asp:ListItem>北京市</asp:ListItem>
                <asp:ListItem>河北省</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="ButtonAdd" runat="server" Text="添加学生" OnClick="ButtonAdd_Click" />
        </div>
    </form>
</body>
</html>
