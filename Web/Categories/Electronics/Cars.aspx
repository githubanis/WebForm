<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cars.aspx.cs" Inherits="Categories_Electronics_Cars" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Rows="3" SelectionMode="Multiple">
                <asp:ListItem Value="1">Audi</asp:ListItem>
                <asp:ListItem Value="2">Ferari</asp:ListItem>
                <asp:ListItem Value="3">Toyota</asp:ListItem>
                <asp:ListItem Value="4">Marcedis</asp:ListItem>
                <asp:ListItem Value="5">Ford</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
