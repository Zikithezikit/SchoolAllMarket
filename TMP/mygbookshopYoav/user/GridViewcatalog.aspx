<%@ Page Language="C#" AutoEventWireup="true" CodeFile="GridViewcatalog.aspx.cs" Inherits="user_GridViewcatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Grid View Catalog</title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 37px; left: 713px" Text="רשימת ספרים"></asp:Label>
        <asp:GridView ID="grdBooks" runat="server" style="z-index: 1; width: 196px; height: 115px; position: absolute; top: 213px; left: 871px" OnRowCommand="grdBooks_RowCommand">
               <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="בחר" ShowHeader="True" ShowSelectButton="True" />
                    <asp:TemplateField HeaderText="Picture">
                        <ItemTemplate>
                            &nbsp;<asp:Image ID="Image1" runat="server" Height="67px" ImageUrl='<%# Eval("bookImg","{0}")%>'
                                Style="position: static" Width="80px" />
                        </ItemTemplate>
                    <ItemStyle Height="80px" Width="80px" />
                    </asp:TemplateField>
              </Columns>

        </asp:GridView>
        <asp:Panel ID="pnlBook" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 103px; left: 143px" Visible="False">
            <asp:TextBox ID="txtbookId" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px" OnTextChanged="txtBookPrice_TextChanged"></asp:TextBox>
            <asp:TextBox ID="txt_book_price" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px" OnSelectedIndexChanged="ddlAmount_SelectedIndexChanged">
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
            <asp:Label ID="Label6" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image1" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" />
            <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px" OnTextChanged="txtTotal_TextChanged"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" OnClick="btnAdd_Click" />
            <asp:Label ID="lblSucc" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:Label ID="lbl_booktype" runat="server" style="z-index: 1; position: absolute; top: 36px; left: 919px; width: 98px; height: 19px" Text="Label"></asp:Label>
    </form>
</body>
</html>
