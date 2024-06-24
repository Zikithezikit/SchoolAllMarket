<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GetCreditUsingId.aspx.cs" Inherits="User_GetCreditUsingId" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>שחזר פרטי אשראי</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            border-style: none;
            border-color: inherit;
            border-width: medium;
            font-family: ploni;
            font-weight: 500;
            text-align: center;
            font-size: 16px;
            display: block;
            padding: 4px 11px;
            border-radius: 50px;
            color: var(--blue);
            background: none;
            transition: all 0.2s ease-in-out;
            height: 32px;
            width: 60px;
            position: absolute;
            top: 181px;
            left: 665px;
            z-index: 1;
        }
        .auto-style3 {
            width: 693px;
            height: 341px;
            position: absolute;
            top: 187px;
            left: 270px;
            z-index: 1;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <ul>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
        </ul>
    <div>
        <asp:Panel ID="pnl_CreditCard" style="position:absolute;width:800px;height:800px; top: 25px; left: 436px;" runat="server">
            <asp:TextBox CssClass="TxtBoxData" Visible="false" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_CardNumber" placeholder =" מספר כרטיס" MaxLength="16" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData"  style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_Id" placeholder="מספר תעודת זהות" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData" Visible="false" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:175px;" ID="txt_Year" placeholder="YYYY"  MaxLength="4" runat="server" />
            <asp:TextBox CssClass="TxtBoxData" Visible="false" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;" ID="txt_Month" placeholder="MM"  MaxLength="2" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData" Visible="false" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_CVC" placeholder="CVC" MaxLength="3" runat="server" />
            <br />
            <asp:DropDownList CssClass="ddlStyle" Visible="false" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:365px;" ID="ddl_CardType" runat="server">
                <asp:ListItem Text="סוג כרטיס" />
                <asp:ListItem Text="Mastercard" />
                <asp:ListItem Text="Visa" />
                <asp:ListItem Text="Americanexpress" />
                <asp:ListItem Text="IsraCard" />
            </asp:DropDownList>
            <asp:Label Text="Eror" ID="lbl_Error" Visible="false" style="color:red;" runat="server" />
            <br />
            <asp:Button ID="btn_GetCredit" runat="server" CssClass="auto-style1" Text="אשר" OnClick="btn_GetCredit_Click" />
       </asp:Panel>
        <asp:GridView runat="server" Visible="false" ID="grd_Credit" CssClass="auto-style3"></asp:GridView>
    </div>
    </form>
</body>
</html>
