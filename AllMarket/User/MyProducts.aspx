<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MyProducts.aspx.cs" Inherits="User_MyProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>המוצרים שלי</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
    <script src="../JS/JSScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><asp:Button Visible="false" style="color:red; right:430px; z-index:2; position:absolute;" CssClass="Button" Text="התנתק" ID="btn_logout" runat="server" OnClick="btn_logout_to_Login"  /></li>
            <li><asp:Button CssClass="Button" Visible="false" Text="דף מנהל" ID="btn_Admin_goto" runat="server" OnClick="btn_Admin_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="צרו קשר" ID="btn_ContactUs" runat="server" OnClick="btn_ContactUs_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
            <li><asp:Button CssClass="Button" Text="העלו מוצר" ID="btn_uploadProduct" runat="server" OnClick="btn_uploadProduct_Click"  /></li>
            <li><asp:Button ID="btn_UpdateUserInfo" runat="server" Text="עדכן פרטי משתמש" CssClass="Button" OnClick="btn_UpdateUserInfo_Click" /></li>
        </ul>
    </div>
        <asp:GridView  ID="grd_AllProducts" runat="server" Height="454px" style="z-index: 1; left: 461px; top: 179px; position: absolute; height: 454px; width: 539px" Width="539px"></asp:GridView>

        <div class="Products">
            <%Blocks(); %>
        </div>
    </form>
</body>
</html>
