<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteTutor.aspx.cs" Inherits="Public_DeleteTutor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 686px;
            height: 163px;
        }
        .auto-style3 {
            text-align: center;
            height: 175px;
            width: 708px;
        }
        .auto-style4 {
            font-size: x-large;
        }
        .auto-style5 {
            margin-left: 65px;
        }
    </style>
</head>
<body class="auto-style5">
    <form id="form1" runat="server">
        <div class="auto-style2">
            <h1 class="auto-style3">
            <strong>Are you sure that you want to delete this record?</strong><br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" CssClass="auto-style4" ForeColor="Red" Height="40px" Width="100px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" CssClass="auto-style1" Font-Bold="True" ForeColor="#33CC33" Width="150px" Height="40px" />
            </h1>
        </div>
    </form>
</body>
</html>
