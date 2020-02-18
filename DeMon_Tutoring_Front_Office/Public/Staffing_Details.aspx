<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staffing_Details.aspx.cs" Inherits="Public_Staffing_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700">
            Staff First Name<br />
            <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
            <br />
            Staff Last Name<br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            Staff Email<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Staff Number<br />
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <br />
            Staff DOB<br />
            <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="OkButton" runat="server" OnClick="OkButton_Click" Text="Ok" />
            <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
            <asp:Button ID="Party" runat="server" OnClick="Party_Click" Text="PARTY BUTTON!" />
        </div>
    </form>
</body>
</html>
