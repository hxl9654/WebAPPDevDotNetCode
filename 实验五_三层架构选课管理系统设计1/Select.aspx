<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Select.aspx.cs" Inherits="Select" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>选课页面</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <div>
            学生列表：<asp:DropDownList ID="DropDownListStudent" runat="server"></asp:DropDownList>
        </div>
        <div>
            课程列表：<asp:DropDownList ID="DropDownListCourse" runat="server"></asp:DropDownList>
        </div>
        <div>
            <asp:Button ID="ButtonAdd" runat="server" Text="添加" OnClick="ButtonAdd_Click" />
            <asp:Button ID="ButtonRefresh" runat="server" Text="刷新" OnClick="ButtonRefresh_Click" />
        </div>
        <div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowDeleting="GridView1_RowDeleting">
                        <Columns>
                            <asp:BoundField DataField="StudentNO" HeaderText="学号" />
                            <asp:BoundField DataField="StudentName" HeaderText="姓名" />
                            <asp:BoundField DataField="CourseNO" HeaderText="课程号" />
                            <asp:BoundField DataField="CourseName" HeaderText="课程名" />
                            <asp:BoundField DataField="CourseCredit" HeaderText="学分" />
                            <asp:ButtonField ButtonType="Button" CommandName="Delete" HeaderText="删除" ShowHeader="True" Text="删除" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
