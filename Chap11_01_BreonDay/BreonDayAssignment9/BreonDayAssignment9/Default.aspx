<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="BreonDayAssignment9._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rough Riders Rodeo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <br />
        <asp:Label ID="MissingInputLabel" runat="server" ForeColor="Red" Text="Missing Input" Visible="False"></asp:Label>
        <br />
        Number of Tickets Needed:<asp:TextBox ID="numTicketsTextBox" runat="server" Width="147px"></asp:TextBox>
        <br />
        Shipping Address:<asp:TextBox ID="addressNameTextBox" runat="server" Width="206px"></asp:TextBox>
        <br />
        Credit Card Number:<asp:TextBox ID="CreditCardNumNameTextBox" runat="server" Width="189px"></asp:TextBox>
        <br />
        Credit Cards Expiration Date:<asp:TextBox ID="CreditCardExpirationDateNameTextBox2" runat="server" Width="133px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:DropDownList ID="CardTypeDropDownList" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Visa</asp:ListItem>
            <asp:ListItem>MasterCard</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:CheckBox ID="AttendingCheckBox" runat="server" Text="Will Be Attending" />
&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Button ID="SubmitButton" runat="server" Text="Submit" />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Label ID="AmountDueLabel2" runat="server" Text="Amount Due:" Visible="False"></asp:Label>
                <asp:Label ID="AmountDueLabel" runat="server" Text="Amount Due:" Visible="False"></asp:Label>
<br />
                <asp:HyperLink ID="ConfirmHyperLink" runat="server" NavigateUrl="~/Confirmation.aspx" Visible="False">Confirm Order</asp:HyperLink>
                &nbsp;&nbsp;
<br />
            </ContentTemplate>
        </asp:UpdatePanel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
    </div>
    </form>
</body>
</html>
