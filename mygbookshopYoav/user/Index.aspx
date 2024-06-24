 <%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="user_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>דף הבית</title>
    <link href="../Styles/StyleLogin.css" rel="stylesheet" />
</head>
<body class="main">
   
    <div class="overlay">
        <form id="form1" runat="server">
        <div>
            
            <ul>
                <li> <asp:Button ID="btn_cart"  CssClass="Button"  runat="server" OnClick="Button1_Click" style="z-index: 1;" Text="לסל שלי" /></li>
                <li><asp:Button CssClass="Button" ID="btn_register" runat="server" OnClick="btn_register_Click" style="z-index: 1;  " Text="לרשום משתמש" /></li>
                <li><asp:Button CssClass="Button" ID="btn_login" runat="server" OnClick="btn_login_Click" style="z-index: 1; " Text="להתחברות משתמש" /></li>
                <li> <asp:Button CssClass="Button" ID="btn_pnl_books" runat="server" OnClick="btn_pnl_books_Click" style="z-index: 1;  " Text="לקטלוג ספרים פנלים" /></li>
                <li><asp:Button CssClass="Button" ID="btn_Admin" runat="server" OnClick="btn_Admin_Click" style="z-index: 1; " Text="להתחברות מנהל" /></li>
                <li><asp:Button CssClass="Button" ID="btn_grd" runat="server" style="z-index: 1; " Text="לגרידוו קטלוג" OnClick="btn_grd_Click" /></li>
                <asp:Label ID="lblwellcome" runat="server" style="z-index: 1; position: absolute; top: 14px;border-bottom:solid white 1px; color:rgb(64,131,108); right:20px;" Text="חנות הספרים שלי"></asp:Label>
                
            </ul>
    
        </div>

            
            <asp:ImageButton ID="im_cart" ImageUrl="../images/cart.png" runat="server" style=" Height:30px; Width:30px; top:1%; position:absolute; right:8%; z-index:2;" OnClick="im_cart_Click"/>
            <asp:Label ID="lbl_AmountOfItems" Text="0" runat="server" style=" color:red; top:2.8%; position:absolute; right:7.5%; z-index:3;" />
        
       
        
        
        </form>
    </div>
    
</body>
</html>
