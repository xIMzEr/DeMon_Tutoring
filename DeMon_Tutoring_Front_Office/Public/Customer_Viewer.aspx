<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customer_Viewer.aspx.cs" Inherits="Public_Default" %>

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
            Are Your A Student?<br />
            <asp:RadioButton ID="rdbYes" runat="server" Text="Yes" />
            <asp:RadioButton ID="rdbNo" runat="server" Text="No" />
            <br />
        </div>
    </form>
</body>
</html>
