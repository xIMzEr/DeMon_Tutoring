<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffingViewer.aspx.cs" Inherits="Public_StaffingViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 230px">
            <asp:Label ID="lblFirstName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblLastName" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblNumber" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDOB" runat="server" BorderStyle="Dotted" Text="Label" Width="449px"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblValid" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
