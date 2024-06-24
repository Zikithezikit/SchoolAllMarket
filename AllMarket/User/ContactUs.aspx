<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ContactUs.aspx.cs" Inherits="User_ContactUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>צרו קשר</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
        </ul>
        <div style="height: 296px; z-index: 1; left: 371px; top: 144px; position: absolute; width: 1389px">
            <asp:TextBox ID="txt_Email" placeholder="אימייל" runat="server" CssClass="TxtBoxData" style="font-size:15px;margin-bottom:55px;position:relative;"></asp:TextBox>
             <asp:TextBox ID="txt_date" placeholder="תאריך" ReadOnly="true" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
             <asp:TextBox ID="txt_Comment" placeholder="תגובה" CssClass="TxtSellProduct" Style="z-index:2;" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="btn_UploadProduct" Text="העלה" CssClass="SimpleButton" style="position:absolute;top:75%;left:50%;font-size:25px;" runat="server" OnClick="btn_UploadProduct_Click" />
        <asp:Label ID="lbl_Upload" runat="server" Text="" style="z-index: 1; left: 705px; top: 566px; position: absolute"></asp:Label>
    </div>
    </form>
</body>
</html>
