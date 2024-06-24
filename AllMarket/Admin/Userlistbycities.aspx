<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Userlistbycities.aspx.cs" Inherits="Admin_Userlistbycities" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>משתמשים לפי עיר</title>
    <link href="~/Styles/MainStyle.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
                <ul>
            <li><asp:Button ID="btn_Userlistbygender" runat="server" Text="משתמשים לפי מין" CssClass="Button" OnClick="btn_Userlistbygender_Click" /></li>
            <li><asp:Button ID="btn_IndexAdmin" runat="server" Text="דף בית אדמין" CssClass="Button" OnClick="btn_IndexAdmin_Click" /></li>
                    <li><asp:Button CssClass="Button" Text="דף הבית" ID="btn_Index" runat="server" OnClick="btn_Index_Click" /></li>
        </ul>

        <asp:DropDownList ID="ddl_City" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="citys" DataValueField="CityId" OnSelectedIndexChanged="ddl_City_SelectedIndexChanged" style="z-index: 1; left: 946px; top: 204px; position: absolute"></asp:DropDownList>


        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString7 %>" ProviderName="<%$ ConnectionStrings:ConnectionString7.ProviderName %>" SelectCommand="SELECT [CityId], [citys] FROM [tblCity]"></asp:SqlDataSource>
    </div>


        <asp:GridView ID="grid_City" runat="server" style="z-index: 1; left: 399px; top: 313px; position: absolute; height: 170px; width: 414px"></asp:GridView>
        <asp:Label ID="lbl_NoUsers" runat="server" style="z-index: 1; left: 605px; top: 532px; position: absolute" Text="Label"></asp:Label>
    </form>
</body>
</html>
