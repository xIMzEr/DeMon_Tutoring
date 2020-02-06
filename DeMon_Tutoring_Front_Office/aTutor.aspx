<%@ Page Language="C#" AutoEventWireup="true" CodeFile="aTutor.aspx.cs" Inherits="aTutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        First Name&nbsp; 
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        </p>
    <p>
        Last Name&nbsp;
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        </p>
    <p>
        Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </p>
    <p>
        Subject&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
        </p>
    <p>
        Date Added
        <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="Available" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="64px" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="64px" />
        </p>
    <p>
        &nbsp;</p>
    </form>
</body>
</html>
