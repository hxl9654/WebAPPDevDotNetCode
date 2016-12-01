<%@ Page Language="C#" AutoEventWireup="true" CodeFile="main.aspx.cs" Inherits="main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="refresh" content="5" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>聊天室</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBoxAll" runat="server" Height="224px" TextMode="MultiLine" Width="373px"></asp:TextBox>
        </div>
        <div>
            <asp:TextBox ID="TextBoxSend" runat="server" Width="328px"></asp:TextBox><asp:Button ID="ButtonSend" runat="server" Text="发送" OnClick="ButtonSend_Click" />
        </div>
    </form>
</body>
</html>
