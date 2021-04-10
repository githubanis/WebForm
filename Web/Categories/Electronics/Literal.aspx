<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Literal.aspx.cs" Inherits="Categories_Electronics_Literal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="<script>alert('Hello text');</script>">
                <%=Server.HtmlEncode("<script>alert('Hello text');</script>") %>
            </asp:Label>
            <br />
            <br />
            <asp:Literal ID="Literal1" runat="server" Mode="Encode" Text="<script>alert('Hello literal');</script>"></asp:Literal>
        </div>
    </form>
</body>
</html>
