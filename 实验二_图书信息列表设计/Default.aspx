<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="图书照片" HeaderText="图书照片" SortExpression="图书照片" />
                <asp:BoundField DataField="书名" HeaderText="书名" SortExpression="书名" />
                <asp:BoundField DataField="类别" HeaderText="类别" SortExpression="类别" />
                <asp:BoundField DataField="出版社" HeaderText="出版社" SortExpression="出版社" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebAppDevClassConnectionString %>" SelectCommand="SELECT Book.photo AS 图书照片, Book.name AS 书名, Book.class AS 类别, PressID.press AS 出版社 FROM Book INNER JOIN PressID ON Book.PressID = PressID.id"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
