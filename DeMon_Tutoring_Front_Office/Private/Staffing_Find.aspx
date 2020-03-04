<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staffing_Find.aspx.cs" Inherits="Private_Staffing_Find" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-weight: 700" id="div">
            StaffID<br />
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
            <br />
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
        </div>
    </form>
</body>
</html>
