<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BulettedList.aspx.cs" Inherits="Categories_Electronics_BulettedListt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedList1" runat="server" BorderStyle="Ridge" BulletImageUrl="~/Image/processed (1).jpeg" BulletStyle="CustomImage" DisplayMode="LinkButton" OnClick="BulletedList1_Click" Target="_blank">
                <asp:ListItem Text="US" Value="https://google.com"></asp:ListItem>
                <asp:ListItem Text="UK" Value="https://google.com"></asp:ListItem>
                <asp:ListItem Text="India" Value="https://google.com"></asp:ListItem>
                <asp:ListItem Text="Italy" Value="https://google.com"></asp:ListItem>
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
