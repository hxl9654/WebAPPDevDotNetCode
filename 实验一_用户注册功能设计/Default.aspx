<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>用户注册功能设计</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="账号"></asp:Label>
            <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" Text="登录" />
            <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="清除" />
        </div>
    </form>
    
</body>
</html>
