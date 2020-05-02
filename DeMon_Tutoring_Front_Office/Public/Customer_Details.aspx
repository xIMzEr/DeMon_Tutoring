<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_Details.aspx.cs" Inherits="Public_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Customer Form<br />
            <br />
             Enter CustomerID<br />
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox> <asp:Button ID="txtFind" runat="server" Text="Find" OnClick="btnFind_Click" Width="48px" />
            <br />
            <br />
            Enter FirstName<br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter LastName<br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter DateOfBirth<br />
            <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Email<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter PhoneNumber (Not Required)<br />
            <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Password<br />
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter CardNumber<br />
            <asp:TextBox ID="txtCardNo" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter CardDate<br />
            <asp:TextBox ID="txtCardDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" Width="48px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[]" ></asp:Label>
        </div>
    </form>
</body>
</html>
