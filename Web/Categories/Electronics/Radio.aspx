<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Radio.aspx.cs" Inherits="Categories_Electronics_Radio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div aria-orientation="vertical">
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">Red</asp:ListItem>
                <asp:ListItem Value="2">Blue</asp:ListItem>
                <asp:ListItem Value="3">Green</asp:ListItem>
                <asp:ListItem Value="4">Yellow</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Clear Selection" />
        </div>
    </form>
</body>
</html>
