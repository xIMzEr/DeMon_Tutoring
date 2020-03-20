<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FrontPage.aspx.cs" Inherits="Public_FrontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Sign Up Form" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="30px" style="text-align: center; font-size: large" Width="272px"></asp:Label>
            <br />
            <br />
            Tutor<br />
            <asp:Button ID="btnTutorSignUp" runat="server" Font-Bold="True" OnClick="btnTutorSignUp_Click" Text="Sign Up" />
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </div>
    </form>
</body>
</html>
