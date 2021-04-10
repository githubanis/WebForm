<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Submit.aspx.cs" Inherits="Categories_Electronics_Submit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="cancel" runat="server" OnClick="cancel_Click" Text="Cancel" UseSubmitBehavior="False" />
            <asp:Button ID="submit" runat="server" OnClick="submit_Click" Text="Submit" />
            <br />
            <br />
            <asp:Label ID="msg" runat="server" Font-Bold="True" ForeColor="#006600"></asp:Label>
        </div>
    </form>
</body>
</html>
