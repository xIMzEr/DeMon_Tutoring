<%@ Page Language="C#" AutoEventWireup="true" CodeFile="HomePage.aspx.cs" Inherits="Public_FrontPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 222px;
            width: 789px;
        }
        .auto-style2 {
            height: 351px;
            width: 804px;
        }
        .auto-style3 {
            font-size: large;
        }
        .auto-style4 {
            font-size: large;
        }
        .auto-style5 {
            font-size: large;
        }
    </style>
</head>
<body class="auto-style2">
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="DeMon Tutoring Home Page" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="51px" style="text-align: center; font-size: xx-large; margin-left: 0px;" Width="464px"></asp:Label>
            <br />
            <br />
            <h1>Tutors</h1>
            <asp:Button ID="btnTutorSignUp" runat="server" Font-Bold="True" OnClick="btnTutorSignUp_Click" Text="Sign Up" Height="40px" Width="100px" CssClass="auto-style5" />
            <asp:Button ID="btnTutorSignIn" runat="server" Text="Sign In" Height="40px" OnClick="btnTutorSignIn_Click" Width="100px" CssClass="auto-style4" />
            <asp:Button ID="btnViewAllRecords" runat="server" CssClass="auto-style3" Height="40px" OnClick="btnViewAllRecords_Click" Text="View All Records" Width="165px" />
            <br />
            <br />
            <br />
            <h2>Student Sign Up</h2>
          <asp:Button ID="btnStudentSignUp" runat="server" Font-Bold="True" OnClick="btnStudentSignUp_Click" Text="Sign Up" Height="40px" Width="100px" CssClass="auto-style5" />
             <asp:Button ID="btnStudentRecords" runat="server" Font-Bold="True" OnClick="btnStudentRecords_Click" Text="Student Records" Height="40px" Width="164px" CssClass="auto-style5" />
        </div>
    </form>
</body>
</html>
