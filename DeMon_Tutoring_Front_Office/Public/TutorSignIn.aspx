<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorSignIn.aspx.cs" Inherits="Public_TutorSignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 354px;
        }
        .auto-style2 {
            text-align: center;
            margin-left: 40px;
        }
        .auto-style3 {
            margin-left: 67px;
            font-weight: 700;
            font-size: large;
        }
        .auto-style4 {
            font-weight: 700;
            font-size: large;
        }
        .auto-style5 {
            font-weight: 700;
            font-size: large;
        }
        .auto-style6 {
            font-size: large;
            margin-left: 16px;
            text-align: center;
        }
    </style>
</head>
<body class="auto-style6">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Sign in" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="70px" style="text-align: center; font-size: xx-large; margin-left: 75px;" Width="500px" BorderWidth="3px"></asp:Label>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" CssClass="auto-style6" Width="70px" Height="30px" />
            <br />
            <br />
            <br />
            <strong>Tutor ID</strong><br />
            <asp:TextBox ID="txtTutorId" runat="server"></asp:TextBox>
            <br />
            <strong>Tutor Password<br />
            </strong>
            <asp:TextBox ID="txtTutorPassword" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSignIn" runat="server" OnClick="btnSignIn_Click" Text="Sign In" CssClass="auto-style5" ForeColor="#33CC33" Height="30px" Width="100px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" CssClass="auto-style4" ForeColor="Red" Height="30px" Width="100px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="#CC0000" Text="lblError" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>
