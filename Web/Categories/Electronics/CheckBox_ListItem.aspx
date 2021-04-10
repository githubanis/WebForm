<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckBox_ListItem.aspx.cs" Inherits="Categories_Electronics_CheckBox_ListItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
                <asp:ListItem Value="1">SSC</asp:ListItem>
                <asp:ListItem Value="2">HSC</asp:ListItem>
                <asp:ListItem Value="3">BSc</asp:ListItem>
                <asp:ListItem Value="4">MSc</asp:ListItem>
                <asp:ListItem Value="5">Dr</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Width="176px" SelectionMode="Multiple">

            </asp:ListBox>

            <br />
            <br />

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
