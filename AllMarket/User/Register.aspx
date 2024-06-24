<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="User_Register" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>הרשמה</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
    <script src="../JS/JSScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div  style="position:absolute;right:45%;top:30%;display:grid;">
        <asp:TextBox ID="txt_Fname" placeholder="שם" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>
        <asp:TextBox ID="txt_Lname" placeholder="שם משפחה" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>
        <asp:TextBox ID="txt_Username" placeholder="שם משתמש" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>
        <asp:TextBox ID="txt_Password" type="password" placeholder="סיסמא" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>
        <asp:TextBox ID="txt_Email" placeholder="אימייל" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>

        <asp:Button ID="btn_Register" runat="server" Text="הרשם" OnClick="btn_RegisterClick"  CssClass="SimpleButton" style="font-size:20px;margin-bottom:35px;position:relative;" />
        <asp:Button ID="btn_Guest" runat="server" Text="התחבר כאורח" OnClick="btn_GuestClick"  CssClass="SimpleButton" style="font-size:20px;margin-bottom:35px;position:relative;" />
    </div>
        <div style="position:absolute;display:grid;top:35%;right:33%;">
            <asp:DropDownList ID="ddl_Gender" CssClass="ddlStyle" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="Genders" DataValueField="GenderID" Style="margin-bottom: 30px;"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [GenderID], [Genders] FROM [tbl_gender]"></asp:SqlDataSource>
            <asp:DropDownList CssClass="ddlStyle" ID="ddl_PhoneStart" runat="server" style="margin-bottom:30px;" AutoPostBack="True">
                <asp:ListItem>050</asp:ListItem>
                <asp:ListItem>051</asp:ListItem>
                <asp:ListItem>052</asp:ListItem>
                <asp:ListItem>053</asp:ListItem>
                <asp:ListItem>054</asp:ListItem>
                <asp:ListItem>055</asp:ListItem>
                <asp:ListItem>056</asp:ListItem>
                <asp:ListItem>057</asp:ListItem>
                <asp:ListItem>058</asp:ListItem>
                <asp:ListItem>059</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_City" CssClass="ddlStyle" runat="server" DataSourceID="SqlDataSource2" DataTextField="citys" DataValueField="CityId" AutoPostBack="True"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" ProviderName="<%$ ConnectionStrings:ConnectionString.ProviderName %>" SelectCommand="SELECT [citys], [CityId] FROM [tblCity]"></asp:SqlDataSource>
        </div>
        <div style="font-size:15px;position:absolute;top:42%;right:16%;height:auto;width:auto;display:grid;">
            <asp:TextBox ID="txt_PhoneNumber" placeholder="המשך מספר הטלפון" runat="server" style="margin-bottom:34px;position:relative;" CssClass="TxtBoxData" ></asp:TextBox>
            <asp:TextBox ID="txt_Address" placeholder="כתובת" runat="server" CssClass="TxtBoxData" style="position:relative;" ></asp:TextBox>
        </div>
    <input class="ShowPass" type="checkbox"  onclick="password('txt_Password')" id="ShowPassBox"/>
        <asp:Label ID="lbl_error" runat="server" CssClass="Errorlbl" Visible="false" Text="קלט לא תקין" style="color:red;font-size:30px;top:45%;left:10%;"></asp:Label>
    </form>
</body>
</html>
