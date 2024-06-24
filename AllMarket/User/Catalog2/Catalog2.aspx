<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Catalog2.aspx.cs" Inherits="User_Catalog2_Catalog2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>קטלוג 2</title>
    <link href="./Catalog2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><asp:Button Visible="false" style="color:red; right:430px; z-index:2; position:absolute;" CssClass="Button" Text="התנתק" ID="btn_logout" runat="server" OnClick="btn_logout_to_Login"  /></li>
            <li><asp:Button CssClass="Button" Text="התחבר" id="btn_login_goto" runat="server" OnClick="btn_login_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="הרשם" ID="btn_register_goto" runat="server" OnClick="btn_register_goto_Click"  /></li>
                        <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>

            <li><asp:Button CssClass="Button" Visible="false" Text="דף מנהל" ID="btn_Admin_goto" runat="server" OnClick="btn_Admin_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="צרו קשר" ID="btn_ContactUs" runat="server" OnClick="btn_ContactUs_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="העלו מוצר" ID="btn_uploadProduct" runat="server" OnClick="btn_uploadProduct_Click"  /></li>
        </ul>
                <asp:GridView Visible="false" ID="grd_AllProducts" runat="server"></asp:GridView>

        <div class="Products">
            <%Blocks(); %>
        </div>
    
    </form>
</body>
</html>
