<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="ISSD_TP4_DLP3_DAI5_clase03.Update" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Menu.aspx">Menu</asp:HyperLink>

            <br />
            <br />
                <asp:ListBox ID="ListBox1" runat="server" CssClass="list-group" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Id"></asp:ListBox>
                <br />
            <div class="input-group mb-3">
                Nombre<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                Password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                Tipo Usuario
                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="dropdown">
                    <asp:ListItem Text="--Seleccione el Tipo--" Value="" />
                </asp:DropDownList>
            </div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Actualizar" CssClass="btn btn-success"/>

            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:cadena %>" SelectCommand="SELECT * FROM [Usuarios]"></asp:SqlDataSource>

            <br />

        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</body>
</html>
