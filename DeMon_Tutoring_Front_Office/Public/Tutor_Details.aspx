<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tutor_Details.aspx.cs" Inherits="Public_Tutor_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: 700;
        }
        .auto-style2 {
            font-weight: 700;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            font-weight: 700;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 521px; width: 318px">
            <h1>
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Sign Up Form" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="30px" style="text-align: center; font-size: large" Width="272px"></asp:Label>
            </h1>
            <span class="auto-style3">
            <strong>Tutor ID</strong></span><br />
            <asp:TextBox ID="txtTutorId" runat="server" ></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="58px" />
            <br />
            <br />
            <strong>First Name</strong><br />
            <asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox>
            <br />
            <strong>Last Name</strong><br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            <strong>Email</strong><br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            <strong>Password</strong><br />
             <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            Subject<br />
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Checked="True" Text="Availability" CssClass="auto-style4" />
            <br />
            <strong>Date Added</strong><br />
            <asp:TextBox ID="txtDateAdded" runat="server" ReadOnly="True" ForeColor="#666666" TextMode="DateTime"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" ForeColor="#009900" CssClass="auto-style1" Height="31px" Width="108px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" ForeColor="#CC0000" CssClass="auto-style2" Height="31px" Width="57px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red" Visible="False"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
