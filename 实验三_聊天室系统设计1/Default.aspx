<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            账号<asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
        </div>
        <div>
            密码<asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="ButtonLogin" runat="server" Text="登录" OnClick="ButtonLogin_Click" />
            <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
