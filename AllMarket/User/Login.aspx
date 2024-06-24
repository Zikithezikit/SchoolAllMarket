<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="User_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>התחברות</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
    <script src="../JS/JSScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="txt_Username" placeholder="שם משתמש" runat="server" CssClass="TxtBoxData" style="position:absolute;right:45%;top:30%;font-size:15px;"></asp:TextBox>
        <asp:TextBox ID="txt_Password" type="password" placeholder="סיסמא" runat="server" CssClass="TxtBoxData" style="position:absolute;right:45%;top:35%;font-size:15px;"></asp:TextBox>
        <asp:Button ID="btn_Login" runat="server" Text="התחבר"  CssClass="SimpleButton" style="position:absolute;right:50%;top:40%;font-size:20px;" OnClick="btn_Login_Click"/>
        <asp:Label ID="lbl_error" runat="server" CssClass="Errorlbl" Visible="false" Text="קלט לא תקין" style="color:red;font-size:30px;"></asp:Label>
        <asp:Button ID="btn_Guest" runat="server" Text="התחבר כאורח" OnClick="btn_GuestClick"  CssClass="SimpleButton" style="right:48.5%;top:45%;font-size:20px;margin-bottom:35px;position:absolute;" />
    </div>
        <input class="ShowPass" type="checkbox"  onclick="password('txt_Password')" id="ShowPassBox" style="top:34%;"/>
    </form>
</body>
</html>
