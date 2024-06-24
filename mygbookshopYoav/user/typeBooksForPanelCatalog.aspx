<%@ Page Language="C#" AutoEventWireup="true" CodeFile="typeBooksForPanelCatalog.aspx.cs" Inherits="user_typeBooksForPanelCatalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="../Styles/Login.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
0       <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/images/monkyshlofandmonkyblof.jpg" style="z-index: 1; position: absolute; top: 272px; left: 258px; width: 225px; height: 316px" OnClick="ImageButton1_Click"  />
        <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 150px; left: 936px; color:black;" Text="קומדיה"></asp:Label>
        <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/images/grandmabrooktherules.jpg" style="z-index: 1; position: absolute; top: 277px; left: 838px; width: 222px; height: 302px" OnClick="ImageButton3_Click" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/images/afarprincess.jpg" style="z-index: 1; position: absolute; top: 275px; left: 555px; width: 226px; height: 307px" OnClick="ImageButton2_Click"  />
    </div>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 111px; left: 698px" Text="סוגי ספרים"></asp:Label>
    </form>
</body>
</html>
