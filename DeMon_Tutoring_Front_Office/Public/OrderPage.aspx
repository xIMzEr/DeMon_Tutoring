<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order Number <br />
            <asp:TextBox ID="txtOrderNumber" runat="server" Text=""></asp:TextBox>
             <br />
            Order Date <br />
            <asp:Label ID="txtOrderDate" runat="server" Text=""></asp:Label>
             <br />
            Payment complete ? 
            <br />
            <asp:Label ID="txtPaymentComplete" runat="server" Text=""></asp:Label>
             <br />
            CustomerID
            <asp:Label ID="txtCustomerID" runat="server" Text=""></asp:Label>
             <br />
            Staff ID
            <asp:Label ID="txtStaffID" runat="server" Text=""></asp:Label>
             <br />
        </div>
    </form>
</body>
</html>