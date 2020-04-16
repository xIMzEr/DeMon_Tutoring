<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorList.aspx.cs" Inherits="Public_TutorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 525px;
            width: 906px;
            text-align: center;
        }
        .auto-style1 {}
        .auto-style3 {
            font-weight: 700;
        }
        .auto-style4 {
            margin-left: 61px;
            text-align: center;
            }
        .auto-style5 {
            margin-left: 7px;
        }
        .auto-style6 {
            text-align: center;
            height: 531px;
            width: 777px;
            font-weight: 700;
            font-size: large;
            margin-left: 50px;
        }
        .auto-style7 {
            font-weight: 700;
        }
        .auto-style8 {
            font-weight: 700;
        }
        .auto-style9 {
            font-weight: 700;
        }
        .auto-style10 {
            font-weight: 700;
            margin-right: 0px;
        }
        .auto-style11 {
            font-weight: 700;
            margin-left: 66px;
        }
        .auto-style12 {
            font-size: large;
            margin-left: 90px;
        }
        .auto-style13 {
            margin-top: 0px;
        }
    </style>
</head>
<body class="auto-style12">
    <form id="form1" runat="server" aria-orientation="vertical" dir="auto" draggable="false" aria-expanded="true">
        <div class="auto-style6">
        <div class="auto-style4">
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor List" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="70px" style="text-align: center; font-size: xx-large; margin-left: 57px;" Width="500px" BorderWidth="3px"></asp:Label>
            <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" CssClass="auto-style6" Width="70px" Height="30px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;
            <br />
        </div>
        <asp:ListBox ID="lstTutorList" runat="server" Height="235px"  Width="730px" CssClass="auto-style1" Font-Size="Medium"></asp:ListBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" CssClass="auto-style3" Height="30px" Width="90px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Height="30px" Width="90px" CssClass="auto-style8" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Height="30px" Width="90px" CssClass="auto-style9" />
            <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" BorderColor="#CC0000" BorderWidth="3px" CssClass="auto-style4" Height="87px" HorizontalAlign="Center" Width="635px">
            <asp:Label ID="lblFilterTitle" runat="server" Text="Filter" Font-Bold="True" BorderColor="#CC0000" BorderStyle="Dotted" BorderWidth="3px" CssClass="auto-style13" Width="76px"></asp:Label>
            <br />
            <asp:Label ID="lblFilter" runat="server" Text="Enter a Subject: "></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" CssClass="auto-style5" Height="20px" Width="150px"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Width="87px" CssClass="auto-style10" Height="25px" />
            <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" Text="Clear Filter/Display All" CssClass="auto-style11" Height="30px" Width="158px" />
            <br />
            <br />
        </asp:Panel>
        <br />
        <div class="auto-style1">
            <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red"></asp:Label>
        </div>
        </div>
    </form>
</body>
</html>
