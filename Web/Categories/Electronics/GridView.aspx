<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridView.aspx.cs" Inherits="Categories_Electronics_GridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4><asp:Literal ID="ltError" runat="server" /></h4>
            <asp:GridView ID="GridView1" runat="server" Height="265px" Width="754px" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:HiddenField ID="hdnColorId" runat="server" Value='<%#DataBinder.Eval(Container.DataItem, "colorId")%>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="name" HeaderText="Name" />
                    <asp:BoundField DataField="hex" HeaderText="Hex" />
                    <asp:TemplateField HeaderText="Color Swatch">
                        <ItemTemplate>
                            <div class="color-swatch">
                                <div class="color-swatch" style='<%#"background-color:#" + Eval("hex") + ";" %>'></div>
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:CommandField ShowEditButton="true" />
                    <asp:CommandField ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
            <div class="row color-table">
                <asp:Button ID="btnAddRow" runat="server" Text="Add new row" CssClass="btn btn-primary" onClick="btnAddRow_Click" />
            </div>
        </div>
    </form>
</body>
</html>
