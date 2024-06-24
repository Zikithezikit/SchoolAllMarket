<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Donate.aspx.cs" Inherits="User_Donate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>תרמו לנו</title>
    <link href="../Styles/MainStyle.css" rel="stylesheet" />
    <script src="../JS/JSScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
        </ul>
    <div>
        <asp:Panel ID="pnl_CreditCard" style="position:absolute;width:800px;height:800px; top: 25px; left: 436px;" runat="server">
            <asp:TextBox CssClass="TxtBoxData" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_CardNumber" placeholder =" מספר כרטיס" MaxLength="16" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_Id" placeholder="מספר תעודת זהות" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:175px;" ID="txt_Year" placeholder="YYYY"  MaxLength="4" runat="server" />
            <asp:TextBox CssClass="TxtBoxData" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;" ID="txt_Month" placeholder="MM"  MaxLength="2" runat="server" />
            <br />
            <asp:TextBox CssClass="TxtBoxData" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:300px;" ID="txt_CVC" placeholder="CVC" MaxLength="3" runat="server" />
            <br />
            <asp:DropDownList CssClass="ddlStyle" style="position:relative;margin-top:80px;display: inline-block;vertical-align: middle;margin-left:365px;" ID="ddl_CardType" runat="server">
                <asp:ListItem Text="סוג כרטיס" />
                <asp:ListItem Text="Mastercard" />
                <asp:ListItem Text="Visa" />
                <asp:ListItem Text="Americanexpress" />
                <asp:ListItem Text="IsraCard" />
            </asp:DropDownList>
            <asp:Label Text="Eror" ID="lbl_Error" Visible="false" style="color:red;" runat="server" />
            <br />
            <asp:Button ID="btn_Donate" CssClass="SimpleButton" Style="margin-left:380px;margin-top:80px;font-size:20px;text-align:center;" Text="תרמו לנו" runat="server" OnClick="btn_Donate_Click" />
        </asp:Panel>
        <asp:Panel ID="pnl_amountDonated" style="position:absolute;width:200px;height:200px; top: 145px; left: 1458px;" runat="server">
            <asp:DropDownList ID="ddl_Amount" CssClass="ddlStyle" style="margin-left:60px;" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Amount_SelectedIndexChanged">
                <asp:ListItem Text="בחר סכום" />
                <asp:ListItem Text="10₪" />
                <asp:ListItem Text="20₪" />
                <asp:ListItem Text="30₪" />
                <asp:ListItem Text="סכום שונה" />
            </asp:DropDownList>
            <br />
            <asp:TextBox CssClass="TxtBoxData" style="margin-top:40px;" ID="txt_Amount" placeholder="רשום כאן סכום שונה" runat="server" />
            <br />
            
        </asp:Panel>

        <asp:GridView ID="grd_receipt" Visible="false" runat="server" style="z-index: 1; left: 25px; top: 101px; position: absolute; height: 107px; width: 399px"></asp:GridView>
    </div>
        <asp:Label ID="lbl_receipt" Visible="false"  runat="server" style="z-index: 1; left: 194px; top: 72px; position: absolute" Text="קבלה"></asp:Label>
    </form>
</body>
</html>
