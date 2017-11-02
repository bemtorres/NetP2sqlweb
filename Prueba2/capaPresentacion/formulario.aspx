<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="formulario.aspx.cs" Inherits="capaPresentacion.formulario" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      Rut  <asp:TextBox ID="Rut" runat="server"></asp:TextBox>   <br />
      DV  <asp:TextBox ID="DV" runat="server"></asp:TextBox>   <br />
      Nombre  <asp:TextBox ID="Nombre" runat="server"></asp:TextBox>   <br />
      Apellido  <asp:TextBox ID="Apellido" runat="server" style="width: 128px"></asp:TextBox>   <br />

        id<asp:TextBox ID="Empresa" runat="server"></asp:TextBox>

      <br />
        <asp:Button ID="agregar" runat="server" Text="Agregar" 
            onclick="agregar_Click" />
        <asp:Button ID="Button1" runat="server" Text="Buscar" onclick="Button1_Click" />
        <asp:Button ID="Button2" runat="server" Text="Eliminar" />
        <br />
        <asp:Label ID="status" runat="server" Text="Label"></asp:Label>
        <br />
        Rut
        <asp:TextBox ID="rutEmpresa" runat="server"></asp:TextBox>
        <br />
        Dv<asp:TextBox ID="dvEmpresa" runat="server"></asp:TextBox>
        <br />
        Razon Social<asp:TextBox ID="razonEmpresa" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Agregar1" runat="server" Text="Agregar" 
            onclick="Agregar1_Click" />
        <asp:Button ID="Eliminar1" runat="server" Text="Eliminar" />
        <asp:Button ID="Modificar1" runat="server" Text="Modificar" />
        <asp:Button ID="Buscar2" runat="server" Text="buscar" onclick="Buscar2_Click" />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Rut" 
            onselectedindexchanged="GridView1_SelectedIndexChanged" >
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Dv" HeaderText="Dv" SortExpression="Dv" />
                <asp:BoundField DataField="RazonSocial" HeaderText="RazonSocial" 
                    SortExpression="RazonSocial" />
            </Columns>
        </asp:GridView>
        <br />
    </div>
    </form>
</body>
</html>
