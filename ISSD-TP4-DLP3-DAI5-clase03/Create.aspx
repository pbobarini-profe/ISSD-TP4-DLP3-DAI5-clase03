<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="ISSD_TP4_DLP3_DAI5_clase03.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-3">
            <div>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Menu.aspx">Menu</asp:HyperLink>
            </div>
            <div class="input-group mb-3">
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Nombre"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" placeholder="Password"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdown">
            </asp:DropDownList>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Agregar" CssClass="btn btn-primary"/>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</body>
</html>
