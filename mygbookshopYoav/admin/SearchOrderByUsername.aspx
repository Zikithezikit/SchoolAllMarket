<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchOrderByUsername.aspx.cs" Inherits="admin_SearchOrderByUsername" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="user_Name" DataValueField="user_Name" style="z-index: 1; left: 1139px; top: 255px; position: absolute" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString10 %>" ProviderName="<%$ ConnectionStrings:ConnectionString10.ProviderName %>" SelectCommand="SELECT [user_Name] FROM [tblUsers]"></asp:SqlDataSource>
        <asp:GridView ID="grd_Details" runat="server" style="z-index: 1; left: 218px; top: 260px; position: absolute; height: 115px; width: 196px">
        </asp:GridView>
        <asp:Label ID="lbl_Error" runat="server" style="z-index: 1; left: 772px; top: 182px; position: absolute" Text="Label"></asp:Label>
        <asp:Panel ID="pnl_Details" runat="server" style="z-index: 1; left: 93px; top: 122px; position: absolute; height: 294px; width: 429px">\
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 292px; top: 33px; position: absolute" Text="מספר פריטים"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 94px; top: 34px; position: absolute" Text="סהכ"></asp:Label>
            <asp:TextBox ID="txt_total" runat="server" style="z-index: 1; left: 59px; top: 73px; position: absolute"></asp:TextBox>
            <asp:TextBox ID="txt_NumberOfItems" runat="server" style="z-index: 1; left: 260px; top: 78px; position: absolute"></asp:TextBox>
            <asp:GridView ID="grd_ByName" runat="server" style="z-index: 1; left: 614px; top: 220px; position: absolute; height: 115px; width: 196px" OnRowCommand="ShowGrdDetails" OnSelectedIndexChanged="grd_ByName_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="פרטים" ShowHeader="True" Text="בחר"/>
                </Columns>
            </asp:GridView>
        </asp:Panel>

    </form>
</body>
</html>
