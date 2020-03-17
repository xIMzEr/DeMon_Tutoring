<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TutorList.aspx.cs" Inherits="Public_TutorList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstTutorList" runat="server" Height="263px" OnSelectedIndexChanged="lstTutorList_SelectedIndexChanged" Width="433px"></asp:ListBox>
    </form>
</body>
</html>
