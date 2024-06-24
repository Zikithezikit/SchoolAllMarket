<%@ Page Language="C#" AutoEventWireup="true" CodeFile="loginadmin.aspx.cs" Inherits="admin_loginadmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" style="z-index: 1; position: absolute; top: 151px; left: 876px" Text="התחברות מנהל"></asp:Label>
                <asp:Panel ID="Panel1" runat="server" BackColor="Black" style="z-index: 1; width: 370px; height: 326px; position: absolute; top: 203px; left: 767px">
            <asp:Label ID="Label2" runat="server" ForeColor="White" style="z-index: 1; position: absolute; top: 58px; left: 243px; width: 115px; height: 20px;" Text=":שם משתמש מנהל" Font-Bold="True"></asp:Label>
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="White" style="z-index: 1; position: absolute; top: 131px; left: 266px; width: 92px; height: 20px" Text=":סיסמאת מנהל"></asp:Label>
            <asp:Button ID="Btn_adminlogin" runat="server" style="z-index: 1; position: absolute; top: 265px; left: 196px; width: 89px; height: 39px" Text="התחבר" OnClick="Btn_adminlogin_Click" />
            <asp:TextBox ID="Txt_adminuser" runat="server" style="z-index: 1; position: absolute; top: 55px; left: 7px"></asp:TextBox>
            <asp:TextBox ID="Txt_adminpass" runat="server" style="z-index: 1; position: absolute; top: 129px; left: 5px"></asp:TextBox>
                    <asp:Label ID="Lbl_err" runat="server" ForeColor="White" style="z-index: 1; position: absolute; top: 279px; left: 21px" Text="פרטים שגויים"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
