<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>登录页面</title>
</head>
<body>
    <form id="form2" runat="server">
        <table>
            <tr>
                <td>账号</td>
                <td>
                    <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:CheckBox ID="CheckBoxRememberPassword" runat="server" Text="记住密码" />
                </td>
            </tr>
            <tr>
                <td>密码</td>
                <td>
                    <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="ButtonLogin" runat="server" Text="登录" Width="118px" OnClick="ButtonLogin_Click" />
                    <br />
                    <asp:Button ID="ButtonForgetRememberedPassword" runat="server" Text="取消记住密码" OnClick="ButtonForgetRememberedPassword_Click" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
