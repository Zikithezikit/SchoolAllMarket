<%@ Page Language="C#" AutoEventWireup="true" CodeFile="panelsCatalog2.aspx.cs" Inherits="user_panelsCatalog2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Panel ID="pnlBook2" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 83px; left: 962px">
            <asp:TextBox ID="txtbookId2" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice2" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price2" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount2" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px">
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
            <asp:Label ID="Label17" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image4" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd2" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd2_Click" />
            <asp:TextBox ID="txtTotal2" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd2" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" />
            <asp:Label ID="lblSucc2" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label18" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label19" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label20" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label21" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlBook3" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 1125px; left: 951px">
            <asp:TextBox ID="txtbookId3" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice3" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price3" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount3" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px">
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
            <asp:Label ID="Label22" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image5" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd3" runat="server" style="z-index: 1; position: absolute; top: 283px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd3_Click" />
            <asp:TextBox ID="txtTotal3" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd3" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" />
            <asp:Label ID="lblSucc3" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label23" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label24" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label25" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label26" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlBook4" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 616px; left: 337px">
            <asp:TextBox ID="txtbookId4" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice4" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price4" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount4" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px">
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
            <asp:Label ID="Label27" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image6" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd4" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd4_Click" />
            <asp:TextBox ID="txtTotal4" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd4" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" />
            <asp:Label ID="lblSucc4" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label28" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label29" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label30" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label31" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
    
    </div>
        <asp:Panel ID="pnlBook" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 606px; left: 939px">
            <asp:TextBox ID="txtbookId" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px">
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
            <asp:Button ID="btnEnd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd_Click" />
            <asp:TextBox ID="txtTotal" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" />
            <asp:Label ID="lblSucc" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label2" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label3" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label4" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label5" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlBook1" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 91px; left: 324px">
            <asp:TextBox ID="txtbookId1" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txt_bookname1" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price1" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount1" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px" AutoPostBack="True" OnSelectedIndexChanged="ddlAmount1_SelectedIndexChanged">
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
            <asp:Label ID="Label12" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image3" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd1" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd1_Click" />
            <asp:TextBox ID="txtTotal1" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd1" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" OnClick="btnAdd1_Click" />
            <asp:Label ID="lblSucc1" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label13" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label14" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label15" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label16" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
        <asp:Panel ID="pnlBook5" runat="server" style="z-index: 1; width: 493px; height: 533px; position: absolute; top: 1119px; left: 406px">
            <asp:TextBox ID="txtbookId5" runat="server" style="z-index: 1; position: absolute; top: 30px; left: 253px"></asp:TextBox>
            <asp:TextBox ID="txtBookPrice5" runat="server" style="z-index: 1; position: absolute; top: 101px; left: 254px"></asp:TextBox>
            <asp:TextBox ID="txt_book_price5" runat="server" style="z-index: 1; position: absolute; top: 183px; left: 252px"></asp:TextBox>
            <asp:DropDownList ID="ddlAmount5" runat="server" style="z-index: 1; position: absolute; top: 253px; left: 296px">
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
            <asp:Label ID="Label32" runat="server" style="z-index: 1; position: absolute; top: 358px; left: 438px" Text="סה&quot;כ"></asp:Label>
            <asp:Image ID="Image7" runat="server" style="z-index: 1; position: absolute; top: 33px; left: 27px; height: 233px; width: 208px" />
            <asp:Button ID="btnEnd5" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 144px" Text="סיים הזמנה" OnClick="btnEnd5_Click" />
            <asp:TextBox ID="txtTotal5" runat="server" style="z-index: 1; position: absolute; top: 356px; left: 288px"></asp:TextBox>
            <asp:Button ID="btnAdd5" runat="server" style="z-index: 1; position: absolute; top: 284px; left: 42px" Text="הוסף לסל" />
            <asp:Label ID="lblSucc5" runat="server" style="z-index: 1; position: absolute; top: 429px; left: 76px" Text="המוצר נוסף בהצלחה"></asp:Label>
            <asp:Label ID="Label33" runat="server" style="z-index: 1; position: absolute; top: 31px; left: 411px" Text="קוד ספר"></asp:Label>
            <asp:Label ID="Label34" runat="server" style="z-index: 1; position: absolute; top: 103px; left: 417px" Text="שם ספר"></asp:Label>
            <asp:Label ID="Label35" runat="server" style="z-index: 1; position: absolute; top: 185px; left: 419px" Text="מחיר"></asp:Label>
            <asp:Label ID="Label36" runat="server" style="z-index: 1; position: absolute; top: 256px; left: 372px; width: 88px; height: 20px" Text="כמות להזמנה"></asp:Label>
        </asp:Panel>
    </form>
</body>
</html>
