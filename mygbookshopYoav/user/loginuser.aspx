<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginuser.aspx.cs" Inherits="user_loginuser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="Panel1" runat="server" BackColor="White" style="z-index: 1; width: 370px; height: 326px; position: absolute; top: 203px; left: 767px">
            <asp:Label ID="Label2" runat="server" ForeColor="black" style="z-index: 1; position: absolute; top: 58px; left: 270px; width: 88px; height: 20px;" Text=":שם משתמש" Font-Bold="True"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="black" style="z-index: 1; position: absolute; top: 131px; left: 266px; width: 92px; height: 20px" Text=":הכנס סיסמא"></asp:Label>
            <asp:Button ID="Btn_login" runat="server" style="z-index: 1; position: absolute; top: 265px; left: 44px; width: 89px; height: 39px" Text="התחבר" CssClass="Btn_login" OnClick="Btn_login_Click"/>
            <asp:TextBox ID="Txt_user" runat="server" style="z-index: 1; position: absolute; top: 55px; left: 68px"></asp:TextBox>
            <asp:TextBox ID="Txt_pass" runat="server" style="z-index: 1; position: absolute; top: 129px; left: 69px"></asp:TextBox>
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" ForeColor="Black" NavigateUrl="~/user/register.aspx" style="z-index: 1; position: absolute; top: 273px; left: 221px">אם לא נרשמת לחץ כאן</asp:HyperLink>
            <asp:Label ID="lbl_succ" runat="server" style="z-index: 1; position: absolute; top: 213px; left: 203px" Text="פרטים שגויים"></asp:Label>
        </asp:Panel>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" style="z-index: 1; position: absolute; top: 123px; left: 874px; width: 181px; height: 30px" Text="התחברות משתמש"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
    <link href="../Styles/StyleLogin.css" rel="stylesheet" />
</body>
</html>
