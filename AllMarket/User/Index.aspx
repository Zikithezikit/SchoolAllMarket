<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Pages_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>דף הבית</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
        <script src="../JS/JSScript.js"></script> 
</head>
<body>
    <form id="form1" runat="server">
      <ul> 
            <li><asp:Button Visible="false" style="color:red; right:430px; z-index:2; position:absolute;" CssClass="Button" Text="התנתק" ID="btn_logout" runat="server" OnClick="btn_logout_to_Login"  /></li>
            <li><asp:Button CssClass="Button" Text="התחבר" id="btn_login_goto" runat="server" OnClick="btn_login_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="הרשם" ID="btn_register_goto" runat="server" OnClick="btn_register_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Visible="false" Text="דף מנהל" ID="btn_Admin_goto" runat="server" OnClick="btn_Admin_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="צרו קשר" ID="btn_ContactUs" runat="server" OnClick="btn_ContactUs_Click"  /></li>
            <li><asp:Button CssClass="Button" Text="העלו מוצר" ID="btn_uploadProduct" runat="server" OnClick="btn_uploadProduct_Click"  /></li>
          <li><asp:Button Text="קטלוג שני" CssClass="Button" ID="btn_Catalog2" runat="server" OnClick="btn_Catalog2_Click" /></li>
            <li><asp:Button ID="btn_UpdateUserInfo" runat="server" Text="עדכן פרטי משתמש" CssClass="Button" OnClick="btn_UpdateUserInfo_Click" /></li>
            <li><asp:Button CssClass="Button" Text="המוצרים שלי" id="btn_MyProducts" runat="server" OnClick="btn_MyProducts_Click"   /></li>
          <li>
              <asp:Button Text="תרמו לנו" CssClass="Button" ID="btn_DonateGoTo" runat="server" OnClick="btn_DonateGoTo_Click" /></li>
          <li><asp:Button CssClass="Button" Text="Test" id="btn_Test" runat="server" OnClick="btn_Test_Click"   /></li>
          <li>
              <asp:Button ID="btn_ForgotCredit" CssClass="Button" Text="שחכתי אשראי" runat="server" OnClick="Unnamed1_Click" /></li>
        </ul>
        <asp:Label ID="lbl_Welcome" Text="ברוך הבא אורח" runat="server" style="z-index: 3; right: 2%; top: 15px; position: fixed; border-bottom:solid black 1px;"  />
        <asp:ImageButton ID="ib_Heart" ImageUrl="~/img/heart-Logo.png" class="CartLogo" style="position:fixed;" runat="server" OnClick="ib_Heart_Click" />
        <asp:ImageButton  ID="ib_Logo"  ImageUrl="~/img/AllMarketLogo.png" Cssclass="Logo"  runat="server" />

        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [CategoryId], [CategoryName] FROM [tbl_Category]"></asp:SqlDataSource>
        <asp:DropDownList ID="ddl_Category" CssClass="dropdown_category" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryId" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="ddl_Condition" CssClass="dropdown_category" runat="server" DataSourceID="SqlDataSource2" DataTextField="ConditionName" DataValueField="ConditionId"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString4 %>" ProviderName="<%$ ConnectionStrings:ConnectionString4.ProviderName %>" SelectCommand="SELECT [ConditionId], [ConditionName] FROM [tbl_Condition]"></asp:SqlDataSource>
        <asp:Button ID="btn_Filter" runat="server" Text="סנן" CssClass= "FilterButton" OnClick="btn_Filter_Click"/>
        <asp:Button ID="btn_allProducts" runat="server" Text="כל המוצרים" CssClass= "Button_allProducts" OnClick="btn_allProducts_Click" />

        <asp:Button id="btn_AddToFavorite" Visible="false" runat="server" Text="Button" OnClick="GetButtonId" />
        <asp:Label id="lbl_FavoriteId" Text="text" Visible="false" runat="server" ></asp:Label>
        <asp:Label id="lbl_UserName"  style="position:absolute;z-index:-1;" Visible="true" Text="text" runat="server" ></asp:Label>
        <asp:GridView Visible="false" ID="grd_AllProducts" runat="server"></asp:GridView>

        <div class="Products">
            <%Blocks(); %>
        </div>
    </form>

</body>
</html>
