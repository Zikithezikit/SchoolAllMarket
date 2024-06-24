<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Test.aspx.cs" Inherits="Pages_Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
        <script src="../JS/JSScript.js"></script> 
    <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 91px;
            left: 653px;
            z-index: 1;
        }
        .auto-style2 {
            position: absolute;
            height: 50px;
            width: 50px;
            left: 918px;
            top: 80px;
        }
        .auto-style3 {
            width: 640px;
            height: 374px;
            position: absolute;
            top: 212px;
            left: 681px;
            z-index: 1;
        }
        .auto-style4 {
            position: absolute;
            top: 178px;
            left: 1153px;
            z-index: 1;
            width: 189px;
            height: 190px;
        }
        .auto-style5 {
            width: 549px;
            height: 312px;
            position: absolute;
            top: 203px;
            left: 340px;
            z-index: 1;
        }
        .auto-style6 {
            width: 618px;
            height: 529px;
            position: absolute;
            top: 96px;
            left: 99px;
            z-index: 1;
        }
        .auto-style7 {
            position: absolute;
            top: 110px;
            left: 29px;
            z-index: 1;
            width: 100px;
            height: 100px;
        }
        .auto-style8 {
            position: absolute;
            top: 129px;
            left: 299px;
            z-index: 1;
        }
        .auto-style9 {
            position: absolute;
            top: 233px;
            left: 307px;
            z-index: 1;
        }
        .auto-style10 {
            position: absolute;
            top: 323px;
            left: 300px;
            z-index: 1;
        }
        .auto-style11 {
            position: absolute;
            top: 280px;
            left: 535px;
            z-index: 1;
        }
        .auto-style12 {
            position: absolute;
            top: 414px;
            left: 306px;
            z-index: 1;
        }
        .auto-style13 {
            position: absolute;
            top: 370px;
            left: 37px;
            z-index: 1;
        }
        .auto-style14 {
            position: absolute;
            top: 374px;
            left: 160px;
            z-index: 1;
        }
        .auto-style15 {
            width: 1510px;
            height: 16px;
            position: absolute;
            top: 678px;
            left: 4px;
            z-index: 1;
        }
        .auto-style16 {
            position: absolute;
            height: 100px;
            width: 100px;
            left: 172px;
            top: 743px;
        }
        .auto-style17 {
            position: absolute;
            height: 100px;
            width: 100px;
            left: 330px;
            top: 743px;
        }
        .auto-style18 {
            position: absolute;
            height: 100px;
            width: 100px;
            left: 486px;
            top: 744px;
        }
    </style>
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
        </ul>
        <asp:Label ID="lbl_Welcome" Text="צהריים טובים אורח" runat="server" style="z-index: 3; right: 2%; top: 15px; position: fixed; border-bottom:solid black 1px;"  />
        <asp:ImageButton ID="ib_Heart" ImageUrl="~/img/heart-Logo.png" class="CartLogo" style="position:fixed;" runat="server" OnClick="ib_Heart_Click" />
        <asp:ImageButton  ID="ib_Logo"  ImageUrl="~/img/AllMarketLogo.png" Cssclass="Logo"  runat="server" />
        <asp:TextBox runat="server" CssClass="auto-style1 TxtBoxData" ID="txt_search"/>
        <asp:ImageButton ImageUrl="../img/61088.png" runat="server" CssClass="auto-style2" ID="imgb_Search" OnClick="Unnamed2_Click" />





        <asp:Panel runat="server" Visible="false">
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString3 %>" ProviderName="<%$ ConnectionStrings:ConnectionString3.ProviderName %>" SelectCommand="SELECT [CategoryId], [CategoryName] FROM [tbl_Category]"></asp:SqlDataSource>
        <asp:DropDownList ID="ddl_Category" CssClass="dropdown_category" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryId" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="ddl_Condition" CssClass="dropdown_category" runat="server" DataSourceID="SqlDataSource2" DataTextField="ConditionName" DataValueField="ConditionId"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString4 %>" ProviderName="<%$ ConnectionStrings:ConnectionString4.ProviderName %>" SelectCommand="SELECT [ConditionId], [ConditionName] FROM [tbl_Condition]"></asp:SqlDataSource>
        <asp:Button ID="btn_allProducts" runat="server" Text="כל המוצרים" CssClass= "Button_allProducts" OnClick="btn_allProducts_Click" />
            </asp:Panel>
        <asp:Label id="lbl_FavoriteId" Text="text" Visible="false" runat="server" ></asp:Label>
        <asp:Label id="lbl_UserName"  style="position:absolute;z-index:-1;" Visible="true" Text="text" runat="server" ></asp:Label>
        <asp:GridView Visible="false" ID="grd_AllProducts" runat="server" CssClass="auto-style3"></asp:GridView>
        <asp:GridView runat="server" ID="grd_productbyimg" Visible="false" CssClass="auto-style5" OnSelectedIndexChanged="grd_productbyimg_SelectedIndexChanged"></asp:GridView>


        <asp:ImageButton Visible="false" ImageUrl="./img/CartLogo.png" ID="imgb_SearchedImage" runat="server" CssClass="auto-style4" OnClick="imgb_SearchedImage_Click" />

        <asp:Panel ID="pnl_product" Visible="false" runat="server" CssClass="auto-style6" style="z-index: 1">
            <asp:TextBox runat="server" ID="txt_productId" CssClass="auto-style8" />
            <asp:TextBox runat="server" ID="txt_ProductTitle" CssClass="auto-style9" />
            <asp:TextBox runat="server" Id="txt_ProductPrice" CssClass="auto-style10"/>
            <asp:Image ImageUrl="" runat="server" ID="img_Product" CssClass="auto-style7" />
            <asp:DropDownList ID="ddl_Amount" runat="server" CssClass="auto-style11" AutoPostBack="True" OnSelectedIndexChanged="ddl_Amount_SelectedIndexChanged">
                <asp:ListItem Text="כמות (1)" />
                <asp:ListItem Text="2" />
                <asp:ListItem Text="3" />
                <asp:ListItem Text="4" />
                <asp:ListItem Text="5" />
                <asp:ListItem Text="6" />
            </asp:DropDownList>
            <asp:TextBox runat="server" Id="txt_Total" CssClass="auto-style12"/>
            <asp:Button Text="הוספה לסל" runat="server" CssClass="auto-style13" />
            <asp:Button Text="חזרה לקטלוג" runat="server" CssClass="auto-style14" Height="26px" />
        </asp:Panel>
        <asp:Panel runat="server" style="background-color:black" CssClass="auto-style15"></asp:Panel>

        <asp:ImageButton ID="imgb_1" ImageUrl="" runat="server" Visible="false" CssClass="auto-style17" OnClick="imgb_1_Click" />
        <asp:ImageButton ID="imgb_2" ImageUrl="" runat="server" Visible="false" CssClass="auto-style18" OnClick="imgb_2_Click" />
        <asp:ImageButton ID="imgb_3" ImageUrl="" runat="server" Visible="false" CssClass="auto-style16" OnClick="imgb_3_Click" />
    </form>

</body>
</html>
