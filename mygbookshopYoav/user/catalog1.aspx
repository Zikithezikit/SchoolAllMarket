<%@ Page Language="C#" AutoEventWireup="true" CodeFile="catalog1.aspx.cs" Inherits="user_catalog1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>


    <form id="form1" runat="server">
 
       
        
        
        <asp:GridView ID="grd_cart" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" style="z-index: 1; width: 343px; height: 185px; position: absolute; top: 271px; left: 949px">
            <AlternatingRowStyle BackColor="White" />
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
 
       
        
        
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString4 %>" ProviderName="<%$ ConnectionStrings:ConnectionString4.ProviderName %>" SelectCommand="SELECT [typeName] FROM [tblBookType]"></asp:SqlDataSource>
        <asp:DropDownList ID="dbl_books" runat="server" style="z-index: 1; position: absolute; top: 154px; left: 984px; width: 165px;" AutoPostBack="True" OnSelectedIndexChanged="dbl_books_SelectedIndexChanged"  >
        </asp:DropDownList>
        <asp:Panel ID="pnlBook" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 54px; left: 258px">
            <asp:TextBox ID="txtbookId" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px" Enabled="False"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px" Enabled="False"></asp:TextBox>
            <asp:TextBox ID="txt_book_price" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px" Enabled="False"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px" AutoPostBack="True" OnSelectedIndexChanged="ddlAmount_SelectedIndexChanged">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label13" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image1" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd_Click" />
            <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px" Enabled="False"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" OnClick="btnAdd_Click1" />
            <asp:Label ID="lblSucc" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="typeName" DataValueField="typeName" style="z-index: 1; width: 143px; height: 26px; position: absolute; top: 224px; left: 1142px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged1">
        </asp:RadioButtonList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString5 %>" ProviderName="<%$ ConnectionStrings:ConnectionString5.ProviderName %>" SelectCommand="SELECT [typeName] FROM [tblBookType]"></asp:SqlDataSource>
        <asp:Label ID="lbl_mybookshop" runat="server" style="z-index: 1; position: absolute; top: 22px; left: 859px; width: 97px" Text="חנות הספרים שלי"></asp:Label>
    </form>
</body>
</html>
