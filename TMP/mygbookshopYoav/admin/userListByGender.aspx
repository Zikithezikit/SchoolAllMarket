<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userListByGender.aspx.cs" Inherits="admin_userListByGender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 102px; left: 608px" Text="מגדר"></asp:Label>
        <asp:DropDownList ID="ddl_gender" runat="server" DataSourceID="SqlDataSource1" DataTextField="gender" DataValueField="gender" style="z-index: 1; position: absolute; top: 154px; left: 925px" OnSelectedIndexChanged="ddl_gender_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString6 %>" ProviderName="<%$ ConnectionStrings:ConnectionString6.ProviderName %>" SelectCommand="SELECT [gender] FROM [tblGender]"></asp:SqlDataSource>
        <asp:GridView ID="grd_Details" runat="server" style="z-index: 1; width: 538px; height: 115px; position: absolute; top: 193px; left: 439px" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
        </asp:GridView>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 153px; left: 439px" Text=""></asp:Label>
    </form>
</body>
</html>
