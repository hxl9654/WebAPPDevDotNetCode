<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="jQuery.js" type="text/javascript"></script>
    <title>BBS</title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div>
                    标题<asp:TextBox ID="TextBoxTitle" runat="server"></asp:TextBox>
                </div>
                <div>
                    正文<asp:TextBox ID="TextBoxContent" runat="server"></asp:TextBox>
                    <asp:Button ID="ButtonSend" runat="server" Text="发布" OnClick="ButtonSend_Click" />
                </div>
                <div>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1" Width="528px">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" SortExpression="Id" />
                            <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                            <asp:BoundField DataField="Content" HeaderText="Content" SortExpression="Content" />
                        </Columns>
                    </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:WebAppDevClassConnectionString %>" InsertCommand="INSERT INTO Board(Title, [Content]) VALUES (@Title, @Content)" SelectCommand="SELECT [Id], [Title], [Content] FROM [Board]">
            <InsertParameters>
                <asp:ControlParameter ControlID="TextBoxTitle" Name="Title" PropertyName="Text" />
                <asp:ControlParameter ControlID="TextBoxContent" Name="Content" PropertyName="Text" />
            </InsertParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
