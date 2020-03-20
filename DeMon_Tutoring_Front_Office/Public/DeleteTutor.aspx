<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteTutor.aspx.cs" Inherits="Public_DeleteTutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {}
        .auto-style2 {
            width: 379px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong>Are you sure that you want to delete this record?</strong><br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="auto-style1" Font-Bold="True" ForeColor="Black" Width="86px" />
        </div>
    </form>
</body>
</html>
