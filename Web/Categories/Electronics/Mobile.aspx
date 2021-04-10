<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Mobile.aspx.cs" Inherits="Categories_Electronics_Mobile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="Select Mobile"  Value="-1"></asp:ListItem>
                <asp:ListItem Text="Apple"          Value="1"></asp:ListItem>
                <asp:ListItem Text="MI"             Value="2"></asp:ListItem>
                <asp:ListItem Text="Samsung"        Value="3"></asp:ListItem>
                <asp:ListItem Text="Vivo"           Value="4"></asp:ListItem>
                <asp:ListItem Text="Oppo"           Value="5"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
