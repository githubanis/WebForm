<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Pc.aspx.cs" Inherits="Categories_Electronics_Pc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Select All" />
&nbsp;<asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Deselect All" />
            <br />
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="1">SSC</asp:ListItem>
                <asp:ListItem Value="2">HSC</asp:ListItem>
                <asp:ListItem Value="3">BSc</asp:ListItem>
                <asp:ListItem Value="4">MSc</asp:ListItem>
                <asp:ListItem Value="5">Dr</asp:ListItem>
            </asp:CheckBoxList>

            <br />

            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
