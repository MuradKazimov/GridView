<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="Gridview.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="SearchTxt" runat="server"></asp:TextBox>
            <asp:Button ID="SearchBtn" runat="server" OnClick="SearchBtn_Click" Text="Search" Width="68px" />
        </div>
        <asp:GridView ID="GridTable" runat="server" CssClass="mydatagrid" 
 HeaderStyle-CssClass="header" RowStyle-CssClass="rows" >
        </asp:GridView>
        <p>
            <asp:Label ID="Lbl" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
