<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddCourse.aspx.cs" Inherits="AddCourse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>课程信息内容</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            课程编号：<asp:TextBox ID="TextBoxNO" runat="server" MaxLength="20" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            课程名称：<asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
        </div>
        <div>
            课程学分：<asp:TextBox ID="TextBoxCredit" runat="server" MaxLength="2" TextMode="Number"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonAdd" runat="server" Text="添加课程" OnClick="ButtonAdd_Click" />
        </div>
    </form>
</body>
</html>
