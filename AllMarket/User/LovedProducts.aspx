<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LovedProducts.aspx.cs" Inherits="User_LovedProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>מוצרים אהובים</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
        <script src="../JS/JSScript.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><asp:Button id="btn_index" runat="server" CssClass="Button" Text="לדף הבית" OnClick="btn_index_Click" /></li>
        </ul>
        <asp:Label id="lbl_UserName" style="position:absolute;top:0%;z-index:-1;" Visible="true" Text="text" runat="server" ></asp:Label>

        <asp:GridView runat="server" ID="grd_Favorite"></asp:GridView>
        <div class="Products">
            <%Blocks(); %>
        </div>
    </div>
    </form>
    <style>
        .CartLogo:hover{
            filter: grayscale(100%);
            -webkit-filter: grayscale(100%);
        }
    </style>
</body>
</html>
