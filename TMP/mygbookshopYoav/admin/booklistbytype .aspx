<%@ Page Language="C#" AutoEventWireup="true" CodeFile="booklistbytype .aspx.cs" Inherits="admin_booklistbytype_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 105px; left: 875px" Text="לפי סוג ספר"></asp:Label>
        <asp:DropDownList ID="ddl_Types" runat="server" DataSourceID="SqlDataSource1" DataTextField="typeName" DataValueField="typeName" style="z-index: 1; position: absolute; top: 134px; left: 1066px" AutoPostBack="True" OnSelectedIndexChanged="ddl_Types_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString8 %>" ProviderName="<%$ ConnectionStrings:ConnectionString8.ProviderName %>" SelectCommand="SELECT [typeName] FROM [tblBookType]"></asp:SqlDataSource>
        <asp:GridView ID="grd_Type" runat="server" style="z-index: 1; width: 538px; height: 115px; position: absolute; top: 236px; left: 531px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 207px; left: 541px" Text=""></asp:Label>
    </form>
</body>
</html>
