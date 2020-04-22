<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="Public_DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnY" runat="server" OnClick="btnY_Click" Text="Yes" />
&nbsp;
            <asp:Button ID="btnN" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
