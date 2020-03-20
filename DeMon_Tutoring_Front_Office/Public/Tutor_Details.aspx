<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tutor_Details.aspx.cs" Inherits="Public_Tutor_Details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 521px; width: 318px">
            <h1>
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Sign Up Form" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="30px" style="text-align: center; font-size: large" Width="272px"></asp:Label>
            </h1>
            <strong>Tutor ID</strong><br />
            <asp:TextBox ID="txtTutorId" runat="server" ></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="58px" />
            <br />
            <br />
            First Name<br />
            <asp:TextBox ID="txtFirstName" runat="server" ></asp:TextBox>
            <br />
            Last Name<br />
            <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
            <br />
            Email<br />
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <br />
            Password<br />
             <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
            <br />
            Subject<br />
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            <br />
            Availibility<br />
            <asp:CheckBox ID="chkAvailable" runat="server" Checked="True" Text="Availability" />
            <br />
            Date Added<br />
            <asp:TextBox ID="txtDateAdded" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" ForeColor="#009900" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" ForeColor="#CC0000" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[]"></asp:Label>
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
