<%@ Page Language="C#" AutoEventWireup="true" CodeFile="typeBookForGridviewcatalog.aspx.cs" Inherits="user_typeBooksForPanelCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/StyleLogin.css" rel="stylesheet" />
</head>
<body class="main">
    <form id="form1" runat="server">
    <div class="overlay">
    <div>
            <ul>
                <li><asp:Button CssClass="Button" ID="btn_register" runat="server" OnClick="btn_register_Click" style="z-index: 1;  " Text="לרשום משתמש" /></li>
                <li><asp:Button CssClass="Button" ID="btn_login" runat="server" OnClick="btn_login_Click" style="z-index: 1; " Text="להתחברות משתמש" /></li>
                <li> <asp:Button CssClass="Button" ID="btn_pnl_books" runat="server" OnClick="btn_pnl_books_Click" style="z-index: 1;  " Text="לקטלוג ספרים פנלים" /></li>
                <li><asp:Button CssClass="Button" ID="btn_Admin" runat="server" OnClick="btn_Admin_Click" style="z-index: 1; " Text="להתחברות מנהל" /></li>
                <li><asp:Button CssClass="Button" ID="btn_grd" runat="server" style="z-index: 1; " Text="לעמוד הבית" OnClick="btn_index_Click" /></li>
            </ul>
    
        </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 111px; left: 698px" Text="סוגי ספרים"></asp:Label>
        <p>
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/monkyshlofandmonkyblof.jpg" style="z-index: 1; position: absolute; top: 272px; left: 258px; width: 225px; height: 316px" OnClick="ImageButton1_Click" />
        </p>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 218px; left: 936px; color:white;" Text="קומדיה"></asp:Label>
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/grandmabrooktherules.jpg" style="z-index: 1; position: absolute; top: 277px; left: 838px; width: 222px; height: 302px" OnClick="ImageButton3_Click" />
        <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 0px; left: 10px; color:white;" Text="Label"></asp:Label>
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/afarprincess.jpg" style="z-index: 1; position: absolute; top: 275px; left: 555px; width: 226px; height: 307px" OnClick="ImageButton2_Click" />
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 219px; left: 354px; color:white;" Text="ילדים"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 219px; left: 657px; color:white;" Text="פנטזיה" ></asp:Label>
    </div>
    </form>
</body>
</html>
