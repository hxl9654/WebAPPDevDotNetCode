﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="185px" AutoGenerateDeleteButton="True" AutoGenerateEditButton="True" AutoGenerateInsertButton="True" AutoGenerateRows="False" DataKeyNames="图书编号" DataSourceID="SqlDataSource1" Style="margin-top: 15px" AllowPaging="True">
                <Fields>
                    <asp:BoundField DataField="图书编号" HeaderText="图书编号" ReadOnly="True" SortExpression="图书编号" />
                    <asp:BoundField DataField="图书名称" HeaderText="图书名称" SortExpression="图书名称" />
                    <asp:BoundField DataField="图书类别" HeaderText="图书类别" SortExpression="图书类别" />
                    <asp:BoundField DataField="出版社编号" HeaderText="出版社编号" SortExpression="出版社编号" />
                    <asp:BoundField DataField="图书照片" HeaderText="图书照片" SortExpression="图书照片" />
                </Fields>
            </asp:DetailsView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebAppDevClassConnectionString %>" SelectCommand="SELECT Id AS 图书编号, name AS 图书名称, class AS 图书类别, PressID AS 出版社编号, photo AS 图书照片 FROM Book" DeleteCommand="DELETE FROM Book WHERE (Id = @图书编号)" InsertCommand="INSERT INTO Book(Id, name, class, PressID, photo) VALUES (@图书编号, @图书名称, @图书类别, @出版社编号, @图书照片)" UpdateCommand="UPDATE Book SET name = @图书名称, class = @图书类别, PressID = @出版社编号, photo = @图书照片">
                <DeleteParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书编号" PropertyName="SelectedValue" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书名称" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书类别" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="出版社编号" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书照片" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书编号" PropertyName="SelectedValue" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书名称" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书类别" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="出版社编号" PropertyName="SelectedValue" />
                    <asp:ControlParameter ControlID="DetailsView1" Name="图书照片" PropertyName="SelectedValue" />
                </UpdateParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
