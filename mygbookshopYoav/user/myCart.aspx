<%@ Page Language="C#" AutoEventWireup="true" CodeFile="myCart.aspx.cs" Inherits="user_myCart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 592px; height: 28px; width: 130px" Text="הסל שלי" Font-Size="XX-Large"></asp:Label>
    
    </div>
        <asp:Panel ID="pnlcradit" runat="server" style="z-index: 1; width: 335px; height: 386px; position: absolute; top: 213px; left: 27px" Visible="False">
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 124px; left: 276px; height: 6px;" Text="מספר כרטיס"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 176px; left: 275px" Text="תוקף"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 241px; left: 274px" Text="חברה"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 55px; left: 275px" Text="תעודת זהות"></asp:Label>
            <asp:Label ID="lblsucc" runat="server" style="z-index: 1; position: absolute; top: 335px; left: 102px" Text="ההזמנה נקלטה בהצלחה במערכת" Visible="False"></asp:Label>
            <asp:TextBox ID="txtcardnum" runat="server" style="z-index: 1; position: absolute; top: 117px; left: 76px"></asp:TextBox>
            <asp:TextBox ID="txtId" runat="server" style="z-index: 1; position: absolute; top: 52px; left: 71px"></asp:TextBox>
            <asp:DropDownList ID="ddlyear" runat="server" style="z-index: 1; position: absolute; top: 173px; left: 157px">
                <asp:ListItem>2023</asp:ListItem>
                <asp:ListItem>2024</asp:ListItem>
                <asp:ListItem>2025</asp:ListItem>
                <asp:ListItem>2026</asp:ListItem>
                <asp:ListItem>2027</asp:ListItem>
                <asp:ListItem>2028</asp:ListItem>
                <asp:ListItem>2029</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlmonth" runat="server" style="z-index: 1; position: absolute; top: 173px; left: 65px">
                <asp:ListItem>01</asp:ListItem>
                <asp:ListItem>02</asp:ListItem>
                <asp:ListItem>03</asp:ListItem>
                <asp:ListItem>04</asp:ListItem>
                <asp:ListItem>05</asp:ListItem>
                <asp:ListItem>06</asp:ListItem>
                <asp:ListItem>07</asp:ListItem>
                <asp:ListItem>08</asp:ListItem>
                <asp:ListItem>09</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="ddlcompany" runat="server" style="z-index: 1; position: absolute; top: 229px; left: 76px; width: 136px; height: 12px">
                <asp:ListItem>visa</asp:ListItem>
                <asp:ListItem>goldmastercard</asp:ListItem>
                <asp:ListItem>diners</asp:ListItem>
                <asp:ListItem>american express</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label7" runat="server" style="z-index: 1; position: absolute; top: 171px; left: 134px; width: 10px; height: 25px" Font-Size="X-Large" Text="/"></asp:Label>
            <asp:Button ID="btnrecupt" runat="server" style="z-index: 1; position: absolute; top: 276px; left: 163px" Text="לחשבונית" OnClick="bynrecipt_Click" Visible="False" />
            <asp:Button ID="btnpay" runat="server" style="z-index: 1; position: absolute; top: 278px; left: 58px" Text="שלם" OnClick="btnpay_Click" />
            <asp:TextBox ID="txtDate" runat="server" OnTextChanged="txtDate_TextChanged" style="z-index: 1; position: absolute; top: 12px; left: 77px"></asp:TextBox>
        </asp:Panel>
        <asp:GridView ID="grdbook" runat="server" style="z-index: 1; width: 340px; height: 207px; position: absolute; top: 322px; left: 544px" CellPadding="4" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="grdbook_SelectedIndexChanged" OnRowDeleting="grdbook_RowDeleting">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:ButtonField AccessibleHeaderText="מחיקה" ButtonType="Button" CommandName="delete" Text="מחק" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:Button ID="btnpnl" runat="server" style="z-index: 1; position: absolute; top: 165px; left: 559px" Text="לתשלום" OnClick="btnpnl_Click" />
        <asp:Label ID="Label8" runat="server" style="z-index: 1; position: absolute; top: 249px; left: 731px" Text="סהכ לתשלום"></asp:Label>
        <asp:TextBox ID="txttotal" runat="server" style="z-index: 1; position: absolute; top: 247px; left: 557px"></asp:TextBox>
        <asp:TextBox ID="txtnum" runat="server" style="z-index: 1; position: absolute; top: 247px; left: 865px"></asp:TextBox>
        <asp:GridView ID="grduser" runat="server" style="z-index: 1; width: 191px; height: 71px; position: absolute; top: 82px; left: 987px; bottom: 427px;" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
            <FooterStyle BackColor="White" ForeColor="#333333" />
            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#487575" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#275353" />
        </asp:GridView>
        <asp:Label ID="Label9" runat="server" style="z-index: 1; position: absolute; top: 250px; left: 1024px; height: 15px" Text="מספר פרטים"></asp:Label>
        <asp:Label ID="Label10" runat="server" style="z-index: 1; position: absolute; top: 75px; left: 1227px" Text="שלח ל"></asp:Label>
        <asp:Label ID="Label11" runat="server" style="z-index: 1; position: absolute; top: 225px; left: 266px" Text="תאריך הזמנה"></asp:Label>
    </form>
</body>
</html>
