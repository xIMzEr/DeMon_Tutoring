<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorPersonalDetails.aspx.cs" Inherits="Public_TutorPersonalDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 77px;
            width: 785px;
            text-align: center;
            font-weight: 700;
        }
        #form1 {
            height: 630px;
            width: 803px;
        }
        .auto-style3 {
            text-decoration: underline;
        }
        .auto-style4 {
            font-weight: 700;
        }
        .auto-style2 {
            font-weight: 700;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            margin-left: 51px;
            font-weight: 700;
            font-size: large;
        }
        .auto-style7 {
            font-weight: 700;
        }
        .auto-style8 {
            font-weight: 700;
        }
        .auto-style9 {
            font-size: large;
        }
    </style>
</head>
<body class="auto-style9">
    <form id="form1" runat="server">
        <p class="auto-style1">
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Personal Details" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="70px" style="text-align: center; font-size: xx-large; margin-left: 121px;" Width="500px" BorderWidth="3px"></asp:Label>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" CssClass="auto-style6" Width="70px" Height="30px" />
        </p>
        <div class="auto-style5">
            <span class="auto-style3"><strong>Tutor ID</strong></span><br />
            <asp:TextBox ID="txtTutorId" runat="server" ReadOnly="True" ></asp:TextBox>
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
            <strong>Subject</strong><br />
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Checked="True" Text="Availability" CssClass="auto-style4" />
            <br />
            <br />
            <strong>Date Added</strong><br />
            <asp:TextBox ID="txtDateAdded" runat="server" ReadOnly="True" ForeColor="#666666" TextMode="DateTime"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" ForeColor="#009900" CssClass="auto-style1" Height="31px" Width="108px" />
            <asp:Button ID="btnLogOut" runat="server" OnClick="btnLogOut_Click" Text="Log Out" ForeColor="#CC0000" CssClass="auto-style2" Height="31px" Width="72px" />
            <br />
            <br />
            <asp:Button ID="btnDeleteRecord" runat="server" OnClick="btnDeleteRecord_Click" Text="DELETE RECORD" ForeColor="#CC0000" CssClass="auto-style2" Height="31px" Width="129px" BorderWidth="2px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red" Visible="False" CssClass="auto-style8"></asp:Label>
            <asp:Label ID="lblSuccess" runat="server" CssClass="auto-style7" ForeColor="#00CC00" Text="[lblSuccess]" Visible="False"></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
