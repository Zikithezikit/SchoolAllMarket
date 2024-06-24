<%@ Page Language="C#" AutoEventWireup="true" CodeFile="IndexAdmin.aspx.cs" Inherits="Admin_IndexAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>דף בית אדמין</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><asp:Button ID="btn_Userlistbygender" runat="server" Text="משתמשים לפי מין" CssClass="Button" OnClick="btn_Userlistbygender_Click" /></li>
            <li><asp:Button ID="btn_Userlistbycities" runat="server" Text="משתמשים לפי עיר" CssClass="Button" OnClick="btn_Userlistbycities_Click" /></li>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
        </ul>
        <asp:Label Text=" " ID="lbl_Countusers" runat="server" style="position:absolute;top:50%;left:50%;" />
    </div>
    </form>
</body>
</html>
