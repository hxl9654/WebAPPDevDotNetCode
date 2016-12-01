<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>请登录后继续</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            您还没有登录或密码错误，或网页时间超时，请重新登录！
        </div>
        <div>
            3秒后跳转到登录页面...
        </div>
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <asp:Timer ID="TimerRedirect" runat="server" Interval="3000" OnTick="TimerRedirect_Tick"></asp:Timer>
    </form>

</body>
</html>
