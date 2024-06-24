<%@ Page Language="C#" AutoEventWireup="true" CodeFile="register.aspx.cs" Inherits="user_register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Styles/StyleLogin.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lblFail" runat="server" style="z-index: 1; position: absolute; top: 337px; left: 398px" Text="שם המשתמש תפוס"></asp:Label>
        <asp:TextBox ID="txtFname" runat="server" style="z-index: 1; position: absolute; top: 215px; left: 974px"></asp:TextBox>
        <asp:TextBox ID="txtname" runat="server" style="z-index: 1; position: absolute; top: 285px; left: 974px"></asp:TextBox>
        <asp:TextBox ID="txtAdress" runat="server" style="z-index: 1; position: absolute; top: 354px; left: 974px"></asp:TextBox>
        <asp:TextBox ID="txtPhone" runat="server" style="z-index: 1; position: absolute; top: 224px; left: 532px"></asp:TextBox>
        <asp:TextBox ID="txtxmail" runat="server" style="z-index: 1; position: absolute; top: 288px; left: 532px; bottom: 354px; height:30px;"></asp:TextBox>
        <asp:TextBox ID="txtuser" runat="server" style="z-index: 1; position: absolute; top: 336px; left: 532px"></asp:TextBox>
        <asp:TextBox ID="txtpass" runat="server" style="z-index: 1; position: absolute; top: 407px; left: 532px"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 223px; left: 703px" Text="טלפון"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 217px; left: 1135px" Text="שם פרטי"></asp:Label>
        <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 433px; left: 1135px" Text="עיר"></asp:Label>
        <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 1135px" Text="שם משפחה"></asp:Label>
        <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 335px; left: 696px" Text="שם משתמש"></asp:Label>
        <asp:Label ID="Label6" runat="server" style="z-index: 1; position: absolute; top: 408px; left: 697px" Text="סיסמא"></asp:Label>
        <asp:Label ID="Label7" runat="server" style="z-index: 1; position: absolute; top: 292px; left: 695px; width: 60px; height: 15px; bottom: 357px;" Text="מייל"></asp:Label>
        <asp:Label ID="Label8" runat="server" style="z-index: 1; position: absolute; top: 352px; left: 1135px" Text="כתובת"></asp:Label>

        <asp:Button ID="btn_register" runat="server" style="z-index: 1; position: absolute; top: 534px; left: 482px" Text="הרשם" OnClick="btn_register_Click" />
        <asp:Button ID="btn_login" runat="server" style="z-index: 1; position: absolute; top: 539px; left: 648px" Text="לחץ כאן להתחברות" OnClick="btn_login_Click" />
        <asp:Label ID="lblSucc" runat="server" style="z-index: 1; position: absolute; top: 592px; left: 881px" Text="הרישום נקלט בהצלחה"></asp:Label>
        <asp:DropDownList ID="ddl_prefix" runat="server" style="z-index: 1; position: absolute; top: 222px; left: 415px">
            <asp:ListItem>050</asp:ListItem>
            <asp:ListItem>052</asp:ListItem>
            <asp:ListItem>053</asp:ListItem>
            <asp:ListItem>054</asp:ListItem>
            <asp:ListItem>055</asp:ListItem>
            <asp:ListItem>056</asp:ListItem>
            <asp:ListItem>058</asp:ListItem>
            <asp:ListItem>059</asp:ListItem>
        </asp:DropDownList>

        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="cityName" DataValueField="cityId" style="z-index: 1; position: absolute; top: 427px; left: 1002px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString2 %>" ProviderName="<%$ ConnectionStrings:ConnectionString2.ProviderName %>" SelectCommand="SELECT [cityId], [cityName] FROM [tblCities]"></asp:SqlDataSource>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; position: absolute; top: 484px; left: 1129px" Text="מין"></asp:Label>
        <asp:RadioButtonList ID="rbl_Gender" runat="server" DataSourceID="SqlDataSource2" DataTextField="gender" DataValueField="genderId" style="z-index: 1; width: 86px; height: 26px; position: absolute; top: 476px; left: 997px">
        </asp:RadioButtonList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [genderId], [gender] FROM [tblGender]"></asp:SqlDataSource>

    </form>
</body>
</html>
