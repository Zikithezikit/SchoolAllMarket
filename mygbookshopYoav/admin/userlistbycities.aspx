<%@ Page Language="C#" AutoEventWireup="true" CodeFile="userlistbycities.aspx.cs" Inherits="admin_userlistbycities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 108px; left: 753px" Text="לפי ערים"></asp:Label>
        <asp:DropDownList ID="ddl_city" runat="server" DataSourceID="SqlDataSource1" DataTextField="cityName" DataValueField="cityName" style="z-index: 1; position: absolute; top: 172px; left: 993px" OnSelectedIndexChanged="ddl_city_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString7 %>" ProviderName="<%$ ConnectionStrings:ConnectionString7.ProviderName %>" SelectCommand="SELECT [cityName] FROM [tblCities]"></asp:SqlDataSource>
        <asp:GridView ID="grd_Details" runat="server" style="z-index: 1; width: 196px; height: 115px; position: absolute; top: 225px; left: 464px">
        </asp:GridView>
        <asp:Label ID="lbl_user" runat="server" style="z-index: 1; position: absolute; top: 311px; left: 700px" Text="אין אנשים בעיר זו"></asp:Label>
    </form>
</body>
</html>
