<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Elec.aspx.cs" Inherits="Categories_Electronics_Elec" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <asp:DropDownList ID="dContinent" runat="server" Width="200px" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="dContinent_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:DropDownList ID="dCountry" runat="server" Width="200px" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="dCountry_SelectedIndexChanged">
                </asp:DropDownList>
                <br />
                <br />
                <asp:DropDownList ID="dCity" runat="server" Width="200px" DataTextField="Name" DataValueField="Id" AutoPostBack="True" OnSelectedIndexChanged="dCity_SelectedIndexChanged">
                </asp:DropDownList>
            </div>
        </div>
    </form>
</body>
</html>
