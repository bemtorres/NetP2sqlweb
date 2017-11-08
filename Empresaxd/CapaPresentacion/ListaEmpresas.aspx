<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaEmpresas.aspx.cs" Inherits="CapaPresentacion.ListaEmpresas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvEmpresas" runat="server" AutoGenerateColumns="False" 
            DataKeyNames="Rut" 
            onselectedindexchanged="gvEmpresas_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="Rut" HeaderText="Rut" SortExpression="Rut" />
                <asp:BoundField DataField="Dv" HeaderText="Dv" SortExpression="Dv" />
                <asp:BoundField DataField="RazonSocial" HeaderText="RazonSocial" 
                    SortExpression="RazonSocial" />
            </Columns>
        </asp:GridView>
    
    </div>
    <asp:Label runat="server" Text="Rut Seleccionado:"></asp:Label>
    <asp:Label ID="lblSeleccionado" runat="server"></asp:Label>
    <asp:Button ID="btnFormulario" runat="server" Text="Ir a Formulario" Enabled="false" onclick="btnFormulario_Click" />
    <div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
            SelectMethod="GenerarListado" TypeName="CapaNegocio.EmpresaColeccion"></asp:ObjectDataSource>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            DataSourceID="ObjectDataSource1" DataTextField="RazonSocial" 
            DataValueField="Rut" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
