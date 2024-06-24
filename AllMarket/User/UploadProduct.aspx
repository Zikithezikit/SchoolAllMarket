<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UploadProduct.aspx.cs" Debug="true" Inherits="User_UploadProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>העלה מוצר</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
    <script src="../JS/JSScript.js"></script>


</head>
<body>
    <form id="form1" runat="server">
         <ul>
            <li><asp:Button CssClass="Button" Text="התחבר" ID="btn_login_goto" runat="server" OnClick="btn_login_goto_Click"   /></li>
            <li><asp:Button CssClass="Button" Text="הרשם" ID="btn_register_goto" runat="server" OnClick="btn_register_goto_Click"  /></li>
            <li><asp:Button CssClass="Button" Visible="false" Text="דף מנהל" ID="btn_Admin_goto"  runat="server"  /></li>
            <li><asp:Button CssClass="Button" Text="צרו קשר" ID="btn_ContactUs" runat="server" /></li>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="Button1_Click_Index"   /></li>
             <li><asp:Button CssClass="Button" Text="המוצרים שלי" id="btn_MyProducts" runat="server" OnClick="btn_MyProducts_Click"   /></li>
        </ul>
     
    <div>
        
        <asp:FileUpload ID="Fu_Img" CssClass="FileUpload" accept="image/*" multiple="false" runat="server" onchange="showimagepreview1(event)"  />
        <asp:Image ID="image_upload_preview" CssClass="imgUpload"  runat="server" Height="300px" Width="300px" />
        <asp:Label ID="lbl_t" runat="server" Text="Label" Visible="false"></asp:Label>
        <asp:Button ID="btn_UploadProduct" Text="העלה" CssClass="SimpleButton" style="position:absolute;top:75%;left:50%;font-size:25px;" runat="server"  OnClick="btn_UploadProduct_Click" />
        <div class="txtDiv">
            <asp:TextBox ID="txt_title" placeholder="הכנס כותרת" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_price" placeholder="הכנס מחיר" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_description" placeholder="הכנס תיאור" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
            <asp:TextBox ID="txt_date" placeholder="תאריך" ReadOnly="true" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
        </div>
    </div>
        <asp:DropDownList CssClass="ddlStyle" style="position:absolute;right:25%;" ID="ddl_Category" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryId"></asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT [CategoryId], [CategoryName] FROM [tbl_Category]"></asp:SqlDataSource>
        <asp:DropDownList ID="ddl_Condition" CssClass="ddlStyle" style="position:absolute;right:25%;top:50%;" runat="server" DataSourceID="SqlDataSource2" DataTextField="ConditionName" DataValueField="ConditionId"></asp:DropDownList>

         <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString6 %>" ProviderName="<%$ ConnectionStrings:ConnectionString6.ProviderName %>" SelectCommand="SELECT [ConditionId], [ConditionName] FROM [tbl_Condition]"></asp:SqlDataSource>
        <asp:Label ID="lbl_Error" Text="Error" style="color:red; z-index: 1; left: 442px; top: 583px; position: absolute;" Visible="false" runat="server" />
    </form>
</body>
</html>
