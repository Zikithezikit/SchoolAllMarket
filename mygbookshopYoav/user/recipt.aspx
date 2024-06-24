<%@ Page Language="C#" AutoEventWireup="true" CodeFile="recipt.aspx.cs" Inherits="user_recipt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="lbl_numorder" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 795px" Text="Label"></asp:Label>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; position: absolute; top: 27px; left: 612px; width: 159px; height: 18px" Text="מספר ההזמנה שלך הוא:"></asp:Label>
        <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 91px; left: 608px; height: 14px; width: 148px" Text="ושולם בכרטיס אשראי:"></asp:Label>
        <p>
            &nbsp;</p>
        <asp:Label ID="lbl_card" runat="server" Text="Label" style="position:absolute; left: 801px; top: 92px;"></asp:Label>
    </form>
</body>
</html>
