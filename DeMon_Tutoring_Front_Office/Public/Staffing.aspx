<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Staffing.aspx.cs" Inherits="Public_Staffing" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 146px">
            Staff First Name<input id="txtFirstName" type="text" /></div>
        <p style="width: 147px; height: 0px">
            Staff Last Name<input id="txtLastName" type="text" /></p>
        <p style="width: 147px">
            Staff Email<input id="txtEmail" type="text" /></p>
        <p style="width: 146px">
            Staff Number<input id="txtNumber" type="text" /></p>
        <p style="width: 147px">
            Staff DOB<input id="txtDOB" type="text" /></p>
        <p>
            &nbsp;</p>
        <asp:Button ID="OkButton" runat="server" Height="26px" Text="Ok" Width="50px" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
    </form>
</body>
</html>
