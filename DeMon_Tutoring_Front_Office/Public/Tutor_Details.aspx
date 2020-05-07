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
        .auto-style5 {
            text-align: center;
            margin-left: 32px;
        }
        .auto-style6 {
            font-weight: 700;
            margin-left: 49px;
            font-size: medium;
        }
        .auto-style7 {
            font-size: large;
        }
        .auto-style8 {
            font-size: large;
        }
        .auto-style9 {
            height: 638px;
            width: 771px;
            margin-left: 90px;
            margin-bottom: 23px;
        }
        .auto-style10 {}
    </style>
</head>
<body class="auto-style9">
    <form id="form1" runat="server">
        <div style="height: 555px; width: 734px; text-align: center; font-size: medium;">
            <h1 class="auto-style5">
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor Sign Up" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="70px" style="text-align: center; font-size: xx-large; margin-left: 57px;" Width="500px" BorderWidth="3px"></asp:Label>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" CssClass="auto-style6" Width="70px" Height="30px" />
            &nbsp;
            &nbsp;&nbsp;&nbsp;
            </h1>
            <span class="auto-style3">
            <strong><span class="auto-style8">Tutor ID</span></strong></span><span class="auto-style8"><br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </span>
            <asp:TextBox ID="txtTutorId" runat="server" CssClass="auto-style8" ></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Height="25px" OnClick="btnFind_Click" Text="Find" Width="70px" CssClass="auto-style7" />
            <span class="auto-style8">
            <br />
            <br />
            <strong>First Name</strong><br />
            </span>
            <asp:TextBox ID="txtFirstName" runat="server" CssClass="auto-style8" ></asp:TextBox>
            <span class="auto-style8">
            <br />
            <strong>Last Name</strong><br />
            </span>
            <asp:TextBox ID="txtLastName" runat="server" CssClass="auto-style8"></asp:TextBox>
            <span class="auto-style8">
            <br />
            <strong>Email</strong><br />
            </span>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style8"></asp:TextBox>
            <span class="auto-style8">
            <br />
            <strong>Password</strong><br />
             </span>
             <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style8"></asp:TextBox>
            <span class="auto-style8">
            <br />
            <strong>Subject</strong><br />
            </span>
            <asp:TextBox ID="txtSubject" runat="server" CssClass="auto-style8"></asp:TextBox>
            <span class="auto-style8">
            <br />
            <br />
            <asp:CheckBox ID="chkAvailable" runat="server" Checked="True" Text="Availability" CssClass="auto-style4" />
            <br />
            <br />
            <strong>Date Added</strong><br />
            </span>
            <asp:TextBox ID="txtDateAdded" runat="server" ReadOnly="True" ForeColor="#666666" TextMode="DateTime" CssClass="auto-style8"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" ForeColor="#009900" CssClass="auto-style1" Height="30px" Width="100px" />
            <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Text="Cancel" ForeColor="#CC0000" CssClass="auto-style2" Height="30px" Width="70px" />
            <asp:Button ID="btnClear" runat="server" CssClass="auto-style10" Font-Bold="True" Height="30px" OnClick="btnClear_Click" Text="Clear" Width="70px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red" Visible="False"></asp:Label>
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
