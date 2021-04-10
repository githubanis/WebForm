<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Ad.aspx.cs" Inherits="Categories_Electronics_Ad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:AdRotator ID="AdRotator1" runat="server" AdvertisementFile="~/AddData.xml" KeywordFilter="gifts" Target="_blank" />
        </div>
    </form>
</body>
</html>
