<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorList.aspx.cs" Inherits="Public_TutorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 492px;
            width: 575px;
        }
        .auto-style1 {}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" ForeColor="#CC0000" Text="Tutor List Form" BackColor="#999999" BorderColor="Black" BorderStyle="Inset" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Font-Strikeout="False" Font-Underline="False" Height="30px" style="text-align: center; font-size: large" Width="272px"></asp:Label>
            <br />
        </div>
        <asp:ListBox ID="lstTutorList" runat="server" Height="228px"  Width="567px" CssClass="auto-style1"></asp:ListBox>
        <br />
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        Enter a Subject
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnDisplayAll" runat="server" OnClick="btnDisplayAll_Click" Text="Display All" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
