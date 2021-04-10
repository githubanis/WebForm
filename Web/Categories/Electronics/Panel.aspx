<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Panel.aspx.cs" Inherits="Categories_Electronics_Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table style="width:100%;">
            <tr>
                <td><p>Control Panel</p></td>
                <td>
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Text="Label" Value="lbl" ></asp:ListItem>
                        <asp:ListItem Text="TextBox" Value="txt" ></asp:ListItem>
                        <asp:ListItem Text="Button" Value="btn" ></asp:ListItem>
                    </asp:CheckBoxList></td>
                <td><p>How Many</p></td>
                <td>
                    <asp:TextBox ID="htxt" runat="server" Width="40px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="gbtn" runat="server" Text="Genegate Controlls" OnClick="gbtn_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="5">Label Controls</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="panelLbl" runat="server"></asp:Panel>
                </td>
            </tr>
             <tr>
                <td colspan="5">TextBox Controls</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="panelTxt" runat="server"></asp:Panel>
                </td>
            </tr>
            <tr>
                <td colspan="5">Button Controls</td>
            </tr>
            <tr>
                <td>
                    <asp:Panel ID="panelBtn" runat="server"></asp:Panel>
                </td>
            </tr>
        </table>
        </div>
    </form>    
</body>
</html>
