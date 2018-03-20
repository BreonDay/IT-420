<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Confirmation.aspx.vb" Inherits="BreonDayAssignment9.Confirmation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Confirimation Success</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Thank you for your order<br />
        <asp:HyperLink ID="ReturnHyperLink" runat="server" NavigateUrl="~/Default.aspx">Return to Orders</asp:HyperLink>
    
    </div>
    </form>
</body>
</html>
